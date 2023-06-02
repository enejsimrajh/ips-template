using System.ComponentModel.DataAnnotations;
using System.Text;
using Csla.Blazor;
using IPSTemplate.AppServer.Helpers;
using IPSTemplate.Dal.Models.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;

namespace IPSTemplate.AppServer.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public partial class Register : ComponentBase
    {
        public class Model
        {
            [Required]
            [EmailAddress]
            [Display(Name = "E-mail")]
            public string? Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string? Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Compare(nameof(Password))]
            [Display(Name = "Confirm password")]
            public string? ConfirmPassword { get; set; }

            [Display(Name = "Name")]
            public string? Name { get; set; }

            [Display(Name = "Surname")]
            public string? Surname { get; set; }
        }

        private UIActionResult? _actionResult;

        [Inject] private SignInManager<TEIdentityUser> SignInManager { get; set; } = default!;

        [Inject] private UserManager<TEIdentityUser> UserManager { get; set; } = default!;

        [Inject] private NavigationManager NavigationManager { get; set; } = default!;

        [Inject] private ILogger<Register> Logger { get; set; } = default!;

        [Inject] private ViewModel<Model> ViewModel { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            await ViewModel.RefreshAsync(() => Task.FromResult(new Model()));
            await base.OnInitializedAsync();
        }

        private async Task RegisterUser()
        {
            // Create new user
            var user = new TEIdentityUser
            {
                UserName = ViewModel.Model.Email,
                Email = ViewModel.Model.Email,
                EmailConfirmed = true,
                Name = ViewModel.Model.Name,
                Surname = ViewModel.Model.Surname
            };
            var result = await UserManager.CreateAsync(user, ViewModel.Model.Password);
            if (!result.Succeeded)
            {
                string errors = string.Join("; ", result.Errors.Select(e => e.Description));
                Logger.LogError("Error creating new user ({UnderlyingErrors})", errors);
                _actionResult = new UIActionResult
                {
                    Message = "Error creating new user.",
                    Status = IPSBlazor.Color.Danger
                };
                return;
            }

            Logger.LogInformation("User created a new account with password.");

            // Send confirmation email
            try
            {
                string userId = await UserManager.GetUserIdAsync(user);
                var code = await UserManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                string callbackUrl = NavigationManager.GetAbsoluteUriWithQueryParameters(
                    "/account/confirm-email",
                    new Dictionary<string, object?>
                    {
                    { "area", "Identity" },
                    { "userId", userId },
                    { "code", code }
                    });
#if DEBUG
                NavigationManager.NavigateTo(callbackUrl);
                return;
#else
                //await DISendConfirmationEmailCommand.ExecuteAsync(ViewModel.Model.Email, callbackUrl);
#endif
            }
            catch
            {
                await UserManager.DeleteAsync(user);
                _actionResult = new UIActionResult
                {
                    Message = "Error sending confirmation email. Please try again later.",
                    Status = IPSBlazor.Color.Danger
                };
                return;
            }

            // Redirect the user
            if (UserManager.Options.SignIn.RequireConfirmedAccount)
            {
                NavigationManager.NavigateTo(
                    "/account/register-confirmation",
                    new Dictionary<string, string?>
                    {
                        { "email", ViewModel.Model.Email }
                    });
            }
            else
            {
                await SignInManager.SignInAsync(user, isPersistent: false);
                if (!NavigationManager.TryGetQueryParameter("returnUrl", out string? returnUrl))
                {
                    returnUrl = "/";
                }
                NavigationManager.NavigateTo(returnUrl!);
            }

            return;
        }
    }
}

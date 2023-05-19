using System.ComponentModel.DataAnnotations;
using Core.Library.Base;
using Csla;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Author
{
    [Serializable]
    public class TEAuthorBO : CslaBusinessBase<TEAuthorBO, TEAuthor>
    {
        #region Properties

        public static readonly PropertyInfo<string> FirstNameProperty = RegisterProperty<string>(p => p.FirstName);
        [Required]
        [LocalizedStringLength(100, 2)]
        [Display(Name = "Ime")]
        public string FirstName
        {
            get => GetProperty(FirstNameProperty);
            set => SetProperty(FirstNameProperty, value);
        }

        public static readonly PropertyInfo<string> LastNameProperty = RegisterProperty<string>(p => p.LastName);
        [Required]
        [LocalizedStringLength(100, 2)]
        [Display(Name = "Priimek")]
        public string LastName
        {
            get => GetProperty(LastNameProperty);
            set => SetProperty(LastNameProperty, value);
        }

        public static readonly PropertyInfo<int> BirthYearProperty = RegisterProperty<int>(p => p.BirthYear);
        [Display(Name = "Letnica rojstva")]
        public int BirthYear
        {
            get => GetProperty(BirthYearProperty);
            set => SetProperty(BirthYearProperty, value);
        }

        #endregion

        #region Validation rules

        public async Task CheckRulesAsync() => await BusinessRules.CheckRulesAsync();

        #endregion

        #region Client-side methods

        #endregion

        #region Server-side methods

        #endregion
    }
}

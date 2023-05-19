using Core.Library.Base;
using Csla;
using Csla.Rules;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Entity;

[Serializable]
public class TEEntityBO : CslaBusinessBase<TEEntityBO, TEEntity>
{
    #region Properties

    public static readonly PropertyInfo<string?> Attribute1Property = RegisterProperty<string?>(p => p.Attribute1);
    public string? Attribute1
    {
        get => GetProperty(Attribute1Property);
        set => SetProperty(Attribute1Property, value);
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

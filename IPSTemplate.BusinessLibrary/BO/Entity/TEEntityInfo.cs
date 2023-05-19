using Core.Library.Base;
using Csla;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Entity;

[Serializable]
public class TEEntityInfo : CslaReadOnlyBase<TEEntityInfo, TEEntity>
{
    #region Properties

    public static readonly PropertyInfo<string?> Attribute1Property = RegisterProperty<string?>(p => p.Attribute1);
    public string? Attribute1
    {
        get => GetProperty(Attribute1Property);
        set => LoadProperty(Attribute1Property, value);
    }

    #endregion

    #region Client-side methods

    #endregion

    #region Server-side methods

    #endregion
}

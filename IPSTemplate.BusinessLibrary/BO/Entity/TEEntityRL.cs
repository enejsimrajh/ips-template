using Core.Library.Base;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Entity;

[Serializable]
public class TEEntityRL : CslaReadOnlyListBase<TEEntityRL, TEEntityInfo, TEEntity>
{
    public TEEntityRL()
    { }
}

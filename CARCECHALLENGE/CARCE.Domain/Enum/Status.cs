using System.ComponentModel;

namespace CARCE.Domain.Enum
{
    public enum Status
    {
        [Description("Active")]
        Active = 1,
        [Description("Inactive")]
        Inactive = 0
    }
}

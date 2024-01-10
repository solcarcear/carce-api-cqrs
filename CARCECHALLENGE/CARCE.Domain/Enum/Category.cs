using System.ComponentModel;

namespace CARCE.Domain.Product
{
    public enum Category
    {
        [Description("S")]
        Premium = 1,

        [Description("A")]
        SemiPremium = 2,

        [Description("B")]
        HighQuality = 3,

        [Description("C")]
        Special = 4,

        [Description("D")]
        Normal = 5
    }
}

using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// GSEPropertyType
    /// </summary>
    public enum GsePropertyType
    {
        /// <summary>
        /// Attached
        /// </summary>
        Attached = 0,
        /// <summary>
        /// Condominium
        /// </summary>
        Condominium = 1,
        /// <summary>
        /// Co-Operative
        /// </summary>
        [Description("Co-Operative")]
        Cooperative = 2,
        /// <summary>
        /// Detached
        /// </summary>
        Detached = 3,
        /// <summary>
        /// High Rise Condominium
        /// </summary>
        [Description("High Rise Condominium")]
        HighRiseCondominium = 4,
        /// <summary>
        /// Manufactured Housing
        /// </summary>
        [Description("Manufactured Housing")]
        ManufacturedHousing = 5,
        /// <summary>
        /// PUD
        /// </summary>
        PUD = 6,
        /// <summary>
        /// Detached Condo
        /// </summary>
        [Description("Detached Condo")]
        DetachedCondo = 7,
        /// <summary>
        /// Mfd Home/Condo/PUD/Co-Op
        /// </summary>
        [Description("Mfd Home/Condo/PUD/Co-Op")]
        ManufacturedHomeCondoPUDCoOp = 8,
        /// <summary>
        /// MH HomeChoice
        /// </summary>
        [EnumMember(Value = "MH HomeChoice")]
        MHHomeChoice = 9,
        /// <summary>
        /// MH Select
        /// </summary>
        [Description("MH Select")]
        MHSelect = 10,
        /// <summary>
        /// MH Advantage
        /// </summary>
        [Description("MH Advantage")]
        MHAdvantage = 11
    }
}
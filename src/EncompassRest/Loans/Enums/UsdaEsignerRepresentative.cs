using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// UsdaEsignerRepresentative
    /// </summary>
    public enum UsdaEsignerRepresentative
    {
        /// <summary>
        /// Roles
        /// </summary>
        Roles = 0,
        /// <summary>
        /// Custom File Contacts
        /// </summary>
        [EnumMember(Value = "Custom File Contacts")]
        CustomFileContacts = 1
    }
}
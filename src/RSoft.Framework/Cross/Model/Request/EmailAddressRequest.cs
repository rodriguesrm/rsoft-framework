namespace RSoft.Framework.Cross.Model.Request
{

    /// <summary>
    /// E-mail address request model
    /// </summary>
    public class EmailAddressRequest
    {

        /// <summary>
        /// Sender/Recipient e-mail address
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Sender/Recipient name
        /// </summary>
        public string Name { get; set; }

    }
}

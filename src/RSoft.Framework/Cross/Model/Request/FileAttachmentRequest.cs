namespace RSoft.Framework.Cross.Model.Request
{

    /// <summary>
    /// File attachment request model
    /// </summary>
    public class FileAttachmentRequest
    {

        /// <summary>
        /// File name
        /// </summary>
        public string Filename { get; set; }
        
        /// <summary>
        /// File type (mime-type)
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// File content (base64 expression)
        /// </summary>
        public string Content { get; set; }

    }
}

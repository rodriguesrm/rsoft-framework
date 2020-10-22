﻿using System.Collections.Generic;

namespace RSoft.Framework.Options
{

    /// <summary>
    /// Culture options parameters object
    /// </summary>
    public class CultureOptions
    {
        /// <summary>
        /// List of supported languages cultures
        /// </summary>
        public IEnumerable<string> SupportedLanguage { get; set; }

        /// <summary>
        /// Default language culture
        /// </summary>
        public string DefaultLanguage { get; set; }

    }

}

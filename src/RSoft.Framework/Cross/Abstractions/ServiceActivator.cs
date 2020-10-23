using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using System;

namespace RSoft.Framework.Cross.Abstractions
{

    /// <summary>
    /// Add static service resolver to use when dependencies injection is not available
    /// </summary>
    public class ServiceActivator
    {
        
        #region Local objects/variables

        private static IServiceProvider _serviceProvider = null;

        #endregion

        #region Internal methods

        /// <summary>
        /// Get text int string-localizer
        /// </summary>
        /// <typeparam name="T">The System.Type to provide strings for</typeparam>
        /// <param name="textToLocalizer"></param>
        /// <param name="defaultText"></param>
        /// <param name="serviceProvider">Service DI provider</param>
        /// <returns>String founded or default text is not found or provider is not avaliable</returns>
        internal static string GetStringInLocalizer<T>(string textToLocalizer, string defaultText, IServiceProvider serviceProvider = null)
        {

            IServiceProvider provider = serviceProvider ?? _serviceProvider;

            if (provider == null)
                return defaultText;

            IStringLocalizer<T> localizer = GetScope().ServiceProvider.GetService<IStringLocalizer<T>>();
            LocalizedString localizeResult = localizer[textToLocalizer];

            return localizeResult.ResourceNotFound ? defaultText : localizeResult.Value;

        }

        #endregion

        #region Public methods

        /// <summary>
        /// Configure ServiceActivator with full serviceProvider
        /// </summary>
        /// <param name="serviceProvider">Service DI provider</param>
        public static void Configure(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Create a scope where use this ServiceActivator
        /// </summary>
        /// <param name="serviceProvider">Service DI provider</param>
        public static IServiceScope GetScope(IServiceProvider serviceProvider = null)
        {
            IServiceProvider provider = serviceProvider ?? _serviceProvider;
            return provider?
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope();
        }

        #endregion

    }

}

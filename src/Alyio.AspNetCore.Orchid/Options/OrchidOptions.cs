﻿namespace Alyio.AspNetCore.Orchid
{
    /// <summary>
    /// Provides programmatic configuration for the Orchid framework.
    /// </summary>
    public class OrchidOptions
    {
        /// <summary>
        /// Gets or sets the base path of Orchid server. Default is api-docs.
        /// </summary>
        /// <example>http://localhost:8000/{api-docs}</example>
        public string BasePath { get; set; } = "api-docs";

        /// <summary>
        /// Gets or sets a general description of the api in you app.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the about file path. (Styling with Markdown is supported).
        /// </summary>
        /// <remarks>Default is about.md</remarks>
        public string About { get; set; } = "about.md";

        /// <summary>
        /// Gets or sets the regular expression pattern to match the obsolete api route action.
        /// </summary>
        /// <remarks>
        /// If the api action method was marked with [ObsolteAttribute], it will be treated as an obsolete route.
        /// </remarks>
        public string ObsoleteRoutePathPattern { get; set; }
    }
}

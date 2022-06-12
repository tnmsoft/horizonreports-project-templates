using HorizonReports;
using HorizonReports.Plugins;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Plugin_Templates
{
    /// <summary>
    /// A plugin that provides a list of values for the FieldName field when the user
    /// clicks the Values button
    /// </summary>
    [ValuesMethodPlugin("{B9D19D1B-6930-4905-8D41-A1C5ADC948C8}",
        "FieldNameValuesMethodPlugin",
        PluginSource.Custom,
        "FieldGuid",
        Version = "1.0.0.0",
        ExecutionPriority = 5)]
    public class FieldNameValuesMethodPlugin : IValuesMethodPlugin
    {
        /// <summary>
        /// A reference to the Application object. It must be marked as [Import]
        /// so it's automatically set to the correct object.
        /// </summary>
        [Import]
        public IHorizonReportsAppService Application { get; set; }

        /// <summary>
        /// Returns the list of values for the field.
        /// </summary>
        /// <returns>
        /// The list of values for the field.
        /// </returns>
        public IList GetValues()
        {
            // TODO: populate the list with the necessary values.
            List<string> values = new List<string>();
            return values;
        }
    }
}

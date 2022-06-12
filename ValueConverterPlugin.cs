using HorizonReports;
using HorizonReports.DataDictionary;
using HorizonReports.DataEngine;
using HorizonReports.Plugins;
using HorizonReports.ReportEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data;


namespace Plugin_Templates
{
    /// <summary>
    /// A value converter plugin
    /// </summary>
    /// <remarks>
    [ValueConverterPlugin("{B8857ADC-B770-4489-847B-2F36B20A6E1D}",
        "TemplateValueConverterPlugin",
        PluginSource.Custom,
        // TODO Change the first "typeof(String)" to the data type of the field.
        typeof(String),
        // TODO Change the second "typeof(String)" to the data type of the converted value.
        typeof(String))]
    public class TemplateValueConverterPlugin : IValueConverterPlugin
    {
        /// <summary>
        /// A reference to the Application object. It must be marked as [Import]
        /// so it's automatically set to the correct object.
        /// </summary>
        [Import]
        public IHorizonReportsAppService Application { get; set; }

        /// <summary>
        /// A reference to the field this is a converter for.
        /// </summary>
        public Field Field { get; set; }

        /// <summary>
        /// A reference to the DataEngine which could be used to retrieve data needed by the converter.
        /// </summary>
        public IDataEngine DataEngine { get; set; }

        /// <summary>
        /// The name of the data source currently connected to. This is useful for cases
        /// where the converter needs to call back into the data engine to retrieve data.
        /// </summary>
        public string DatasourceName { get; set; }

        /// <summary>
        /// A reference to the report being run.
        /// </summary>
        public IReport Report { get; set; }

        /// <summary>
        /// A list of aliases for the fields that have been retrieved from the database. If it was necessary to rename a field
        /// this list will contain the corresponding column name for that field in the passed-in DataRow.
        /// </summary>
        public Dictionary<Field, string> AliasList { get; set; }

        /// <summary>
        /// Converts the specified value from the database to the value to be displayed.
        /// </summary>
        /// <param name="value">
        /// The value to convert.
        /// </param>
        /// <param name="row">
        /// The row in the result set the value is from. This is useful if the values of other columns
        /// are used by the converter.
        /// </param>
        /// <returns>
        /// The converted value.
        /// </returns>
        public object Convert(object value, DataRow row)
        {
            // TODO: do whatever is necessary in this method and return an appropriate value.
            string result = value.ToString();
            return result;
        }

        /// <summary>
        /// Converts the specified display value to the value for a WHERE clause.
        /// </summary>
        /// <param name="value">
        /// The value to convert back.
        /// </param>
        /// <returns>
        /// The converted value.
        /// </returns>
        public object ConvertBack(object value)
        {
            // TODO: do whatever is necessary in this method and return an appropriate value.
            string result = value.ToString();
            return result;
        }

        /// <summary>
        /// Reset the converter.
        /// </summary>
        public void Reset()
        {
            // TODO: do whatever is necessary in this method.
        }

        /// <summary>
        /// True if this converter maintains a list of values.
        /// </summary>
        /// <returns>
        /// True if this converter contains its own list of values.
        /// </returns>
        public bool IsListType()
        {
            // TODO: return true if this value converter maintains its own list of values.
            return false;
        }

        /// <summary>
        /// Returns a list of values (only called if IsListType returns true).
        /// </summary>
        /// <returns>
        /// A list of possible values for this converter.
        /// </returns>
        public IList GetConvertedValuesList()
        {
            // TODO: populate the list with the necessary values if this value converter maintains its own list of values.
            List<string> values = new List<string>();
            return values;
        }
    }
}

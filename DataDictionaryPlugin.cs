using HorizonReports;
using HorizonReports.DataDictionary;
using HorizonReports.Plugins;
using System.ComponentModel.Composition;

namespace Plugin_Templates
{
    /// <summary>
    /// A data dictionary plugin
    /// </summary>
    [DataDictionaryPlugin("{D2C0BE3C-D572-46E7-94A5-036C762A7CC0}",
        "DDPluginName",
        PluginSource.Custom,
        Version = "1.0.0.0",
        ExecutionPriority = 5)]
    public class DDPluginName : IDataDictionaryPlugin
    {
        /// <summary>
        /// A reference to the Application object. It must be marked as [Import]
        /// so it's automatically set to the correct object.
        /// </summary>
        [Import]
        public IHorizonReportsAppService Application { get; set; }

        /// <summary>
        /// A reference to the DataDictionary object.
        /// </summary>
        public IDataDictionary DataDictionary { get; set; }

        /// <summary>
        /// Called after the data dictionary collections are loaded so we can
        /// customize the data dictionary for a specific datasource or user.
        /// </summary>
        public void AfterLoaded()
        {
            // TODO: do whatever is necessary in this method.
        }

        /// <summary>
        /// Called before the data dictionary collections are loaded so we can do anything
        /// necessary.
        /// </summary>
        public void BeforeLoaded()
        {
            // TODO: do whatever is necessary in this method.
        }

        /// <summary>
        /// Get the version number for the specified field.
        /// </summary>
        public string GetVersion(Field item)
        {
            // TODO: return the appropriate version number for the item.
            return "";
        }

        /// <summary>
        /// Get the version number for the specified table.
        /// </summary>
        public string GetVersion(Table item)
        {
            // TODO: return the appropriate version number for the item.
            return "";
        }

        /// <summary>
        /// Get the version number for the specified join.
        /// </summary>
        public string GetVersion(Join item)
        {
            // TODO: return the appropriate version number for the item.
            return "";
        }
    }
}

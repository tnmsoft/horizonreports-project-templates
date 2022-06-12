using HorizonReports;
using HorizonReports.ConnectionManagement;
using HorizonReports.Plugins;
using System.ComponentModel.Composition;

namespace Plugin_Templates
{
    /// <summary>
    /// A data engine plugin
    /// </summary>
    [DataEnginePlugin("{EF806A51-1F6A-4C42-A7B1-5B3E5EC145B0}",
        "DEPluginName",
        PluginSource.Custom,
        Version = "1.0.0.0",
        ExecutionPriority = 5)]
    public class DEPluginName : IDataEnginePlugin
    {
        /// <summary>
        /// A reference to the Application object. It must be marked as [Import]
        /// so it's automatically set to the correct object.
        /// </summary>
        [Import]
        public IHorizonReportsAppService Application { get; set; }

        /// <summary>
        /// Fills the specified collection with data sources users can query on.
        /// </summary>
        /// <param name="dataSources">
        /// The data source collection.
        /// </param>
        /// <returns>
        /// True if we succeeded.
        /// </returns>
        public bool GetDataSources(IDataSourceCollection dataSources)
        {
            // TODO: do whatever is necessary in this method.
            return true;
        }

        /// <summary>
        /// Returns the name of the current data source used for reports.
        /// </summary>
        /// <param name="dataSources">
        /// The data source collection.
        /// </param>
        /// <returns>
        /// null to use the data source selected by the user in the login page or the
        /// name of the data source to use.
        /// </returns>
        public string GetCurrentDataSource(IDataSourceCollection dataSources)
        {
            // TODO: return null to use the data source selected by the user in the login page
            //          or the name of the data source to use instead.
            return null;
        }
    }
}

using HorizonReports;
using HorizonReports.ConnectionManagement;
using HorizonReports.DataDictionary;
using HorizonReports.Plugins;
using HorizonReports.ReportEngine;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data;

namespace Plugin_Templates
{
    /// <summary>
    /// A virtual table plugin for TableName
    /// </summary>
    [VirtualTablePlugin("{3CF8EC99-A8D2-4FF0-A5AC-16EB0313E285}",
        "TableNameVirtualTablePlugin",
        PluginSource.Custom,
        "TableName",
        Version = "1.0.0.0",
        ExecutionPriority = 5)]
    public class TableNameVirtualTablePlugin : IVirtualTablePlugin
    {
        /// <summary>
        /// A reference to the Application object. It must be marked as [Import]
        /// so it's automatically set to the correct object.
        /// </summary>
        [Import]
        public IHorizonReportsAppService Application { get; set; }

        /// <summary>
        /// Returns a list of parameters the Select method needs.
        /// </summary>
        /// <param name="table">
        /// A reference to the table the plugin is for.
        /// </param>
        /// <returns>
        /// A list of IParameters.
        /// </returns>
        public List<Parameter> GetParameters(Table table)
        {
            // TODO: populate the list with whatever parameters you want the user to be prompted for.
            List<Parameter> parameters = new List<Parameter>();
            return parameters;
        }

        /// <summary>
        /// Retrieves the data for the virtual table and returns a DataTable.
        /// </summary>
        /// <param name="connection">
        /// The IConnection object that performs the query.
        /// </param>
        /// <param name="datasource">
        /// The name of the datasource connected to.
        /// </param>
        /// <param name="select">
        /// The SQL statement used by the report.
        /// </param>
        /// <param name="tablename">
        /// The name of the table being created.
        /// </param>
        /// <param name="report">
        /// The report the result is for.
        /// </param>
        /// <param name="table">
        /// A reference to the table the plugin is for.
        /// </param>
        /// <returns>
        /// A DataTable containing the desired results.
        /// </returns>
        public DataTable Select(IConnection connection, string datasource,
            string select, string tablename, IReport report, Table table)
        {
            // TODO: do whatever is necessary in this method and return an appropriate value.
            DataTable result = new DataTable();
            return result;
        }
    }
}

using HorizonReports;
using HorizonReports.DataEngine;
using HorizonReports.Plugins;
using HorizonReports.ReportEngine;
using System.ComponentModel.Composition;
using System.Data;
using System.IO;

namespace Plugin_Templates
{
    /// <summary>
    /// A report engine plugin
    /// </summary>
    [ReportEnginePlugin("{A2F06103-C9A8-42F8-A6CD-9D9511184FE6}",
        "REPluginName",
        PluginSource.Custom,
        Version = "1.0.0.0",
        ExecutionPriority = 5)]
    public class REPluginName : IReportEnginePlugin
    {
        /// <summary>
        /// A reference to the Application object. It must be marked as [Import]
        /// so it's automatically set to the correct object.
        /// </summary>
        [Import]
        public IHorizonReportsAppService Application { get; set; }

        /// <summary>
        /// Returns true if the user can access the specified report.
        /// </summary>
        /// <param name="report">
        /// The report to check.
        /// </param>
        /// <returns>
        /// True if the user can access the specified report.
        /// </returns>
        public bool CanUserAccessReport(IReportBase report)
        {
            // TODO: do whatever is necessary in this method and return an appropriate value.
            return true;
        }

        /// <summary>
        /// Executes just before the layout for the specified report is created.
        /// </summary>
        /// <param name="report">
        /// The report being run.
        /// </param>
        /// <returns>
        /// True if the layout process can continue, false if not.
        /// </returns>
        public bool BeforeCreateLayout(IReport report)
        {
            // TODO: do whatever is necessary in this method and return an appropriate value.
            return true;
        }

        /// <summary>
        /// Executes just after the layout for the specified report is created.
        /// </summary>
        /// <param name="report">
        /// The report being run.
        /// </param>
        /// <returns>
        /// True if the layout process can continue, false if not.
        /// </returns>
        public bool AfterCreateLayout(IReport report)
        {
            // TODO: do whatever is necessary in this method and return an appropriate value.
            return true;
        }

        /// <summary>
        /// Executes just before the data for the specified report is retrieved.
        /// </summary>
        /// <param name="report">
        /// The report being run.
        /// </param>
        /// <param name="dataEngine">
        /// The data engine being used to retrieve the data.
        /// </param>
        /// <returns>
        /// True if the report run can continue, false if not.
        /// </returns>
        public bool BeforeDataRetrieved(IReport report, IDataEngine dataEngine)
        {
            // TODO: do whatever is necessary in this method and return an appropriate value.
            return true;
        }

        /// <summary>
        /// Executes just after the data for the specified report is retrieved.
        /// </summary>
        /// <param name="report">
        /// The report being run.
        /// </param>
        /// <param name="dataEngine">
        /// The data engine being used to retrieve the data.
        /// </param>
        /// <returns>
        /// True if the report run can continue, false if not.
        /// </returns>
        /// <remarks>
        /// The ResultSet property of the report contains the DataTable used for the report.
        /// </remarks>
        public bool AfterDataRetrieved(IReport report, IDataEngine dataEngine)
        {
            // TODO: do whatever is necessary in this method and return an appropriate value.
            return true;
        }

        /// <summary>
        /// Executes after the SQL statement has been generated and is about to be sent to the database
        /// engine.
        /// </summary>
        /// <param name="report">
        /// The report being run.
        /// </param>
        /// <param name="sqlStatement">
        /// The SQL statement being used.
        /// </param>
        /// <param name="parameters">
        /// An array of parameters used by the SQL statement.
        /// </param>
        /// <param name="tablename">
        /// The name of the data table being created.
        /// </param>
        /// <param name="conn">
        /// The connection object being used.
        /// </param>
        /// <param name="cmd">
        /// The command object being used.
        /// </param>
        /// <param name="datasourcename">
        /// The name of the current data source being queried
        /// </param>
        /// <returns>
        /// The SQL statement to be used or null if the SQL statement should not be sent to the database.
        /// </returns>
        public string AfterSQLStatementGenerated(IReport report, string sqlStatement, object[] parameters, string tablename,
            IDbConnection conn, IDbCommand cmd, string datasourcename)
        {
            // TODO: do whatever is necessary in this method and return an appropriate value.
            return sqlStatement;
        }

        /// <summary>
        /// Executes just before the specified report is exported to a stream.
        /// </summary>
        /// <param name="report">
        /// The report being exported.
        /// </param>
        /// <param name="stream">
        /// The stream.
        /// </param>
        /// <returns>
        /// True if the report should be exported, false if not.
        /// </returns>
        public bool BeforeExportReport(IReport report, Stream stream)
        {
            // TODO: do whatever is necessary in this method and return an appropriate value.
            return true;
        }

        /// <summary>
        /// Executes just before the specified report is exported to a file.
        /// </summary>
        /// <param name="report">
        /// The report being exported.
        /// </param>
        /// <param name="fileName">
        /// The name of the file.
        /// </param>
        /// <returns>
        /// True if the report should be exported, false if not.
        /// </returns>
        public bool BeforeExportReport(IReport report, string fileName)
        {
            // TODO: do whatever is necessary in this method and return an appropriate value.
            return true;
        }

        /// <summary>
        /// Executes just before the specified report is saved.
        /// </summary>
        /// <param name="report">
        /// The report being saved.
        /// </param>
        public void BeforeReportSaved(IReportBase report)
        {
            // TODO: do whatever is necessary in this method.
        }

        /// <summary>
        /// Executes just after the specified report is saved.
        /// </summary>
        /// <param name="report">
        /// The report being saved.
        /// </param>
        public void AfterReportSaved(IReportBase report)
        {
            // TODO: do whatever is necessary in this method.
        }

        /// <summary>
        /// Executes just before the specified report is copied.
        /// </summary>
        /// <param name="report">
        /// The report being copied.
        /// </param>
        /// <param name="name">
        /// The name to assign to the copy.
        /// </param>
        /// <returns>
        /// True if the report should be copied, false if not.
        /// </returns>
        public bool BeforeReportCopied(IReportBase report, string name)
        {
            // TODO: do whatever is necessary in this method and return an appropriate value.
            return true;
        }

        /// <summary>
        /// Executes just after the specified report is copied.
        /// </summary>
        /// <param name="report">
        /// The report being copied.
        /// </param>
        /// <param name="copy">
        /// The copied report.
        /// </param>
        public void AfterReportCopied(IReportBase report, IReportBase copy)
        {
            // TODO: do whatever is necessary in this method.
        }

        /// <summary>
        /// Executes just before the specified report is deleted.
        /// </summary>
        /// <param name="report">
        /// The report being deleted.
        /// </param>
        /// <returns>
        /// True if the report should be deleted, false if not.
        /// </returns>
        public bool BeforeReportDeleted(IReportBase report)
        {
            // TODO: do whatever is necessary in this method and return an appropriate value.
            return true;
        }

        /// <summary>
        /// Executes just after the specified report is deleted.
        /// </summary>
        /// <param name="report">
        /// The report being deleted.
        /// </param>
        /// <param name="reportWasDeleted">
        /// True if the report was deleted.
        /// </param>
        public void AfterReportDeleted(IReportBase report, bool reportWasDeleted)
        {
            // TODO: do whatever is necessary in this method.
        }

        /// <summary>
        /// Executes after the connnection to the database has been opened but before the SQL statement
        /// is sent to the database.
        /// </summary>
        /// <param name="conn">
        /// The connection object being used; the connection has been opened.
        /// </param>
        public void BeforeSQLStatementSentToDatabase(IDbConnection conn)
        {
            // TODO: do whatever is necessary in this method.
        }

        /// <summary>
        /// Executes when a report is created.
        /// </summary>
        /// <param name="report">
        /// The new report.
        /// </param>
        public void ReportCreated(IReportBase report)
        {
            // TODO: do whatever is necessary in this method.
        }
    }
}

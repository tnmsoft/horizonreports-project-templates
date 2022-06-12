
using HorizonReports;
using System.ComponentModel.Composition;

namespace Plugin_Templates
{
    public static class FunctionsPluginName
    {
        /// <summary>
        /// A reference to the Application object.
        /// </summary>
        [Import]
        public static IHorizonReportsAppService Application { get; set; }

        // TODO: add static functions as necessary.
    }
}

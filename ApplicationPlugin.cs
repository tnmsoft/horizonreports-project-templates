using HorizonReports;
using HorizonReports.Plugins;
using HorizonReports.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Plugin_Templates
{
    /// <summary>
    /// An application plugin
    /// </summary>
    [ApplicationPlugin("{17EEF96E-1B16-4526-81D5-52343EC1C510}",
        "AppPluginName",
        PluginSource.Custom,
        Version = "1.0.0.0",
        ExecutionPriority = 5)]
    public class AppPluginName : IApplicationPlugin
    {
        /// <summary>
        /// A reference to the Application object. It must be marked as [Import]
        /// so it's automatically set to the correct object.
        /// </summary>
        [Import]
        public IHorizonReportsAppService Application { get; set; }

        /// <summary>
        /// Fired after the application object setup tasks are done.
        /// </summary>
        /// <returns>
        /// True if the application can start, false if not.
        /// </returns>
        public bool AfterSetup()
        {
            // TODO: do whatever is necessary in this method.
            return true;
        }

        /// <summary>
        /// Fired on shut down.
        /// </summary>
        public void OnShutdown()
        {
            // TODO: do whatever is necessary in this method.
        }

        /// <summary>
        /// Called before the user has logged in.
        /// </summary>
        /// <param name="userName">
        /// The name of the user logging in.
        /// </param>
        /// <returns>
        /// True if the application can continue.
        /// </returns>
        public bool BeforeLogin(string userName)
        {
            // TODO: do whatever is necessary in this method.
            return true;
        }

        /// <summary>
        /// Called after the user has logged in.
        /// </summary>
        /// <param name="user">
        /// A reference to the logged-in user.
        /// </param>
        /// <returns>
        /// True if the application can continue.
        /// </returns>
        public bool AfterLogin(IUser user)
        {
            // TODO: do whatever is necessary in this method.
            return true;
        }

        /// <summary>
        /// Called when a support ticket should be created because of an exception.
        /// </summary>
        /// <param name="exception">
        /// The exception that occurred.
        /// </param>
        /// <param name="attachments">
        /// A list of attachments for the ticket.
        /// </param>
        /// <param name="message">
        /// The message for the ticket.
        /// </param>
        /// <returns>
        /// Anything the plugin code wants to return to the caller.
        /// </returns>
        public object CreateSupportTicket(Exception exception, List<string> attachments, string message)
        {
            // TODO: do whatever is necessary in this method.
            return null;
        }
    }
}

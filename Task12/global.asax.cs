using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Global.asaxEvents
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["users"] = 0;


        }
        /// <summary>
        /// Method for Session_Start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Session_Start(object sender, EventArgs e)
        {
            
            Application.Lock();
            Application["users"] = (int)Application["users"] + 1;
            Application.UnLock();
            Response.Write("Session_Start" + "<br/>" + Application["users"]);
        }
        /// <summary>
        /// Session_End method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Session_End(object sender, EventArgs e)
        {
            
            Application.Lock();
            Application["users"] = (int)Application["users"] - 1;
            Application.UnLock();
            Response.Write("Session_End" + "<br/>");

        }
        /// <summary>
        /// Application_End method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Application_End(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Application_Error method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Application_Error(object sender, EventArgs e)
        {
            string strError;
            strError = Server.GetLastError().ToString();
            if (Context != null)
            {
                Context.ClearError();
                Response.Write("Application_Error" + "<br/>");
                Response.Write("<b>Error Msg:</b>" + strError + "<br/>" + "<b>End Error Msg<b/>");
            }

        }
    }
}

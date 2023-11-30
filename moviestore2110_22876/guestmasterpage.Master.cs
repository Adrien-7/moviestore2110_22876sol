using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace moviestore2110_22876
{
    public partial class guestmasterpage : System.Web.UI.MasterPage
    {
        private string _conString = WebConfigurationManager.ConnectionStrings["MoviesCS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            //verify if session username is not null
            if (Session["userun"] != null )
            {
                pnllog.Style.Add("visibility", "hidden");
                Page.Controls.Remove(pnllog);
                lgregis.CssClass = "nav navbar-nav navbar-right";
                lbllgged.CssClass = "btn btn-outline-success text-white";
                //add the session name
                lbllgged.Text = "Welcome " + Session["userun"] ;
                btnlgout.Visible = true;
                pnlprofile.Visible = true;
                //Retrieve the User Id Session
                //int user_id = Convert.ToInt32( );

                //hyuser.Attributes["href"]=ResolveUrl("~/tutorials/week5/updateprofile?id="
                // + user_id + "");

            }
        
        }

        protected void btnlgout_Click(object sender, EventArgs e)
        {
            lgout();
        }
        void lgout()
        {
            if (Session["userun"] != null || Session["adminuname"] != null)
            {
                //Remove all session
                Session.RemoveAll();
                //Destroy all Session objects
                Session.Abandon();
                //Redirect to homepage or login page
                Response.Redirect("~/home.aspx");
            }
        }
    }
}
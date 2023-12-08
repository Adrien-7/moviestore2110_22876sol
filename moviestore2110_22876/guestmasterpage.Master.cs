using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
            if (Session["userun"] != null)
            {
                pnllog.Style.Add("visibility", "hidden");
                Page.Controls.Remove(pnllog);
                lgregis.CssClass = "nav navbar-nav navbar-right";
                lbllgged.CssClass = "btn btn-outline-success text-white";
                //add the session name
                lbllgged.Text = "Welcome " + Session["userun"];
                btnlgout.Visible = true;
                pnlprofile.Visible = true;
                //Retrieve the User Id Session
                //int user_id = Convert.ToInt32( );

                //hyuser.Attributes["href"]=ResolveUrl("~/tutorials/week5/updateprofile?id="
                // + user_id + "");

            }
           
            //Disable/Enable some menu items
            if (Session["adminuname"] != null)
            {
                hyregister.Visible = false;
                lgregis.CssClass = "nav navbar-nav navbar-right";
                lbllgged.CssClass = "btn btn-outline-success text-white";
                lbllgged.Text = "Welcome " + Session["adminuname"];
                btnlgout.Visible = true;
                pnlmanage.Visible = true;
                pnlmanagemov.Visible = true;
                pnlprofile.Style.Add("visibility", "hidden");
                Page.Controls.Remove(pnlprofile);
                pnllog.Style.Add("visibility", "hidden");
                Page.Controls.Remove(pnllog);
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

        protected void btnLogin_Click(object sender, EventArgs e)
        {
        //    //get the value of username and password fields and state of checkbox from
        //    //admin login form
        //    string username = userLogin. ;
        //    string password = ;
        //    bool chk = ;
        //    SqlConnection con = new SqlConnection(_conString);
        //    // Create Command
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandType = CommandType.Text;
        //    //searching for a record containing matching username & password with
        //    //an active status
        //    cmd.CommandText = " ";
        //    //create three parameterized queries for the above select statement
        //    //use above variables
        //    //Create DataReader
        //    SqlDataReader dr;
        //    con.Open();
        //    dr = cmd.ExecuteReader();
        //    // check if the DataReader contains a record
        //    if ( )
        //    {
        //        if (dr.Read())
        //        {
        //            //create a memory cookie to store adminusername and pwd
        //        }
        //        if (chk)
        //        {
        //            //if checkbox is checked, make cookies persistent

        //        }
        //        else
        //        {
        //            //delete the cookies if checkbox is unchecked
        //            //delete content of password field
        //        }
        //        //create and save adminuname in a session variable
        //        //create and save adminid in a session variable
        //        //redirect to the dashboard page

        //        con.Close();
        //    }
        //    else
        //    {
        //        //delete content of password field
        //        lblmsg.Style.Add("margin-left", "10%");
        //        lblmsg.ForeColor = System.Drawing.Color.Red;
        //        username = "";
        //        password = "";
        //        lblmsg.Text = "You are not registered or your account has been suspended!";
        //    }
        }
    }
}
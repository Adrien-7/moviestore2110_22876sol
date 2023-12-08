using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

using System.Data;
using System.Data.SqlClient;

namespace moviestore2110_22876.tutorials.week11
{
    public partial class download : System.Web.UI.Page
    {

        private string _conString =
WebConfigurationManager.ConnectionStrings["MoviesCS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(_conString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            //Modify the SQL statement to show only files that the current
            //user has uploaded – for user
            //or
            // Modify the SQL statement to show files that all users have
            //uploaded – for subadmin

            if (Session[] == user)
            {
                cmd.CommandText = "SELECT * FROM tbldocs td inner join tbluser tu on td.user_id=tu.user_id where= ";
            }
            else if (Session == admin) 
            {
              cmd.CommandText = "SELECT * FROM tbldocs td inner join tbluser tu on td.user_id=tu.user_id";
            }


            SqlDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
            rptdoc.DataSource = reader;
            rptdoc.DataBind();
            con.Close();
        }
    }
}
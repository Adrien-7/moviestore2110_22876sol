using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;


namespace moviestore2110_22876.tutorials.week6
{
    public partial class bindchk : System.Web.UI.Page
    {
        private string _conString =
WebConfigurationManager.ConnectionStrings["MoviesCS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            getCategorylist();
        }
        private void getCategorylist()
        {
            // Create Connection
            SqlConnection con = new SqlConnection(_conString);
            // Create Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tblCategory";
            con.Open();
            chkCategory.DataSource = cmd.ExecuteReader();
            chkCategory.DataBind();
            con.Close();
        }
    }
}
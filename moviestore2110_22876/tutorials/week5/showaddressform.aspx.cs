using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace moviestore2110_22876.tutorials.week5
{
    public partial class showaddressform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ltlResults.Text = ucBilling.Street + " " + ucBilling.City;
        }
    }
}
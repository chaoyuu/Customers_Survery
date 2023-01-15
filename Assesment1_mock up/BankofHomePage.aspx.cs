using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assesment1_mock_up
{
    public partial class BankofHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("SurveyQuestion.aspx");
        }

        protected void BtnStaffSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffSearchPage.aspx");
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }
    }
}
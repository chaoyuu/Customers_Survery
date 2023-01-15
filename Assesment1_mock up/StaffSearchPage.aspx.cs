using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace Assesment1_mock_up
{
    public partial class StaffSearchPage : System.Web.UI.Page
    {
        private static String connectionStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Calendar2.Visible = false;
            }


        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {
            Calendar2.Visible = true;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBoxDate.Text = Calendar2.SelectedDate.ToString();
            Calendar2.Visible = false;

        }

      

        protected void btnSearch_Click(object sender, EventArgs e)
        {
          
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("BankofHomePage.aspx");
        }

        protected void btnRest_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            textLastName.Text = string.Empty;
            dropDownAg.Text = string.Empty;
            textboxState.Text = string.Empty;
            DpDGender.Text = string.Empty;
            textboxHS.Text = string.Empty;
            textboxHPC.Text = string.Empty;
            textboxEA.Text = string.Empty;
           // dpdBK.Text = string.Empty;
            textboxEA.Text = string.Empty;
            dpdBS.Text = string.Empty;
            dpdNS.Text = string.Empty;

            TextBoxDate.Text = string.Empty;
            textboxIPA.Text = string.Empty;




        }
    }
}
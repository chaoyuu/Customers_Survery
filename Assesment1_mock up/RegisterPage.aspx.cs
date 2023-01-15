using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assesment1_mock_up
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        public bool IsPostback { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostback)
            {
                Calendar1.Visible = false;
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Your Registration  is successful");
        }

        protected void btnCalendarClick_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;// calendar can visible
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBoxDB.Text = Calendar1.SelectedDate.ToString("dd/mm/yyyy");//select calendar that it will display to textbox
            Calendar1.Visible = false;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxLN_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnDashboad_Click(object sender, EventArgs e)
        {
            Response.Redirect("BankofHomePage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextPN.Text = string.Empty;
            TextBoxGN.Text = string.Empty;
            TextBoxLN.Text = string.Empty;
            TextBoxDB.Text = string.Empty;
           
        }
    }
}
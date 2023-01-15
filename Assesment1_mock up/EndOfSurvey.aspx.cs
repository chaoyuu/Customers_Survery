
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assesment1_mock_up.Model;
using System.Configuration;
using System.Data.SqlClient;

namespace Assesment1_mock_up
{

    public partial class EndOfSurvey : System.Web.UI.Page
    {
        private static String connectionStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<QuestionAnswers> questionAnswersInSession = (List<QuestionAnswers>)Session["Question_ANSWER_LIST"];
            //display the data
            foreach (QuestionAnswers answers in questionAnswersInSession)
            {
                TableRow row = new TableRow();
                TableCell questionIdcell = new TableCell();
                questionIdcell.Text = answers.Q_id.ToString();
                row.Cells.Add(questionIdcell);

                TableCell answerTextCell = new TableCell();
                answerTextCell.Text = answers.Answer_text;
                row.Cells.Add(answerTextCell);


                TableCell idcell = new TableCell();
                idcell.Text = answers.Id.ToString();
                row.Cells.Add(idcell);



                TableCell respondentIdcell = new TableCell();
                respondentIdcell.Text = answers.Respondent_id.ToString();
                row.Cells.Add(respondentIdcell);


                //optionid cell goes from there
                TableCell optionIdCell = new TableCell();
                if (answers.Option_id != null)
                {
                    optionIdCell.Text = answers.Option_id.ToString();

                }
                else
                {
                    optionIdCell.Text = "";
                }
                row.Cells.Add(optionIdCell);
                questionAnswerDisplayTable.Rows.Add(row);
            }


            //save the data
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                String query = "INSERT INTO Question_Answers(Q_id,Option_id,Answer_text) VALUES(@Questionid,@Optionid,@Answers_text)";
                connection.Open();
                foreach (QuestionAnswers answers in questionAnswersInSession)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Questionid", answers.Q_id);
                        if (answers.Option_id == null)
                        {
                            command.Parameters.AddWithValue("@Optionid", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Optionid", answers.Option_id);
                        }
                        if (answers.Answer_text == null)
                        {
                            command.Parameters.AddWithValue("@Answers_text", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Answers_text", answers.Answer_text);
                        }




                        int result = command.ExecuteNonQuery();

                        //check error
                        if (result < 0)
                        {
                            Console.WriteLine("Error,Please try again!");
                        }
                    }
                }
            }

        }

        protected void BtnHomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffSearchPage.aspx");
        }

        protected void btnhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("BankofHomePage.aspx");

        }
    }
}
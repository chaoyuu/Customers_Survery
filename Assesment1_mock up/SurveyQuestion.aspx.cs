using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using Assesment1_mock_up.Model;

namespace Assesment1_mock_up
{
    public partial class SurveyQuestion : System.Web.UI.Page
    {
        private static String connectionStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            Stack<int> follwupQuestions = null;
            int currentQuetionIdSession = 0;
            if (Session["FOLLOWUP_ID_LIST"] == null)
            {
                follwupQuestions = new Stack<int>();
                follwupQuestions.Push(1);
                Session["FOLLOWUP_ID_LIST"] = follwupQuestions;
                currentQuetionIdSession = 1;
            }
            else
            {
                follwupQuestions = (Stack<int>)Session["FOLLOWUP_ID_LIST"];
                currentQuetionIdSession = follwupQuestions.Peek();
            }




            Question question = getNextQuestion(currentQuetionIdSession);
            if (question != null)
            {
                QuestionText.Text = question.Question_text;
                if (question.Question_type.Equals("Text"))
                {

                    TextBox textBox = new TextBox();
                    textBox.ID = "AnswerTxtBox";
                    PlaceHolder1.Controls.Add(textBox);
                    Session["CURRENT_QUESTION_TYPE"] = textBox.ID;
                }
                else if (question.Question_type.Equals("Radio"))
                {
                    RadioButtonList radioBtnQuestion = new RadioButtonList();
                    radioBtnQuestion.ID = "RadioButtion";
                    Session["CURRENT_QUESTION_TYPE"] = radioBtnQuestion.ID;

                    List<QuestionOption> questionOptions = getQuestionOPtions(currentQuetionIdSession);
                    foreach (QuestionOption option in questionOptions)
                    {
                        ListItem newItem = new ListItem();
                        newItem.Value = option.Id.ToString();
                        newItem.Text = option.Option_text;
                        if (option.Next_q_id != null)
                        {
                            newItem.Attributes["nextQuestionId"] = option.Next_q_id.ToString();

                        }
                        radioBtnQuestion.Items.Add(newItem);
                    }
                    PlaceHolder1.Controls.Add(radioBtnQuestion);
                }
                else if (question.Question_type.Equals("Checkbox"))
                {
                    //we gonna creatre check box question control
                    CheckBoxList checkBoxQuestion = new CheckBoxList();
                    checkBoxQuestion.ID = "CheckBoxButton";
                    Session["CURRENT_QUESTION_TYPE"] = checkBoxQuestion.ID;
                    List<QuestionOption> questionOptions = getQuestionOPtions(currentQuetionIdSession);

                }
            }


        }



        private Question getNextQuestion(int currentQuestionId)
        {
            Question q = null;
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                SqlCommand cmd = new SqlCommand("select * from Question where id = " + currentQuestionId, conn);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();


                if (rd.Read())
                {
                    q = new Question();
                    q.Question_text = rd["question_text"].ToString();
                    q.Question_type = rd["question_type"].ToString();
                    q.Next_q_id = rd["next_q_id"] as int?;

                }

            }
            return q;
        }

        private List<QuestionOption> getQuestionOPtions(int currentQuestionId)
        {
            List<QuestionOption> options = new List<QuestionOption>();
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                SqlCommand cmd = new SqlCommand("select * from Question_Options where q_id = " + currentQuestionId, conn);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                QuestionOption op = null;

                while (rd.Read())
                {
                    op = new QuestionOption();
                    op.Id = (int)rd["Id"];
                    op.Option_text = rd["Options_text"].ToString();
                    op.Next_q_id = rd["Next_q_id"] as int?;

                    options.Add(op);
                }
            }

            return options;
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Stack<int> follwUpQuestionsList = (Stack<int>)Session["FOLLOWUP_ID_LIST"];
            int currentQuetionIdSession = follwUpQuestionsList.Pop();

            List<QuestionAnswers> questionAnswersInSession = null;

            if (Session["Question_ANSWER_LIST"] == null)
            {
                questionAnswersInSession = new List<QuestionAnswers>();
                Session["Question_ANSWER_LIST"] = questionAnswersInSession;
            }
            else
            {
                questionAnswersInSession = (List<QuestionAnswers>)Session["Question_ANSWER_LIST"];
            }
            //Access the current question from placeHolder
            Control userControl = PlaceHolder1.FindControl(Session["CURRENT_QUESTION_TYPE"].ToString());
            if (userControl is TextBox)
            {
                TextBox textBoxcontr = (TextBox)userControl;
                QuestionAnswers answers = new QuestionAnswers();
                answers.Answer_text = textBoxcontr.Text;
                answers.Q_id = currentQuetionIdSession;

                questionAnswersInSession.Add(answers);

            }
            else if (userControl is CheckBoxList)
            {
                CheckBoxList checkBoxcontr = (CheckBoxList)userControl;
                foreach (ListItem item in checkBoxcontr.Items)
                {
                    if (item.Selected)
                    {
                        if (item.Selected)
                        {
                            if (item.Attributes["nextQuestionId"] != null)
                            {
                                follwUpQuestionsList.Push(int.Parse(item.Attributes["nextQuestionId"]));
                            }
                        }
                        QuestionAnswers answers = new QuestionAnswers();
                        answers.Answer_text = null;
                        answers.Q_id = currentQuetionIdSession;
                        answers.Option_id = int.Parse(item.Value);
                        answers.Respondent_id = currentQuetionIdSession;
                        answers.Id = currentQuetionIdSession;

                        questionAnswersInSession.Add(answers);
                    }
                }
            }
            else if (userControl is RadioButtonList)
            {
                RadioButtonList radioButtonContr = (RadioButtonList)userControl;

                foreach (ListItem item in radioButtonContr.Items)
                {
                    if (item.Selected)
                    {
                        if (item.Selected)
                        {
                            if (item.Attributes["nextQuestionId"] != null)
                            {
                                follwUpQuestionsList.Push(int.Parse(item.Attributes["nextQuestionId"]));
                            }
                        }
                        QuestionAnswers answers = new QuestionAnswers();
                        answers.Answer_text = null;
                        answers.Q_id = currentQuetionIdSession;
                        answers.Option_id = int.Parse(item.Value);
                        answers.Respondent_id = currentQuetionIdSession;
                        answers.Id = currentQuetionIdSession;
                        questionAnswersInSession.Add(answers);
                    }
                }
            }
            Question question = getNextQuestion(currentQuetionIdSession);
            if (question.Next_q_id != null)
            {
                follwUpQuestionsList.Push((int)question.Next_q_id);
            }
            if (follwUpQuestionsList.Count() > 0)
            {
                Response.Redirect("SurveyQuestion.aspx");
            }
            else
            {
                //all questions have been answerd.Now go to the Endof survery and save data in the seesion into database
                Response.Redirect("EndOfSurvey.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnHomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("BankofHomePage.aspx");

        }
    }

}


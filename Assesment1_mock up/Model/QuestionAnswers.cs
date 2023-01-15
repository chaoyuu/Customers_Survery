using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assesment1_mock_up.Model
{
    public class QuestionAnswers
    {
        private int? id;
        private int q_id;
        private int? option_id;
        private int? respondent_id;
        private string answer_text;

        public int? Id { get => id; set => id = value; }
        public int Q_id { get => q_id; set => q_id = value; }
        public int? Option_id { get => option_id; set => option_id = value; }
        public int? Respondent_id { get => respondent_id; set => respondent_id = value; }
        public string Answer_text { get => answer_text; set => answer_text = value; }
    }
}
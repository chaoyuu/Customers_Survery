using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assesment1_mock_up.Model
{
    public class Question
    {
        private int id;
        private string question_text;
        private string question_type;
        private int? next_q_id;

        public int Id { get => id; set => id = value; }
        public string Question_text { get => question_text; set => question_text = value; }
        public string Question_type { get => question_type; set => question_type = value; }
        public int? Next_q_id { get => next_q_id; set => next_q_id = value; }

        public override string ToString()
        {
            return Id + "," + Question_text + " ," + Question_type + " ," + Next_q_id;
        }
    }
}
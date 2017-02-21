using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizDemo.Models
{
    /// <summary>
    /// A question contains 4 multiple choice Answers, with only 1 correct
    /// </summary>
    public class Question
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]       //don't auto generate IDs so I can manage them in the script
        public int QuestionId { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string Hint { get; set; }
        [Required]
        public int? CorrectId { get; set; }                     //serves dual purpose of containing reference to correct answerID
                                                                //  as well as containing the returned answer from an Exam.
                                                                //  Nullable to prevent radiobutton from selecting default answer.
        public virtual IList<Answer> Answers { get; set; }
    }
}
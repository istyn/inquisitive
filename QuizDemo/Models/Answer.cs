using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QuizDemo.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }               //primary key
        [Required]
        public string Text { get; set; }                //the text of the answer
        public int QuestionId { get; set; }             //foreign key
        public bool IsSelected { get; set; }            //boolean dictating if the user selected this value
        public bool IsAnswer { get; set; }              //boolean dictating if this answer should be highlighted after grading
        public virtual Question Question { get; set; }  //for lazy loading
    }
}
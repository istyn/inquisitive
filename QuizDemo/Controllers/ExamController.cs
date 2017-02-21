using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuizDemo.Models;

namespace QuizDemo.Controllers
{
    public class ExamController : Controller
    {
        private ExamContext db = new ExamContext();

        // GET: Exam
        public ActionResult Index()
        {
            if (Exam.NUMBER_OF_QUESTIONS > db.Questions.Count())
                throw new Exception("The number of questions in the database is less than the number requested.");
            return View(
                new Exam(db.Questions                   //populate view with an Exam containing a random selection of questions
                    .Include(a => a.Answers)
                    .AsNoTracking()
                    .Shuffle()
                    .Take(Exam.NUMBER_OF_QUESTIONS)));
        }
        /// <summary>
        /// Received the form containing the user answers, grades the questions, and returns the gradesheet.
        /// </summary>
        /// <param name="exam">The posted form.</param>
        /// <returns>view containing graded answers</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Exam exam)
        {
            return View(exam.Grade(ref db, exam));      //return the graded exam
        }
    }
}

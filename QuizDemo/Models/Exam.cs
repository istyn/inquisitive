using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QuizDemo.Models
{
    public class Exam
    {
        public static readonly int NUMBER_OF_QUESTIONS =2;     //constant: number of questions to give user
        public static readonly double GRADE_POINT_SCALE = 100;  //constant: maximum score
        public List<Question> Questions { get; set; }           //iterable list of Questions for an Exam
        public double GradePoint { get; set; }                       //grade
        public bool IsGraded = false;                           //flag denoting to display hints

        /// <summary>
        /// Initializes a new instance of the <see cref="Exam"/> class.
        /// </summary>
        public Exam()
        {
            Questions = new List<Question>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Exam"/> class from the results of a Entity Framework query.
        /// </summary>
        /// <param name="exam">The results of the query.</param>
        public Exam (IEnumerable<Question> exam)
        {
            Questions = exam.ToList();
            GradePoint = 100;
            for (int i = 0; i < Questions.Count(); i++)                             //set correctID to null to prevent radiobuttonfor from selecting a default answer
            {
                Questions[i].CorrectId = null;
            }
        }
        /// <summary>
        /// Adds the question to the IList<Question>
        /// </summary>
        /// <param name="q">The question to add.</param>
        private void AddQuestion(Question q)
        {
            Questions.Add(q);
        }
        /// <summary>
        /// Grades the specified exam using an ExamContext and returns the exam complete with information necessary to display
        /// </summary>
        /// <param name="db">The database.</param>
        /// <param name="exam">The exam.</param>
        /// <exception cref="Exception">User must provide an answer for each question.</exception>
        public Exam Grade(ref ExamContext db, Exam exam)
        {
            Exam graded = new Exam();
            graded.GradePoint = GRADE_POINT_SCALE;                                                       //ensure the grade wasn't modified prior to grading
            double questionValue = GRADE_POINT_SCALE / exam.Questions.Count;                      //questionValue -> the amount that each question is worth
            foreach (Question question in exam.Questions)                           //for every exam question, see if the selected answer matches the correct answer
            {
                if (question.CorrectId.HasValue)                                    //if the answer isn't null (client side validation should prevent this)
                {
                    Question correctAnswer = db.Questions                           //correctAnswer -> single Question object containing the identifier of the answer in CorrectID
                        .Include(a => a.Answers)
                        .Where(q => q.QuestionId == question.QuestionId)
                        .Single();
                    
                    foreach (Answer a in correctAnswer.Answers)                     //set the isSelected and isAnswer properties for proper display of graded exam
                    {
                        if (a.AnswerId == question.CorrectId)                       //if this answer is what the user selected
                        {
                            a.IsSelected = true;                                    //set it to selected for formatting
                        }
                        if (a.AnswerId == correctAnswer.CorrectId)                  //if this answer is the correct answer
                        {
                            a.IsAnswer = true;                                      //set it for formatting
                        }
                    }
                    graded.AddQuestion(correctAnswer);                              //
                    if (correctAnswer.CorrectId != question.CorrectId)              //the user answer is returned in Question.CorrectID
                    {
                        graded.GradePoint = graded.GradePoint - questionValue;                    //if the answer is incorrect then subtract the appropriate points for percentage
                    }                                                               //  Because this is a test of common sense, subtracting should HOPEFULLY save some operations
                }
                else throw new Exception("User must provide an answer for each question.");
            }
            graded.IsGraded = true;
            return graded;
        }
    }
}
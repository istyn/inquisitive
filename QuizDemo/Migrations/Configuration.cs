namespace QuizDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using QuizDemo.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<QuizDemo.Models.ExamContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QuizDemo.Models.ExamContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Questions.AddOrUpdate(
                new Question { QuestionId = 1, Text = "How many times you can subtract the number 5 from 25?", Hint = "After the first calculation, you will be subtracting 5 from 20, then 5 from 15, and so on.", CorrectId = 1 },
                new Question { QuestionId = 2, Text = "Is it legal for a man to marry his widow’s sister?", Hint = "If she is a a widow, then her husband has already died.", CorrectId = 5 },
                new Question { QuestionId = 3, Text = "If there are fifteen crows on the fence and the farmer shoots a third of them, how many are left?", Hint = "Birds fly away after hearing the shots.", CorrectId = 9 },
                new Question { QuestionId = 4, Text = "A clerk in the butcher shop is 5’10” tall. What does he weigh?", Hint = "The only thing for certain is that a butcher weights meat", CorrectId = 14 },
                new Question { QuestionId = 5, Text = "Before Mount Everest was discovered, what was the tallest mountain in the world?", Hint = "Although not always the tallest mountain, its discovery didn't change the fact that it is the tallest.", CorrectId = 19 },
                new Question { QuestionId = 6, Text = "Why is it against the law for a man living in North Carolina to be buried in South Carolina?", Hint = "Burying people alive is just wrong.", CorrectId = 21 },
                new Question { QuestionId = 7, Text = "How many animals of each species did Adam take with him on the ark?", Hint = "Adam didn't build an ark, that was Noah.", CorrectId = 25 },
                new Question { QuestionId = 8, Text = "How many birthdays does the average man have?", Hint = "One birthday, hopefully man birthday celebrations though!", CorrectId = 29 },
                new Question { QuestionId = 9, Text = "Some months have 31 days; how many have 28?", Hint = "Every month has at least 28 days.", CorrectId = 33 },
                new Question { QuestionId = 10, Text = "Divide 30 by 1/2 and add 10. What is the answer?", Hint = "Divide by 1/2 is equivalent to multiply by 2.", CorrectId = 37 },
                new Question { QuestionId = 11, Text = "If there are 3 apples and you take away 2, how many do you have?", Hint = "You have two.", CorrectId = 41 },
                new Question { QuestionId = 12, Text = "I have two U.S. coins totalling 55 cents. One is not a nickel. What are the coins?", Hint = "Only one of the coins can't be a nickel.", CorrectId = 45 },
                new Question { QuestionId = 13, Text = "A doctor gives you three pills telling you to take one every half hour. How long would the pills last?", Hint = "The first pill is taken immediately, leaving only two to be taken at 30 minutes and 1 hour.", CorrectId = 49 },
                new Question { QuestionId = 14, Text = "A farmer has 17 sheep; all but 9 die. How many are left?", Hint = "All but 9.", CorrectId = 53 },
                new Question { QuestionId = 15, Text = "Brothers and sisters I have none, but that man's father is my father's son. Who am I?", Hint = "I am that man's Father.", CorrectId = 57 },
                new Question { QuestionId = 16, Text = "A plane crashes on the border of Canada and the USA, 60 people die. Where do they bury the survivors?", Hint = "Survivors are not buried.", CorrectId = 61 },
                new Question { QuestionId = 17, Text = "I have 10 apples and I give all but 6 away, how many do I have left?", Hint = "I still have 6.", CorrectId = 65 },
                new Question { QuestionId = 18, Text = "A rooster laid an egg on top of the barn roof. Which way did it roll?", Hint = "Roosters do not lay eggs.", CorrectId = 69 },
                new Question { QuestionId = 19, Text = "How can a man go eight days without sleep?", Hint = "Sleep during the night.", CorrectId = 73 },
                new Question { QuestionId = 20, Text = "How much dirt is there in a hole 3 feet deep, 6 ft long and 4 ft wide? ", Hint = "To qualify as a hole there must not be any dirt in it.", CorrectId = 77 }
            );
            /*initialize the answers
            var answers = new Answer[]
            {
                new Answer { Text = "", QuestionId =  }
            };*/
            context.Answers.AddOrUpdate(
                new Answer { QuestionId = 1, Text = "1" },
                new Answer { QuestionId = 1, Text = "5" },
                new Answer { QuestionId = 1, Text = "As many as you care to" },
                new Answer { QuestionId = 1, Text = "0" },

                new Answer { QuestionId = 2, Text = "No, because he is dead" },
                new Answer { QuestionId = 2, Text = "No, because siblings can't marry" },
                new Answer { QuestionId = 2, Text = "Yes, the law can't tell you what to do" },
                new Answer { QuestionId = 2, Text = "Yes, but it may not sit well with the family" },

                new Answer { QuestionId = 3, Text = "0" },
                new Answer { QuestionId = 3, Text = "5" },
                new Answer { QuestionId = 3, Text = "10" },
                new Answer { QuestionId = 3, Text = "7" },

                new Answer { QuestionId = 4, Text = "180" },
                new Answer { QuestionId = 4, Text = "Meat" },
                new Answer { QuestionId = 4, Text = "210" },
                new Answer { QuestionId = 4, Text = "90" },

                new Answer { QuestionId = 5, Text = "Mt. Kilimanjaro" },
                new Answer { QuestionId = 5, Text = "We can only guess" },
                new Answer { QuestionId = 5, Text = "Mt. Everest" },
                new Answer { QuestionId = 5, Text = "Mt. Rushmore" },

                new Answer { QuestionId = 6, Text = "He isn't dead yet" },
                new Answer { QuestionId = 6, Text = "He isn't a citizen of South Carolina" },
                new Answer { QuestionId = 6, Text = "He hasn't applied for citizenship" },
                new Answer { QuestionId = 6, Text = "North Carolina Law prohibits it" },

                new Answer { QuestionId = 7, Text = "Adam didn't take any" },
                new Answer { QuestionId = 7, Text = "One of each sex" },
                new Answer { QuestionId = 7, Text = "Two, for redundancy" },
                new Answer { QuestionId = 7, Text = "One" },

                new Answer { QuestionId = 8, Text = "1" },
                new Answer { QuestionId = 8, Text = "60" },
                new Answer { QuestionId = 8, Text = "79" },
                new Answer { QuestionId = 8, Text = "65" },

                new Answer { QuestionId = 9, Text = "12" },
                new Answer { QuestionId = 9, Text = "1" },
                new Answer { QuestionId = 9, Text = "2" },
                new Answer { QuestionId = 9, Text = "3" },

                new Answer { QuestionId = 10, Text = "70" },
                new Answer { QuestionId = 10, Text = "60" },
                new Answer { QuestionId = 10, Text = "45" },
                new Answer { QuestionId = 10, Text = "75" },

                new Answer { QuestionId = 11, Text = "2" },
                new Answer { QuestionId = 11, Text = "3" },
                new Answer { QuestionId = 11, Text = "1" },
                new Answer { QuestionId = 11, Text = "0" },

                new Answer { QuestionId = 12, Text = "Fifty cent piece and a nickel" },
                new Answer { QuestionId = 12, Text = "Two quarters and a nickel" },
                new Answer { QuestionId = 12, Text = "Five dimes and a nickel" },
                new Answer { QuestionId = 12, Text = "Eleven nickels" },

                new Answer { QuestionId = 13, Text = "1 hour" },
                new Answer { QuestionId = 13, Text = "1.5 hours" },
                new Answer { QuestionId = 13, Text = "Depends on their half-life" },
                new Answer { QuestionId = 13, Text = "2 hours" },

                new Answer { QuestionId = 14, Text = "9" },
                new Answer { QuestionId = 14, Text = "8" },
                new Answer { QuestionId = 14, Text = "6" },
                new Answer { QuestionId = 14, Text = "14" },

                new Answer { QuestionId = 15, Text = "Father" },
                new Answer { QuestionId = 15, Text = "Grandfather" },
                new Answer { QuestionId = 15, Text = "Uncle" },
                new Answer { QuestionId = 15, Text = "Son" },

                new Answer { QuestionId = 16, Text = "Neither" },
                new Answer { QuestionId = 16, Text = "Canada" },
                new Answer { QuestionId = 16, Text = "USA" },
                new Answer { QuestionId = 16, Text = "Split 50-50" },

                new Answer { QuestionId = 17, Text = "6" },
                new Answer { QuestionId = 17, Text = "5" },
                new Answer { QuestionId = 17, Text = "4" },
                new Answer { QuestionId = 17, Text = "0" },

                new Answer { QuestionId = 18, Text = "It didn't roll - roosters don't lay eggs" },
                new Answer { QuestionId = 18, Text = "Down the shortest side" },
                new Answer { QuestionId = 18, Text = "Down the nearest side" },
                new Answer { QuestionId = 18, Text = "South" },

                new Answer { QuestionId = 19, Text = "By sleeping during the night time" },
                new Answer { QuestionId = 19, Text = "Coffee" },
                new Answer { QuestionId = 19, Text = "Toothpicks for you eyelids" },
                new Answer { QuestionId = 19, Text = "Artificial light" },

                new Answer { QuestionId = 20, Text = "None or else it wouldn't be a hole" },
                new Answer { QuestionId = 20, Text = "72 ft^3" },
                new Answer { QuestionId = 20, Text = "68 ft^3" },
                new Answer { QuestionId = 20, Text = "82 ft^3" }
            );
        }
    }
}

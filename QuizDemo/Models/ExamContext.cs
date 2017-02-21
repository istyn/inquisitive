namespace QuizDemo.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ExamContext : DbContext
    {
        // Your context has been configured to use a 'ExamContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QuizDemo.Models.ExamContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ExamContext' 
        // connection string in the application configuration file.
        public ExamContext()
            : base("name=ExamContext")
        {
        }


        public DbSet<Question> Questions { get; set; }              //establish the tables
        public DbSet<Answer> Answers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Question>() //opt into using stored procedures for insert, update and delete
            .MapToStoredProcedures();*/
            modelBuilder.Entity<Answer>().ToTable("Answer");        //override default plural table names to singular
            modelBuilder.Entity<Question>().ToTable("Question");

        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
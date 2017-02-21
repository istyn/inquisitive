using Microsoft.Owin;
using Owin;
using QuizDemo.Models;
using QuizDemo.Data;

[assembly: OwinStartupAttribute(typeof(QuizDemo.Startup))]
namespace QuizDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app/*, ExamContext context*/)
        {
            ConfigureAuth(app);
        }
    }
}

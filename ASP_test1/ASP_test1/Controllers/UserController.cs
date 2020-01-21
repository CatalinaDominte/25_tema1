using ASP_test1.Models;
using System.Web.Mvc;



namespace ASP_test1.Controllers
{
    public class UserController : Controller
    {
        private readonly UserData userData;
        public UserController()
        {
            this.userData = new UserData();
        }
        public ActionResult Index()
        {
            var users = this.userData.GetUsers();
            return this.View(users);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using ViewComponents.Models;

namespace ViewComponents.ViewComponentsClass
{
    public class CountViewComponent : ViewComponent//to Make this class ViewComponent must Inherit the Class and Class name should be End with ViewComponent and just like Contoller Suffix is not written anywhere
    {
        List<CountClass> countClasses = new List<CountClass>();
        public CountViewComponent()//We Can also Inject DbContext or Repo Class
        {
            countClasses.Add(new CountClass() { Count = 1, Dept = "HR" });
            countClasses.Add(new CountClass() { Count = 2, Dept = "IT" });
            countClasses.Add(new CountClass() { Count = 3, Dept = "SDE" });
            countClasses.Add(new CountClass() { Count = 23, Dept = "JE" });
            countClasses.Add(new CountClass() { Count = 2, Dept = "CE" });
            countClasses.Add(new CountClass() { Count = 45, Dept = "YU" });
            countClasses.Add(new CountClass() { Count = 43, Dept = "BE" });
        }
        public IViewComponentResult Invoke()//IViewComponentResult should always be name as Invoke() or InvokeAsync()
        {

            return View(countClasses);//The View Vill be created in Shared/Components/Count(Without ViewComponent)/Default view name must have cshtml name will be Default.cshtml
        }
    }
}

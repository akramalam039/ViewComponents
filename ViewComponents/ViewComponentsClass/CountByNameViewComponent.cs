using Microsoft.AspNetCore.Mvc;
using ViewComponents.Models;

namespace ViewComponents.ViewComponentsClass
{
    public class CountByNameViewComponent : ViewComponent
    {
        List<CountClass> countClasses = new List<CountClass>();
        //We Can also Inject DbContext or Repo Class

        public CountByNameViewComponent()
        {
            countClasses.Add(new CountClass() { Count = 1, Dept = "HR" });
            countClasses.Add(new CountClass() { Count = 2, Dept = "IT" });
            countClasses.Add(new CountClass() { Count = 3, Dept = "SDE" });
            countClasses.Add(new CountClass() { Count = 23, Dept = "JE" });
            countClasses.Add(new CountClass() { Count = 2, Dept = "CE" });
            countClasses.Add(new CountClass() { Count = 45, Dept = "YU" });
            countClasses.Add(new CountClass() { Count = 43, Dept = "BE" });
        }

        public async Task<IViewComponentResult> InvokeAsync(string Dept)
        {

            return await Task.FromResult((IViewComponentResult)View("View", countClasses.Where(x => x.Dept == Dept).FirstOrDefault()));
        }
    }
}

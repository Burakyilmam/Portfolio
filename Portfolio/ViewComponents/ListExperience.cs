using Microsoft.AspNetCore.Mvc;
using Portfolio.Repositories;

namespace Portfolio.ViewComponents
{
    public class ListExperience : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ExperienceRepository er = new ExperienceRepository();
            var value = er.List();
            return View(value);
        }
    }
}

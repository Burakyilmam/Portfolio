using Microsoft.AspNetCore.Mvc;
using Portfolio.Repositories;

namespace Portfolio.ViewComponents
{
    public class ListEducation : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            EducationRepository er = new EducationRepository();
            var value = er.List();
            return View(value);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Portfolio.Repositories;

namespace Portfolio.ViewComponents
{
    public class ListLanguage : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            LanguageRepository lr = new LanguageRepository();
            var value = lr.List();
            return View(value);
        }
    }
}

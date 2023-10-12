using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Repositories;

namespace Portfolio.ViewComponents
{
    public class ListInfo : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            InfoRepository ir = new InfoRepository();
            var value = ir.List();
            return View(value);
        }
    }
}

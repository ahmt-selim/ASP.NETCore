using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewStructure.Models;

namespace ViewStructure.ViewComponents
{
    public class WorkChartViewComponent : ViewComponent
    {

        List<WorkChart> workChart = new List<WorkChart>()
        {
            new WorkChart("Ahmet", new List<bool>{true, false, true, true, false}),
            new WorkChart("Selim", new List<bool>{false, false, true, true, true}),
            new WorkChart("Ayşe", new List<bool>{true, true, false, true, false}),
            new WorkChart("Merve", new List<bool>{true, true, true, false, false})
        };
        public IViewComponentResult Invoke(int id)
        {
            return View(workChart);
        }

    }
}

using System.Collections.Generic;
using System.Web.Mvc;
using CodeAssignment.Models;
using CodeAssignment.Utilities;

namespace CodeAssignment.Controllers
{
    public class FindTriplicateController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FindTriplicates(string numbers)
        {
            var model = new FindTriplicateModel();

            model.Numbers = numbers;

            string errorMessage;
            List<int> parsedNumbers = ListSerializer.Deserialize(numbers ?? "", out errorMessage);

            if (string.IsNullOrEmpty(errorMessage))
            {
                var result = TriplicateCalulator.CalculateTriplicates(parsedNumbers);
                model.Result = ListSerializer.Serialize(result);
            }
            else
            {
                model.ErrorMessage = errorMessage;
            }

            return View(model);
        }
    }
}
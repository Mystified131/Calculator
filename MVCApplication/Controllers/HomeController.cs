using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using MVCApplication.ViewModels;

namespace MVCApplication.Controllers
{
  
    public class HomeController : Controller
    {
        static double calcnum;

        public IActionResult Index()

        {
            ViewBag.calcnum = calcnum;

            IndexViewModel indexViewModel = new IndexViewModel();

            return View(indexViewModel);
        }


        public IActionResult Error()
        {

            return View();
        }

        public IActionResult Result()
        {
            ResultViewModel resultViewModel = new ResultViewModel();

            resultViewModel.Error = "Please return to the 'Calculate' Page to create a result.";

            return View(resultViewModel);
        }

        [HttpPost]
        public IActionResult Result(ResultViewModel resultViewModel)

        {
            if (ModelState.IsValid)
            {
                GetResult qbert = new GetResult("qbert");

                if (resultViewModel.Operation == "+")
                {
                    resultViewModel.Result = qbert.Sum(resultViewModel.Value1, resultViewModel.Value2);
                }

                if (resultViewModel.Operation == "-")
                {
                    resultViewModel.Result = qbert.Difference(resultViewModel.Value1, resultViewModel.Value2);
                }

                if (resultViewModel.Operation == "*")
                {
                    resultViewModel.Result = qbert.Product(resultViewModel.Value1, resultViewModel.Value2);
                }

                if (resultViewModel.Operation == "/")
                {
                    resultViewModel.Result = qbert.Quotient(resultViewModel.Value1, resultViewModel.Value2);
                }


                calcnum = resultViewModel.Result;

                return View(resultViewModel);
            }

            return Redirect("/Home/Error");

        }

    }



}

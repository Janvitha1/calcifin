using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();

        }
        [HttpPost]
        public ActionResult Index(string firstNumber, string secondNumber, string Cal)

        {
            try
            {
              if (!(string.IsNullOrEmpty(firstNumber) || string.IsNullOrEmpty(secondNumber)))

                {


                    double a = Double.Parse(firstNumber);
                    double b = Double.Parse(secondNumber);
                    double result = 0
                        ;

                    if (Cal == "Add")
                    {
                        result = a + b;
                    }
                    else if (Cal == "Sub")
                    {
                        result = a - b;

                    }
                    else if (Cal == "Mul")
                    {
                        result = a * b;
                    }


                    else if (Cal == "Div")
                    {

                        result = a / b;
                    }



                    ViewBag.Result = result;

                }

                else
                {
                    ViewBag.Error = "Please enter values";
                }
            }
            catch (FormatException )
            {
                ViewBag.Error  = "please enter valid number";
            }
           

            return View();
        }

    
        }
            
        } 


        
    


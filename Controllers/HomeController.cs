using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Protocolos_HTTP.Models;

namespace Protocolos_HTTP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public double Addition(double num1, double num2){

            double result;
            try{
               result = num1 + num2;
            } catch (FormatException){
                throw new FormatException("Insira apenas numeros");
            }
            return result;
        }
                [HttpGet]
        public double Subtraction(double num1, double num2){

            double result;
            try{
               result = num1 - num2;
            } catch (FormatException){
                throw new FormatException("Insira apenas numeros");
            }
            return result;
        }
                [HttpGet]
        public double Multiplication(double num1, double num2){

            double result;
            try{
               result = num1 * num2;
            } catch (FormatException){
                throw new FormatException("Insira apenas numeros");
            }
            return result;
        }
                [HttpGet]
        public double Division(double num1, double num2){

            double result;
            try{
               result = num1 / num2;
            } catch (FormatException){
                throw new FormatException("Insira apenas numeros");
            }
            return result;
        }

        public string Bhaskara(double num1, double num2, double num3){

            double result;
            double result1;
            try{
               result = (-num2 + Math.Sqrt(num2 * num2 + 4 * num1 * num2)) / 2*num1;
               result1 = (-num2 - Math.Sqrt(num2 * num2 + 4 * num1 * num2)) / 2*num1;
            } catch (FormatException){
                throw new FormatException("Insira apenas numeros");
            }
            string v = "X = " + result + " ou X= " + result1;
            return v;
        }

        [HttpPost]
        public string OnFormPost(string arg) => $"OnPost result = {arg}";

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

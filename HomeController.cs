using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net;
using WebTest.Models;
using HtmlAgilityPack;
using System.Text;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System.Globalization;
using MySql.Data.MySqlClient;


namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Estudante estudante = new Estudante();

            string connStr = "server=localhost;user=root;database=aspdotnet;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                //Console.WriteLine("Ligar ao MySQL...");
                conn.Open();

                string sql = "SELECT * FROM turma";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr[0]);
                    estudante.Nome = (string)rdr[1];

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
            }

            conn.Close();
            //Console.WriteLine("Feito.");

            return View(estudante);
        }

        public IActionResult Privacy()
        {


            return View();
        }

        public IActionResult Galeria()
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

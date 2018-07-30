using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoinCeng_MVC_Map.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            {
                string markers = "[";
                string conString = ConfigurationManager.ConnectionStrings["JoinCeng_Map"].ConnectionString;
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProjeIlani");
                using (SqlConnection con = new SqlConnection(conString))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            markers += "{";
                            markers += string.Format("'title': '{0}',", sdr["Adres"]);
                            markers += string.Format("'lat': '{0}',", sdr["Enlem"]);
                            markers += string.Format("'lng': '{0}',", sdr["Boylam"]);
                            markers += string.Format("'description': '{0}'", sdr["Aciklama"]);
                            markers += "},";
                        }
                    }
                    con.Close();
                }

                markers += "];";
                ViewBag.Markers = markers;
                return View();
            }
        }
    }
}
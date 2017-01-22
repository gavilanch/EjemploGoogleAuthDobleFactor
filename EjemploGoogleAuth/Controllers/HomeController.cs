using Google.Authenticator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploGoogleAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            if (User.Identity.IsAuthenticated)
            {
                // Registrar autenticación
                TwoFactorAuthenticator autenticador = new TwoFactorAuthenticator();

                // El código secreto es por usuario
                var setupInfo = autenticador.GenerateSetupCode("CursoAspNetMvc",
                    User.Identity.Name,
                    "ALSKDMASKLDMKALDKSA", 300, 300);

                ViewBag.qrCodeImageUrl = setupInfo.QrCodeSetupImageUrl;
                ViewBag.manualEntrySetupCode = setupInfo.ManualEntryKey;

                //login

                bool pinCorrecto = autenticador.ValidateTwoFactorPIN("ALSKDMASKLDMKALDKSA",
                    "239056");

            }



            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
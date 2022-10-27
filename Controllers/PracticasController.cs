﻿using Ejemplo1Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1Asp.Controllers
{
    public class PracticasController : Controller
    {
        // GET: Practicas
        public ActionResult Index()
        {
            var persona = new Persona()
            {
                Nombre = "Samanta",
                Edad = 23,
                Empleado = true,
                Nacimiento = new DateTime(2001, 8, 7)
            };
            ViewBag.Propiedad = persona;

            return View();
        }
    }
}
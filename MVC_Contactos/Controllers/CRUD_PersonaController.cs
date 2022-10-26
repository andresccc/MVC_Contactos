using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using MVC_Contactos.Models;

namespace MVC_Contactos.Controllers
{
    public class CRUD_PersonaController : Controller
    {
        //Creamos la variable de almacenamiento de la lista de personas
        public static List<ModeloPersona> ListaPersonas = new List<ModeloPersona>()
        {
            new ModeloPersona() {PersonaId = 1, Nombre = "Andrés Gómez", Telefono = "3005776492", Email = "andres@gmail.com"},
            new ModeloPersona() {PersonaId = 2, Nombre = "Salomé Acosta", Telefono = "3218437554", Email = "salome@gmail.com"},
            new ModeloPersona() { PersonaId = 3, Nombre = "Jorge Montoya", Telefono = "3005776322", Email = "jorge@gmail.com"},
            new ModeloPersona() { PersonaId = 4, Nombre = "Samuel Martinéz", Telefono = "3247764921", Email = "samuel@gmail.com"}
        };   

        // GET: CRUD_Persona
        public ActionResult Index()
        {
            return View(ListaPersonas);//Importante para ejecución de Model
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost] //recibe los datos para el registro de nuevo ingreso

        public ActionResult Nuevo(FormCollection collection)
        {
            Random random = new Random();

            var Persona = new ModeloPersona();
            Persona.PersonaId = random.Next(10, 99);
            Persona.Nombre = collection["Nombre"];
            Persona.Telefono = collection["Telefono"];
            Persona.Email = collection["Email"];
            ListaPersonas.Add(Persona);

            return RedirectToAction("Index");
        }

    }
}
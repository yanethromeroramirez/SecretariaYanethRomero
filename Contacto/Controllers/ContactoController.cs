using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Contacto.Models;

namespace Contacto.Controllers
{
    public class ContactoController : ApiController
    {
        private PRUEBATECNICA db = new PRUEBATECNICA();


        // POST: api/Contacto
        /// <summary>
        /// Método encargado de recibir una petición POST  y almacenar un registro de contacto en la base de datos
        /// </summary>
        /// <param name="model">ID_CONTACTO integer, CODTIPOIDENTIFICACION integer, NUMEROIDENTIFICACION string, NOMBRES string, APELLIDOS string, MENSAJE string
        /// <returns></returns>
        [ResponseType(typeof(CONTACTO))]
        public IHttpActionResult PostCONTACTO(CONTACTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            db.CONTACTOes.Add(model);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = model.ID_CONTACTO }, model);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
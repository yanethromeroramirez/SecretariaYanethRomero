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
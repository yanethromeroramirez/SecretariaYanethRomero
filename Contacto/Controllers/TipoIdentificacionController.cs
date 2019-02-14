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
    public class TipoIdentificacionController : ApiController
    {
        private PRUEBATECNICA db = new PRUEBATECNICA();

        // GET: api/TipoIdentificacion
        public IQueryable<TIPOIDENTIFICACION> GetTIPOIDENTIFICACIONs()
        {
            return db.TIPOIDENTIFICACIONs;
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
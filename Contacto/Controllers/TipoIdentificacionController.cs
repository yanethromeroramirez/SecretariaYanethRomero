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
        /// <summary>
        /// Método encargado de recibir una petición GET  y listar los tipos de identificación
        /// </summary>
        /// <returns>  IQueryable<int ID_TIPOIDENTIFICACION,  string NOMBRE></int></returns>
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
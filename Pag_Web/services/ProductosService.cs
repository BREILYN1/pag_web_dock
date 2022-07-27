using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Pag_Web.models;

namespace Pag_Web.services
{
    public class ProductosService
    {
        private IMongoCollection<Productos> _Productos;
        public ProductosService(Ipag_webSettings settings)
        {
            var cliente = new MongoClient(settings.Server);
            var database = cliente.GetDatabase(settings.Database);
            _Productos= database.GetCollection<Productos>(settings.Collection);
           
        }
        public List<Productos> Get()
        {
            return _Productos.Find(d => true).ToList();
        }
    }
}

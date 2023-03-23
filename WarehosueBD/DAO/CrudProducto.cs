using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehosueBD.Models;

namespace WarehosueBD.DAO
{
    public class CrudProducto
    {

        public void AgregueProduct(Producto ParametroProducto)
        {
            using (AlmacenBdContext BaseDeDatos = new AlmacenBdContext())
            {
                Producto product = new Producto();
                product.Nombre = ParametroProducto.Nombre;
                product.Descripcion = ParametroProducto.Descripcion;
                product.Precio = ParametroProducto.Precio;
                product.Stock = ParametroProducto.Stock;
                BaseDeDatos.Add(product);
                BaseDeDatos.SaveChanges();
                
            }
        }

    }
}

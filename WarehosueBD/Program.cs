using WarehosueBD.DAO;
using WarehosueBD.Models;

CrudProducto CrudProducto = new CrudProducto();
Producto product = new Producto();


Console.Write("Bienvienido Usuario Inteligente\n");

Console.WriteLine(@"
MENU
Ingrese 0 para ingresar un nuevo producto que desee
Ingrese 1 para salir");

var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu)
{
    case 0:
        bool bucle = true;
        while (bucle == true)
        {
            Console.Write("Escriba el nombre del producto nuevo: ");
            product.Nombre = Console.ReadLine();
            Console.Write("Escriba la descripcion  del producto nuevo: ");
            product.Descripcion = Console.ReadLine();
            Console.Write("Ingrese  el precio del producto nuevo: $");
            product.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Escriba la cantidad  del producto nuevo: ");
            product.Stock = Convert.ToInt32(Console.ReadLine());

            CrudProducto.AgregueProduct(product);
            Console.WriteLine(@"
El producto nuevo ya esta registrado

Ingrese 0 para ingresar un nuevo producto que desee
Ingrese 1 para salir
");
            var Menu1 = Convert.ToInt32(Console.ReadLine());

            switch (Menu1)
            { case 0:
                    bucle = true;
                    break;
              case 1:
                    bucle = false;
                    break;
          
            }




        }
        break;

    case 1:
        Console.WriteLine("Gracias por usar nuestro programa");
        break;
}
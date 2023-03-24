// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region
//using Almacen.Models;

//using (AlmacenContext db = new AlmacenContext())
//{
//    Producto producto = new Producto();

//    Console.WriteLine("Ingresar nombre del producto");
//    producto.Nombre = Console.ReadLine();

//    Console.WriteLine("Ingresar la descripcion");
//    producto.Descripcion = Console.ReadLine();

//    Console.WriteLine("Ingresar el precio");
//    producto.Precio = Convert.ToDecimal(Console.ReadLine());

//    Console.WriteLine("Ingresar la cantidad de producto");
//    producto.Stock = Convert.ToInt32(Console.ReadLine());

//    db.Productos.Add(producto);
//    db.SaveChanges();


//}
#endregion


using Almacen.DAO;
using Almacen.Models;
using System;
using System.Xml;

CrudProductos crudProductos = new CrudProductos();
Producto Producto = new Producto();

Console.WriteLine("Menu\n");
Console.WriteLine("Seleccione  1 para  insertar productos\n");
Console.WriteLine("Seleccione  2 para salir\n ");

var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu)
{
    case 1:
        bool bucle = true;
        while(bucle == true)
        {
            Console.WriteLine("Ingresa nombre del producto");
            Producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa la descripcion del producto");
            Producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingresa el precio del producto");
            Producto.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de prodcuto");
            Producto.Stock = Convert.ToInt32(Console.ReadLine());

            crudProductos.AgregarProducto(Producto);

            Console.WriteLine("El Producto se ingreso\n");           
            Console.WriteLine("Seleccione 1 para seguir insertando productos\n");
            Console.WriteLine("Seleccione 2 para salir\n");
            

            var Menu2 = Convert.ToInt32(Console.ReadLine());

            switch (Menu2)
            {
                case 1:
                    bucle = true;
                    break;

                case 2:
                    Console.Write("Fin del programa");
                    bucle = false;
                    break;

                default:
                    Console.Write("Ingrese una opcion del menu");
                    break;

            
            }

        }
        break;

    case 2:
        Console.Write("Fin del programa");
        break;

    default:
        Console.Write("La opcion no se encuentra");
        break;     

}



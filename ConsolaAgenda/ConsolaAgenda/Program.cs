using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Entidades;

namespace ConsoleAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            // es el punto de ingreso, lo que ejecuta mi aplicación
            //cuando creamos una clase, además pasa a ser un tipo

            //Generamos las instancias de la clase
            Contacto c1 = new Contacto("Juan", "Montoya", "1122664856", "Perú 571");
            Contacto c2 = new Contacto("Gisella", "Mendez", "1156319855", "Arevalos 127");
            Contacto c3 = new Contacto("David", "Rojas", "1155885912", "Sarmiento 1566");

            try
            {
                AgendaContacto agendaElectronica = new AgendaContacto("Mi Agenda");
                agendaElectronica.AgregarContacto(c1);
                agendaElectronica.AgregarContacto(c2);
                agendaElectronica.AgregarContacto(c3);
                bool consolaActiva = true;
                while (consolaActiva)
                {
                    DesplegarOpcionesMenu();
                    string opcionMenu = Console.ReadLine();
                    switch (opcionMenu)
                    {
                        case "1":
                            //listar
                            Listar(agendaElectronica);
                            break;
                        case "2":
                            //agregar contactos
                            //Contacto c = PedirInputsContacto();
                            Agregar(agendaElectronica);
                            break;
                        case "3":
                            //listar contactos frecuentes
                            break;
                        case "4":
                            //eliminar contactos
                            break;
                        case "5":
                            //Llamar contacto
                            break;
                        case "x":
                            consolaActiva = false;
                            break;
                        default:
                            break;


                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error general");
            }

        }
        public static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Seleccione la opción deseada");
            Console.WriteLine("Opción 1: Listar");
            Console.WriteLine("Opción 2: Agregar contacto");
            Console.WriteLine("Opción 3: Listar contactos frecuentes");
            Console.WriteLine("Opción 4: Eliminar contacto");
            Console.WriteLine("Opción X: Salir");
        }

        public static void Listar(AgendaContacto agenda)
        {
            foreach (Contacto c in agenda.Contactos)
            {
                Console.WriteLine($"{c.Nombre} - {c.Telefono} - ");
            }
        }

        public static void Agregar(AgendaContacto agendaElectronica)
        {
            bool agrego = true;
            Console.WriteLine("Ingrese el nombre");
            string nombre = Console.ReadLine();
            if (nombre.Length<3)
            {
                Console.WriteLine("El nombre es muy corto");
                agrego = false;
            }
            Console.WriteLine("Ingrese el apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección");
            string direccion = Console.ReadLine();

            Contacto cn = new Contacto(nombre, apellido, telefono, direccion);
            if (agrego)
            {
                agendaElectronica.AgregarContacto(cn);
                Console.WriteLine("Contacto agregado");
            }
            else
            {
                
                Console.WriteLine("No se pudo agregar contacto, revise los datos e intente nuevamente");
            }
            
        }
        //public static Contacto PedirInputsContacto()
        //{
        //    string nombre = Console.ReadLine();
        //    string apellido = Console.ReadLine();
        //    string telefono = Console.ReadLine();
        //    Contacto cn = new Contacto(nombre, apellido, telefono);

        //    return cn;
        //}
    }
}

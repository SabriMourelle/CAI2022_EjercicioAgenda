using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAgenda
{
    public class Contacto
    {
        //Constructores, NO ES UN METODO.
        //sirve para inicializar la instancia de una (un objeto)

        public Contacto(string nombre, string apellido, string telefono, string direccion)
        {
            
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _direccion = direccion;
            //_fechaDeNac = fecha; Cómo se ingresa el formato de la fecha?
            _llamadas = 0;
        }
       

        //Atributos
        //atributos de clase: puede ser private o protegida
        //tipo de dato del atributo: string, int, etc
        //vamos a nombrarlo según camel case: comienza con _ y si debo separar palabras lo hago con mayúsculas _nombreDeContacto
        private string _nombre;
        private string _apellido;
        private string _telefono; 
        private string _direccion;
        private DateTime _fechaDeNac;
        private int _llamadas;

        //Encapsulamiento (propiedades:son los atributos encapsulados)
        public string Nombre
        {
            //el get se parece a una función porque devuelva algo
            get
            {
                return _nombre;
            }
            //si no ponemos set, la propiedad pasa a ser read only
            //el set es parecido a una subrutina, no devuelve nada
            set 
            {
                _nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }
        public string Telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
            }
        }
       public DateTime FechaDeNac
        {
        
           get
        {
               return _fechaDeNac;
          }
            //si no ponemos set, la propiedad pasa a ser read only
            //el set es parecido a una subrutina, no devuelve nada
          set
          {
              _fechaDeNac = value;
            }
        }
        public string Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }
        public int Llamadas
        {
            get
            {
                return _llamadas;
            }
        }

        

        //Métodos
        //un método puede ser de dos tipos: función o subrutina. Los métodos además tienen una firma, de qué forma se desarrollan.
        //Una función devuelve algo, una subfunción es void, no devuelve nada
        //firma conjunto de visibilidad, tipo de dato que devuelve, nombre del método, parámentro

        public int Edad()
        {
            // lo que va adentro de las llaves es la implementación: es decir el algoritmo que hace
            return 0;
        }

        public void Llamar()
        {
            // lo que va adentro de las llaves es la implementación: es decir el algoritmo que hace
            
        }
    }
}

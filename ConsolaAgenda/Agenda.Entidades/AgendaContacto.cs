using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Agenda.Entidades.Exceptions;

namespace Agenda.Entidades
{
    public class AgendaContacto
    {
        //Constructores

        //Atributos
        private string _nombre;
        private string _tipo;
        private List<Contacto> _contactos;
        private int _cantidadMaximaContactos;

        //tener una variable no me garantiza tener un objeto

        //Encapsulamiento
        //no siempre hay que encapsularlo
        public string Nombre
        {

            get
            {
                return _nombre;
            }
        
            set
            {
                _nombre = value;
            }
        }
        public string Tipo
        {
            
            get
            {
                return _tipo;
            }
        
            set
            {
                _tipo = value;
            }
        }
        public IEnumerable<Contacto> Contactos
        {
            //Al poner IEnumerable, mando un objeto que es solo elegible... si le pongo lista nada impide que sea modificable
            get
            {
                return _contactos;
            }

            //set
            //{
            //    _contactos = value;
            //}
        }
        public int CantidadMaximaContactos
        {

            get
            {
                return _cantidadMaximaContactos;
            }

            set
            {
                _cantidadMaximaContactos = value;
            }
        }

        //Constructores
        public AgendaContacto (string nombre)
        {
            _nombre = nombre;
            _contactos = new List<Contacto>();
            //Inicializo la lista, sino cuando quiera agregar un contacto y encuentre NULL me va a tirar error
        }

        
       

        //Métodos
        public void AgregarContacto(Contacto contacto)
        {
            //valido que el contacto no exista (regla de negocio:no telefonos repetidos)
            bool permitoAgregar=true;

            foreach(Contacto contacto1 in _contactos)
            {
                if (contacto1.Telefono == contacto.Telefono)
                    permitoAgregar = false;
            }
            if(permitoAgregar)
            _contactos.Add(contacto);
        }
        public void EliminarContacto()
        {
            
        }

        //public Contacto TraerContactoFrecuente()
        //{
        //    return Contacto;
        //}
    }
}

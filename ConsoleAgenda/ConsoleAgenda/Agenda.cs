using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAgenda
{
    public class Agenda
    {
        //Constructores

        //Atributos
        private string _nombre;
        private string _tipo;
        private List<Contacto> _contactos;
        private int _cantidadMaximaContactos;

        //Encapsulamiento
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
        public List<Contacto> Contactos
        {

            get
            {
                return _contactos;
            }

            set
            {
                _contactos = value;
            }
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

        //Métodos
        public void AgregarContacto()
        {

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

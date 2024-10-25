using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Biblioteca
{
    public class Libro
    {
        private string Titulo {  get; set; }
        private string Autor { get; set; }
        private string ISBN { get; set; }
        private string Genero { get; set; }
        private bool Disponibilidad { get; set; }

        public Libro(string titulo, string autor, string iSBN, string genero, bool disponibilidad)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            Genero = genero;
            Disponibilidad = disponibilidad;
        }
         public bool Disponible()
        {
            return Disponibilidad;
        }
        public bool CambiarDisponibilidad( bool  disponibilidad )
        {
              return Disponibilidad=disponibilidad;
        }
    }
}

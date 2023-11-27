using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturaLib.Models
{
    public class BookModel
    {
        //propiedades 
        public int Id_book { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }
        public string Genero { get; set; }
        public int Stock { get; set; }
    
        //constructor
        public BookModel(int idBook, string titulo, string autor, int anio, string genero, int stock)
        {
            Id_book = idBook;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Genero = genero;
            Stock = stock;
        }
    
    }
}

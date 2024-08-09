using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_E2.Abstracoes
{
    // Classe que representa um livro na biblioteca
    public class Livro
    {
        public string Titulo { get; set; }   // Título do livro
        public string Autor { get; set; }    // Autor do livro
        public Professor Professor { get; set; } // Professor associado ao livro, se necessário

        // Construtor para inicializar um novo livro
        public Livro(string titulo, string autor, Professor professor)
        {
            Titulo = titulo;
            Autor = autor;
            Professor = professor;
        }
    }
}

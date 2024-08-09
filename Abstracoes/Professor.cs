using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_E2.Abstracoes
{
    /// Classe que representa um professor responsável por gerenciar reservas de livros
    public class Professor
    {
        public string Nome { get; set; }        // Nome do professor
        public int Matricula { get; set; }      // Número de matrícula do professor

        // Construtor para inicializar um novo professor
        public Professor(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_E2.Abstracoes
{
    // Classe que representa uma reserva de livro por um estudante, gerenciada por um professor
    public class Reserva
    {
        // encapsulamento 
        public Livro Livro { get; set; }        //Propriedade q represetna o livro reservado
        public Estudante Estudante { get; set; } // Propriedade q represetna o estudante q reservou o livro
        public Professor Professor { get; set; } // Propriedade q represetna o professor q fez a resreva para o aluno
        public DateTime DataReserva { get; set; } // Dia da reserva

        // Construtor para inicializar uma nova reserva
        public Reserva(Livro livro, Estudante estudante, Professor professor)
        {
            Livro = livro;
            Estudante = estudante;
            Professor = professor;
            DataReserva = DateTime.Now;
        }
    }
}

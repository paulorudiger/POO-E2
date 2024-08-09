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
        public Livro Livro { get; set; }        // Livro reservado
        public Estudante Estudante { get; set; } // Estudante que fez a reserva
        public Professor Professor { get; set; } // Professor que gerenciou a reserva
        public DateTime DataReserva { get; set; } // Data em que a reserva foi feita

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

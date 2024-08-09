using POO_E2.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_E2.Interfaces
{
    // Interface que define os metodos q vao gerenciar a reserva dos livros 
    public interface IManterReserva
    {
        // metodo
        void ReservarLivro(Livro livro, Estudante estudante, Professor professor);
        // metodo
        void CancelarReserva(Livro livro, Estudante estudante);
        // metodo
        void DevolverLivro(Livro livro, Estudante estudante);
    }
}

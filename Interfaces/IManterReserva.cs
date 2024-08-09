using POO_E2.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_E2.Interfaces
{
    // Interface que define os métodos para gerenciar reservas de livros
    public interface IManterReserva
    {
        void ReservarLivro(Livro livro, Estudante estudante, Professor professor);
        void CancelarReserva(Livro livro, Estudante estudante);
        void DevolverLivro(Livro livro, Estudante estudante);
    }
}

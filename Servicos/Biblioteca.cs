using BibliotecaEscola.Servicos;
using POO_E2.Abstracoes;
using POO_E2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace POO_E2.Servicos
{
    // Servicos implementa a lógica da aplicacao
    // Classe que gerencia a biblioteca e as reservas de livros
    public class Biblioteca : IManterReserva
    {
        private List<Livro> livros;        // Lista de livros disponíveis na biblioteca
        private List<Estudante> estudantes; // Lista de estudantes que podem reservar livros
        private List<Reserva> reservas;     // Lista de reservas feitas

        private Log log;            // Instância para registrar logs de operações

        // Construtor para inicializar a biblioteca com dados predefinidos
        public Biblioteca()
        {
            var professor1 = new Professor("Pedro", 123);
            var livro1 = new Livro("Titulo", "Titulo", professor1);
            livros = new List<Livro>();
            livros.Add(livro1);
            var estudante1 = new Estudante("paulo", 456);
            estudantes = new List<Estudante>();
            estudantes.Add(estudante1);
            var reserva1 = new Reserva(livro1, estudante1, professor1);
            reservas = new List<Reserva>();
            reservas.Add(reserva1);
            log = new Log(); // Cria uma instância de RegistroLog para registrar eventos
        }

        // Método para inicializar a biblioteca com dados básicos
        public void Inicializar()
        {
            // Inicialização dos dados
            log.GravarLog("Sistema de biblioteca inicializado.");
        }

        // Implementação do método da interface para reservar um livro para um estudante
        public void ReservarLivro(Livro livro, Estudante estudante, Professor professor)
        {
            Reserva reserva = new Reserva(livro, estudante, professor); // Cria uma nova reserva
            reservas.Add(reserva);                          // Adiciona a reserva à lista de reservas
            Console.WriteLine($"Livro '{livro.Titulo}' reservado por {estudante.Nome} com a ajuda do professor {professor.Nome}."); // Mensagem ao usuário
            log.GravarLog($"Reserva: Livro '{livro.Titulo}' reservado por {estudante.Nome} com o professor {professor.Nome}."); // Registro no log
        }

        // Implementação do método da interface para cancelar uma reserva
        public void CancelarReserva(Livro livro, Estudante estudante)
        {
            Reserva reservaParaRemover = reservas.Find(r => r.Livro == livro && r.Estudante == estudante);
            if (reservaParaRemover != null)
            {
                reservas.Remove(reservaParaRemover); // Remove a reserva da lista
                Console.WriteLine($"Reserva de '{livro.Titulo}' por {estudante.Nome} cancelada."); // Mensagem ao usuário
                log.GravarLog($"Reserva cancelada: Livro '{livro.Titulo}' por {estudante.Nome}."); // Registro no log
            }
            else
            {
                Console.WriteLine("Reserva não encontrada."); // Mensagem se a reserva não for encontrada
                log.GravarLog($"Tentativa de cancelar reserva não encontrada: Livro '{livro.Titulo}' por {estudante.Nome}."); // Registro no log
            }
        }

        // Implementação do método da interface para devolver um livro
        public void DevolverLivro(Livro livro, Estudante estudante)
        {
            // A lógica de devolução pode variar; por exemplo, você pode atualizar o status da reserva ou removê-la
            Console.WriteLine($"Livro '{livro.Titulo}' devolvido por {estudante.Nome}."); // Mensagem ao usuário
            log.GravarLog($"Devolução: Livro '{livro.Titulo}' devolvido por {estudante.Nome}."); // Registro no log
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_E2.Abstracoes
{
    // Classe que representa um estudante da escola
    public class Estudante
    {
        public string Nome { get; set; }   // Propriedade 
        public int Matricula { get; set; } // Propriedade 

        // Construtor para inicializar um novo estudante
        public Estudante(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }
}

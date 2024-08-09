// See https://aka.ms/new-console-template for more information
using POO_E2.Abstracoes;
using POO_E2.Servicos;

Console.WriteLine("Hello, World!");

// Inicializa a biblioteca
Biblioteca biblioteca = new Biblioteca();
biblioteca.Inicializar();

// Criação de exemplos
Professor professor = new Professor("João Silva", 123); // Adiciona matrícula ao professor
Estudante estudante = new Estudante("Ana Souza", 456);
Livro livro = new Livro("Aprendizado C#", "Pedro Oliveira", professor);

// Exibe informações iniciais
Console.WriteLine("Bem-vindo ao Sistema de Biblioteca Escolar!");
Console.WriteLine($"Professor: {professor.Nome}, Matrícula: {professor.Matricula}");
Console.WriteLine($"Estudante: {estudante.Nome}, Matrícula: {estudante.Matricula}");
Console.WriteLine($"Livro: {livro.Titulo}, Autor: {livro.Autor}, Professor Responsável: {livro.Professor.Nome}");
Console.WriteLine();

// Reservar um livro
Console.WriteLine("Realizando a reserva do livro...");
biblioteca.ReservarLivro(livro, estudante, professor);
Console.WriteLine();

// Cancelar uma reserva
Console.WriteLine("Cancelando a reserva do livro...");
biblioteca.CancelarReserva(livro, estudante);
Console.WriteLine();

// Devolver um livro
Console.WriteLine("Devolvendo o livro...");
biblioteca.DevolverLivro(livro, estudante);
Console.WriteLine();

// Mensagem final
Console.WriteLine("Operações realizadas com sucesso!");

using System.ComponentModel.Design;

var livros = new List<string>(); // Lista para armazenar os títulos dos livros

while (true)
{
    // Exibe o menu principal para o usuário
    Console.WriteLine("---MENU PRINCIPAL ---");
    Console.WriteLine("1- Cadastrar livro");
    Console.WriteLine("2- Listar Livro");
    Console.WriteLine("3- Remover Livro");
    Console.WriteLine("0- Sair");

    var opcao = Console.ReadLine(); // Lê a opção escolhida pelo usuário

    switch (opcao)
    {
        case "1":
            // Solicita o título do livro ao usuário
            Console.Write("Digite o título do livro: ");
            var nomeLivro = Console.ReadLine();
            livros.Add(nomeLivro); // Adiciona o livro à lista
            Console.WriteLine("Livro cadastrado com sucesso");
            break;
        case "2":
            // Lista todos os livros cadastrados
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }
            break;
        case "3":
            // Solicita o nome do livro a ser removido
            Console.WriteLine("Digite o nome do livro: ");
            var livroRemover = Console.ReadLine();
            var sucesso = livros.Remove(livroRemover); // Remove o livro da lista
            if (sucesso)
            {
                Console.WriteLine("Livro removido com sucesso");
            }
            else
            {
                Console.WriteLine("Livro não encontrado");
            }
            break;
        case "0":
            // Encerra a aplicação
            Console.WriteLine("Encerrando a aplicação...");
            return;
        default:
            // Mensagem para opção inválida
            Console.WriteLine("Opção Inválida");
            break;
    }
}

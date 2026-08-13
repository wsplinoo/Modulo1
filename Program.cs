string nomeProfissional = "João Programador";
string nomeContato = "joao.prog@exemplo.com";
int anoNascimento = 2007;
bool estaDisponivel = false;
int idade = DateTime.Now.Year - anoNascimento;

if (estaDisponivel == true)
{
    Console.WriteLine("--- Cartão de Visitas Digital ---");
    Console.WriteLine($"Nome: {nomeProfissional}");
    Console.WriteLine($"Email: {nomeContato}");
    Console.WriteLine($"Idade: {idade}");
    Console.WriteLine("Disponível.");
}
else
{
    Console.WriteLine("--- Cartão de Visitas Digital ---");
    Console.WriteLine($"Nome: {nomeProfissional}");
    Console.WriteLine($"Email: {nomeContato}");
    Console.WriteLine($"Idade: {idade}");
    Console.WriteLine("Não disponível.");
}
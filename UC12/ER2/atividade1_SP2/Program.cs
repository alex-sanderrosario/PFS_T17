
//using System.Xml.Serialization;
using atividade1_SP2.Classes;

//Console.WriteLine(novaPf.ValidarDataNascimento("01/01/2000"));
/*
Console.WriteLine($"Nome: {novaPf.nome}");
Console.WriteLine($"Data de Nascimento: {novaPf.dataNascimento}");
Console.WriteLine($"Cpf: {novaPf.cpf}");
Console.WriteLine($"Rendimento: {novaPf.rendimento}");
Console.WriteLine($"Logradouro: {novaPf.endereco.logradouro}");
Console.WriteLine($"Numero: {novaPf.endereco.numero}");
Console.WriteLine($"Complemento: {novaPf.endereco.complemento}");
Console.WriteLine($"Endereço Comercial? {novaPf.endereco.endComercial}");
Console.WriteLine($"Maior de Idade? {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}");
*/








//Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0001-08")}");
//Console.WriteLine($"{metodoPj.ValidarCnpj("00000000000100")}");
Console.WriteLine(@$"
===============================================================

|               Bem vindo ao Sistema de Cadastro de            |
|                  Pessoas Físicas e Juridicas                 |

================================================================


");
    BarraCarregamento("Carregando", 300);

     string? opcao;

     do
     {

    Console.Clear();

    Console.WriteLine(@$"
==================================================================
|                   Escolha uma das opções abaixo                |
|----------------------------------------------------------------|
|                        1 - Pessoa Física                       |
|                        2 - Pessoa Jurídica                     |
|                                                                |
|                        0 - Sair                                |
==================================================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
  case "1":
    PessoaFisica novaPf = new PessoaFisica();
    Endereco novoEnd = new Endereco();
    PessoaFisica metodoPf = new PessoaFisica();

    novaPf.nome = "Alex";
    novaPf.dataNascimento = "11/05/1971";
    novaPf.cpf = "181229662";
    novaPf.rendimento = 15000;

    novoEnd.logradouro = "Rua Vila Maria";
    novoEnd.numero = 216;
    novoEnd.complemento = "não possui";
    novoEnd.endComercial = false;

    novaPf.endereco = novoEnd;

    Console.Clear();

    Console.WriteLine(@$"
    Nome: {novaPf.nome}
    Data de Nascimento: {novaPf.dataNascimento}
    Cpf: {novaPf.cpf}
    Rendimento: {(novaPf.rendimento).ToString("C")}
    Logradouro: {novaPf.endereco.logradouro}
    Numero: {novaPf.endereco.numero}
    Complemento: {novaPf.endereco.complemento}
    Endereço Comercial? {((bool)novaPf.endereco.endComercial? "Sim": "Não")}
    Maior de idade? {(metodoPf.ValidarDataNascimento(novaPf.dataNascimento)? "Sim": "Não" )}
    Taxa de Imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")}
    ");

    Console.WriteLine($"Aperte 'Enter' para continuar...");
    Console.ReadLine();

    break;

    case "2":
    PessoaJuridica metodoPj = new PessoaJuridica();
    PessoaJuridica novaPj = new PessoaJuridica();
    Endereco novoEndPj = new Endereco();

    novaPj.nome = "Nome PJ";
    novaPj.razaoSocial = "Razao Social PJ";
    novaPj.cnpj = "18.023.321/0001-53";
    novaPj.rendimento = 30000;

    novoEndPj.logradouro = "Rua Vila Maria";
    novoEndPj.numero = 216;
    novoEndPj.complemento = "não possui";
    novoEndPj.endComercial = true;

    novaPj.endereco = novoEndPj;

    Console.Clear();

    Console.WriteLine(@$"
    Nome: {novaPj.nome}
    Razao Social: {novaPj.razaoSocial}
    Cnpj: {novaPj.cnpj}
    Rendimento: {(novaPj.rendimento).ToString("C")}
    Logradouro: {novaPj.endereco.logradouro}
    Numero: {novaPj.endereco.numero}
    Complemento: {novaPj.endereco.complemento}
    Endereço Comercial? {((bool)novaPj.endereco.endComercial? "Sim": "Não")}
    CNPJ é valido? {(metodoPj.ValidarCnpj(novaPj.cnpj)? "Sim": "Não")}
    Taxa de Imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
    ");
    Console.WriteLine($"Aperte 'Enter' para continuar...");
    Console.ReadLine();
    break;

    case "0":
  
        BarraCarregamento("Finalizando", 300);
        break;
    default:
        Console.Clear();
        Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
        Thread.Sleep(2000);
        break;
    }

    } while (opcao != "0");

        static void BarraCarregamento(string texto, int tempo)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write($"{texto}");

            for (var contador = 0; contador < 27; contador++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }
            Console.ResetColor();
        }
    
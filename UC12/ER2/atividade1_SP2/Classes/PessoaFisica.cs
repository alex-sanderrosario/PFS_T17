using atividade1_SP2.Interfaces;

namespace atividade1_SP2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        public string ?cpf { get; set; }

        public string ?dataNascimento { get; set; }

        public string caminho {get; private set; } = "Database/PessoaFisica.csv";

    
        public override float PagarImposto(float rendimento)
        {
           /*
             Rendimento até  1500 isento
             Rendimento de 1501 até 3500 vai pagar 2%
             Rendimento de 3501 até 6000 vai pagar 3,5%
             Rendimento acima de 6000 vai pagar 5%

             && = and
             || = or
             !  = Not

           */ 
            
            if (rendimento <= 1500)
            {
                 return 0;
            }
            else if(rendimento > 1550 && rendimento <= 3500)
            {
                return (rendimento / 100) * 2;
            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                return (rendimento / 100) * 3.5f;
            }
            else
            {
                return (rendimento / 100) * 5;
            }


        }

       /* public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365; //totalDays converte para dias
           // Console.WriteLine($"{anos}");
            if(anos >= 18){
                return true;
            }
            return false; // não precisa do else pq caso seja verdadeiro o primeiroreturn conclui a sentença
        }*/

        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            //verificarse a string esta em um formato valido
            if(DateTime.TryParse(dataNasc, out dataConvertida)){//totalDays converte para dias
            //Console.WriteLine($"{dataConvertida}");
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataConvertida).TotalDays / 365; //totalDays converte para dias
             if(anos >= 18){
                return true;
            }
            return false; // não precisa do else pq caso seja verdadeiro o primeiroreturn conclui a sentença

            }
            return false;          
        }

        public void Inserir(PessoaFisica pf)
        {
             VerificarPastaArquivo(caminho);

            string[] pjString = {$"{pf.nome},{pf.cpf},{pf.dataNascimento},{pf.rendimento},{pf.endereco.logradouro},{pf.endereco.numero},{pf.endereco.complemento},{pf.endereco.endComercial}"};

            File.AppendAllLines(caminho, pjString);
        }

        public List<PessoaFisica> Ler()
        {
            VerificarPastaArquivo(caminho);
            List<PessoaFisica> listaPf = new List<PessoaFisica>();
            string[] linhas = File.ReadAllLines(caminho);
            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaFisica cadaPf = new PessoaFisica();
                Endereco cadaEnd = new Endereco();

                cadaPf.nome = atributos[0];
                cadaPf.cpf = atributos[1];
                cadaPf.dataNascimento = atributos[2];
                cadaPf.rendimento = float.Parse(atributos[3]);
                cadaEnd.logradouro = atributos[4];
                cadaEnd.numero = int.Parse(atributos[5]);
                cadaEnd.complemento = atributos[6];
                cadaEnd.endComercial = bool.Parse(atributos[7]);
                cadaPf.endereco = cadaEnd;
                listaPf.Add(cadaPf);
            }
            return listaPf;
        }
   
    }
}
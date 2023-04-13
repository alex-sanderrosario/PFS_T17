using atividade1_SP2.Interfaces;

namespace atividade1_SP2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        public string ?cpf { get; set; }

        public string ?dataNascimento { get; set; }

    
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



   
    }
}
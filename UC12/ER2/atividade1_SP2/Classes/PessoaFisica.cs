using atividade1_SP2.Interfaces;

namespace atividade1_SP2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        public string ?cpf { get; set; }

        public string ?dataNascimento { get; set; }

    
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
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
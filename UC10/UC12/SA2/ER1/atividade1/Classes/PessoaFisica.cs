using atividade1.Interfaces;

namespace atividade1.Classes
{
    public class PessoaFisica : Pessoa, IpessoaFisica
    {
        public string ?cpf { get; set; }
        public DateTime ?dataNascimento { get; set; }
        
        
        
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNascimento(DateTime dataNac)
        {
            throw new NotImplementedException();
        }
    }
}
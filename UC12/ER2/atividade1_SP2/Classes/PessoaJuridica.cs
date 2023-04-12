using atividade1_SP2.Interfaces;
using System.Text.RegularExpressions;

namespace atividade1_SP2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set; }

        public string ?razaoSocial { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            /*
                xx.xxx.xxx/ooo1-xx
                @"\d{2}.\d{3}.\d{3}/\d{0001}-\d{2}"
                xxxxxxxx0001xx
                \d{14}

            */
            if(Regex.IsMatch(cnpj,@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if(cnpj.Substring(11,4) == "0001") //elevai iniciar no caracter
                {
                    return true;
                }
                else if(cnpj.Substring(8,4) == "0001")
                {
                      return true;
                }
                
            }

            return false;
          
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade1.Interfaces
{
    public interface IpessoaFisica
    {
        bool ValidarDataNascimento(DateTime dataNac);
    }
}
using atividade1.Interfaces;

namespace atividade1.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?nome { get; set; }
        public string ?endereco { get; set; }

        public float rendimento { get; set; }
        
        
        
        
        public abstract float PagarImposto(float rendimento);
       
        
    }
}
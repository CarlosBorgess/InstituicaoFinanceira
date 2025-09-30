using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Pode se usar mais de um metodo construtor na classe, desde que seja com parametros diferentes.
namespace ControleContas
{
    public class Conta
    {
        public Conta(long numero)
        {
            this.Numero = numero; 
        }
        public Conta()

        {
            _numero = new Random().Next(1000000, 99999999);
        }

        private long _numero;

        private decimal _saldo;
        public decimal Saldo
        {
            get
            {
                return _saldo;
            }
            private set
            {
                _saldo = value;
            }
        }
               
        public long Numero
        {
            get
            {
                return _numero;
            }
            private set
            {
                _numero = value; 
            }
        
        }   
            
    }
}

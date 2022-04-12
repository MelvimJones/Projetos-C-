

namespace Treino01 {
    class ContaBancaria {
        public int Numero;
        private string Nome;
        public double Saldo;

        

        


       

        public override string ToString() {
            return"Numero: "+ Numero +", Nome: "+ Nome +", Saldo R$ "+ Saldo.ToString("F2");
        }

    }
}

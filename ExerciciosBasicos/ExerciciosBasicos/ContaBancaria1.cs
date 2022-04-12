
using System.Globalization;

namespace ExerciciosBasicos {
    class ContaBancaria1 {
        public int Numero { get; set; }
        private string _nome;
        public double Saldo { get; set; }

        public ContaBancaria1(int numero, string nome, double saldo) {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }

        public ContaBancaria1(int numero, string nome) {
            Numero = numero;
            Nome = nome;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 0) {
                    _nome = value;
                }
            }
        }

        public void Deposito(double valor) {
            Saldo = Saldo + valor;
        }

        public void Saque(double valor) {
            Saldo = (Saldo - valor) - 5.00;
        }

        public override string ToString() {
            return "Conta: "
                + Numero
                + ", Nome: "
                + Nome
                + ", Saldo: "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}

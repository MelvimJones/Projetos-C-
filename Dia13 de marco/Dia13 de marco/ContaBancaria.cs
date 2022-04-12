using System;
using System.Collections.Generic;
using System.Text;

namespace Dia13_de_marco {
    class ContaBancaria {

        
        public int Numero { get; private set; }
        public string _nome;
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome, double saldo) {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }

        public ContaBancaria(int numero, string nome) {
            Numero = numero;
            Nome = nome;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 2) {
                    _nome = value;
                }
            }
        }

        public void AdValor(double valor) {
            Saldo += valor;
        }

        public void SaqValor(double valor) {
            Saldo -= valor - 5.00;
        }

        public override string ToString() {
            return " Conta: " + Numero +
                 " Titular: " + Nome +
                " Saldo : $ " + Saldo.ToString("F2");
        }
    }
}
    
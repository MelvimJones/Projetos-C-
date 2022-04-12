

namespace _5marco {
    class Aluno1 {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Media = 60.00;
        public double total() {
            return Nota1 + Nota2 + Nota3;
        }
            public  double Subtração() {
            return Media - total() ;
        }
        public override string ToString() {
            return "nota final é: " + total();
        }

    }
}

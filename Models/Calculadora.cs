namespace projeto.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)    
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)    
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)    
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public void Dividir(int x, int y)    
        {
            Console.WriteLine($"{x} : {y} = {x / y}");
        }

        public void Potencia(int x, int y)    
        {
            //A classe Math já possui o método de potência e abstrai por si própria:
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {potencia}");
        }

        public void Seno(double angulo)    
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}"); //Utilização de 4 números após a vírgula.
        }

        public void Cosseno(double angulo)    
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo}° = {Math.Round(cosseno, 4)}");
        }

        public void Tangente(double angulo)    
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)    
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}
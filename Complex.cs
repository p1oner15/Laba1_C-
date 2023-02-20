namespace Lab1
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }
        
        // Сложение
        public void Add(Complex x)
        {
            Real += x.Real;
            Imag += x.Imag;
        }
        
        // Вычитаение
        public void Substract(Complex x)
        {
            Real -= x.Real;
            Imag -= x.Imag;
        }
        
        // Умножение 
        public void Multiply(Complex x)
        {

            Real *= x.Real;
            Imag *= x.Imag;
        }
        
        // Деление 
        public void Divide(Complex x)
        {
            Real /= x.Real;
            Imag /= x.Imag;
        }
    }
}

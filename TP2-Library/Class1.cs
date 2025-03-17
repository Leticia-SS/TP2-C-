namespace TP2_Library
{
    public class Library
    {
        public void ConversaoTemperatura(int C)
        {
            int farenheit = C * 9 / 5 + 32;
            double kelvin = C + 273.15;

            Console.WriteLine($"Kelvin: {kelvin} K \nFarenheit: {farenheit} °F");
        }

        public void CalculoIMC(double altura, double peso)
        {
            double IMC = peso / (altura * altura);
            
            switch(IMC)
            {
                case < 18.5:
                    Console.WriteLine($"IMC: {IMC} / Abaixo do Peso");
                    break;
                case < 24.9:
                    Console.WriteLine($"IMC: {IMC} / Peso Normal");
                    break;
                case < 29.9:
                    Console.WriteLine($"IMC: {IMC} / Excesso de Peso");
                    break;
                case < 34.9:
                    Console.WriteLine($"IMC: {IMC} / Obesidade classe I");
                    break;
                case < 39.9:
                    Console.WriteLine($"IMC: {IMC} / Obesidade classe II");
                    break;
                default:
                    Console.WriteLine($"IMC: {IMC} / Obesidade Mórbida");
                    break;
            }
        }

        public void ParImpar(int num)
        {
            if ( num % 2 == 0 )
            {
                Console.WriteLine($"Número {num} = Par");
            } else
            {
                Console.WriteLine($"Número {num} = Ímpar");
            }
        }

        public void ClassificarNota(int nota)
        {
            if ( nota >= 9)
            {
                Console.WriteLine($"Nota: {nota}\nExcelente!");
            } else if( nota >= 7)
            {
                Console.WriteLine($"Nota: {nota}\nBom!");
            } else if (nota >= 5)
            {
                Console.WriteLine($"Nota: {nota}\nRegular!");
            } else
            {
                Console.WriteLine($"Nota: {nota}\nInsuficiente!");
            }
        }

        public void CalculoSalarioLiquido(double salario)
        {
            switch(salario)
            {
                case < 2259.2:
                    Console.WriteLine($"Isento de imposto, Líquido: R${salario}");
                    break;
                case <= 2826.65:
                    salario -= salario * 0.075;
                    Console.WriteLine($"Imposto de 7,5%, Líquido: R${salario}");
                    break;
                case <= 3751.05:
                    salario -= salario * 0.15;
                    Console.WriteLine($"Imposto de 15%, Líquido: R${salario}");
                    break;
                case < 4664.68:
                    salario -= salario * 0.225;
                    Console.WriteLine($"Imposto de 22,5%, Líquido: R${salario}");
                    break;
                default:
                    salario -= salario * 0.275;
                    Console.WriteLine($"Imposto de 27,5%, Líquido: R${salario}");
                    break;
            }
        }
    }
}

using System;
/// < summary >
/// Evaluación: Primer Laboratorio Evaluado.
/// Fecha: Lunes 04 de abril de 2022.
/// Autor: Erick Osvaldo Romero Meléndez.
/// Carnet: RM22057.
/// GL: 02.
/// Instructor: Lic. Jorge Mauricio Coto.
/// </summary>
namespace GL02EVA1_VisualStudio2019_RM22057
{
    class Program
    {
        const double ISR1 = 0.05;
        const double ISR2 = 0.10;
        const double ISR3 = 0.15;

        const double SEG1 = 15;
        const double SEG2 = 30;
        const double SEG3 = 45; 

        static void Main(string[] args)
        {
            //Identificación del Programa en Pantalla
            Console.Title = "Primer Laboratorio Evaluado-RM22057 GL02";
            Console.WriteLine("Programa para realizar pago de ISR a empleados");

            //Declaración de Variables
            double salario;
            double seguro, renta, pagoEmpleado;

            //Entrada de Datos
            Console.WriteLine("\nIngrese su salario: ");
            salario = double.Parse(Console.ReadLine());

            //Proceso de Datos
            if (salario >= 220)
            {
                renta = CalcularRenta(salario);
                seguro = CalcularCuota(salario);
                pagoEmpleado = CalcularPago(renta, seguro, salario);

                //Salida de Datos
                Console.Write("\nSu pago total es de: {0:c} ", pagoEmpleado);
                Console.Write("\nSu total de renta es de: {0:c}", renta);
                Console.Write("\nCuota de Seguro: {0:c}", seguro);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Oh no, ha ingresado datos erroneos");
            }
          
        }
        //Método para calcular la renta del empleado
        public static double CalcularRenta(double salario)
        {
            double isr=0;
            if(salario>=220 && salario <=450)
            {
                isr = (salario * ISR1);
            }
            if(salario >450 && salario <=750)
            {
                isr = (salario * ISR2);
            }
            if(salario>750)
            {
                isr = (salario * ISR3);
            }
            return isr;
        } 


        //Método para calcular la cuota de seguro del empleado
        public static double CalcularCuota(double salario)
        {
            double cuota=0;
            if (salario >= 220 && salario <= 450)
            {
                cuota = SEG1;
            }
            else if (salario > 450 && salario <= 750)
            {
                cuota = SEG2;
            }
            else if (salario > 750)
            {
                cuota = SEG3;
            }
            return cuota;
        }
        //Método para calcular el pago total del empleado
        public static double CalcularPago(double renta, double seguro, double salario)
        {
            double pago;
            pago = salario - renta - seguro;

            return pago;
        }     
    }
}

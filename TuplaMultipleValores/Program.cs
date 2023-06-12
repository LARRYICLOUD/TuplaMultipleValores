using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplaMultipleValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOLA MUNDO SOY UN PROGRAMADOR  EN C# Y EXPERTO EN REDES EXCELENTE");
            //variables
            int opcion;
            decimal r; //almacena el valor devuelto de restar
            decimal num1Ar, num2Ar; //Argumentos para enviar una copia de su valor a los metodos

            //Declaramos una tupla
            (decimal num1, decimal num2, decimal resultado) numeros;



            //mostramos el menu

            do
            {
                Console.WriteLine("1.  Suma");
                Console.WriteLine("2.  Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");


                Console.Write("Escoge una opcion:  ");
                opcion = Convert.ToByte(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));




            switch (opcion)
            {
                case 1:
                    Sumar();
                    break;


                case 2:
                    numeros = Resta(); //asignamos a la tupla "numeros" los 3 valores devuelto por  return

                    //Mostramos el resultado
                    Console.WriteLine("{0}-{1}= {2}",numeros.num1,numeros.num2,numeros.resultado);


                    
                    break;

                case 3:
                    //Pedimos ambos numeros
                    num1Ar = IngresarNumero("ingresar el primer numero:  ");


                    num2Ar = IngresarNumero("Ingresa el segundo numero");
                    //Invocamos al metodo
                    Multiplicacion(num1Ar, num2Ar);
                    break;

                case 4:
                    //Pedimos ambos numeros
                    num1Ar = IngresarNumero("Ingresa el primer numero: ");
                    num2Ar = IngresarNumero("Ingresar el segundo numero: ");

                    //invocamos el metodo
                    r = Division(num1Ar, num2Ar);

                    //Mostramos el resultado con la informacion que contiene "r"
                    Console.WriteLine("El resultado de la division es:  {0}", r);
                    break;




            }

        }//cierre del main
        // [modificador] [tipo] [identificador] [parametros]
        static void Sumar()
        {
            decimal num1, num2, resultado;
            //pedimos el valor de ambos numeros
            Console.Write("Ingresa el primer numero:");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo numero:");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //operacion 
            resultado = num1 + num2;

            Console.WriteLine("{0}+{1}= {2}", num1, num2, resultado);


        }
        // [modificador] {tipo] [identificador] [parametros]
        static (decimal,decimal,decimal) Resta()


        {
            //variables del metodo restar
            decimal num1, num2, resultado;

            //pedimos ambos numeros
            Console.Write("Ingresa el primer numero :  ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //Operacion
            resultado = num1 - num2;
            //devolvemos multiples tipos al autor del llamado
            return (num1, num2, resultado);

        }

        // [modificador] {tipo] [identificador] [parametros]
        static void Multiplicacion(decimal num1Pa, decimal num2Pa)
        {

            //Variables
            decimal resultado;

            //Multiplicacion con los valores que mandaron los argumentos
            resultado = num1Pa * num2Pa;
            //Mostramos el resultado
            Console.WriteLine("{0}*{1}={2}", num1Pa, num2Pa, resultado);
        }
        // [modificador] {tipo] [identificador] [parametros]
        static decimal Division(decimal num1Pa, decimal num2Pa)
        {
            //Variables

            decimal resultado;

            if (num2Pa != 0)
            {

                resultado = num1Pa / num2Pa;
            }
            else
            {
                Console.WriteLine("No es posible dividir entre cero");
                resultado = 0;

            }

            return resultado;
            //division cion con los valores que mandaron los argumentos
            //Resultado



            resultado = num1Pa / num2Pa;
            Console.WriteLine("{0}/{1}={2}", num1Pa, num2Pa, resultado);

        }
        // [modificador] {tipo] [identificador] [parametros]
        static decimal IngresarNumero(string peticion)
        {
            //variable local
            decimal numero;

            //Pedimos el valor segun corresponda
            Console.Write(peticion);
            //Convertimos y asignamos
            numero = Convert.ToDecimal(Console.ReadLine());
            //Devolvemos el valor se tipo decimal
            return numero;

        }

    }
}
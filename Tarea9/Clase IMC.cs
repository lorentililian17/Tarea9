using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9
{
    internal class Clase_IMC
    {
        private const double KG = 2.2046;
        public int edad { get; set; }
        public string nombre { get; set; }
        public int altura { get; set; }
        public char sexo { get; set; }
        public int peso { get; set; }
        public double imc { get; set; }
        String Estado = "";
        Char Opcion = ' ';
        public const string mens = "¡IMC cuida y protege tu salud!";


        public string prueba()
        {


            //Se piden los datos de la persona y se pasan a la clase persona por medio del objeto persona

            Console.WriteLine("Introduzca su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su altura");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su peso");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su sexo");
            sexo = char.Parse(Console.ReadLine());


            //Realizar Calculo

            double pesoKG = this.peso / KG;
            double estaturaMTS = (double)this.altura / 100;
            double altu = (Math.Pow(estaturaMTS, 2));
            imc = pesoKG / altu;


            //Determinar estado de la persona

            if (edad >= 18)
            {

                if (imc < 18.5)
                {
                    Estado = "BAJO DE PESO , DEBERÍAS DE CONSULTAR CON TU MÉDICO";
                }

                if ((imc >= 18.5) && (imc < 25))
                {
                    Estado = "FELICITACIONES TE ENCUENTRAS EN UN PESO NORMAL";
                }

                if ((imc >= 25) && (imc < 30))
                {
                    Estado = "SENTIMOS INFORMARTE QUE TIENES SOBREPESO";
                }
                if ((imc >= 30) && (imc < 40))
                {
                    Estado = "DEBERAS DE CUIDARTE, TE ENCUENTRAS MUY OBESO";
                }
                if (imc >= 40)
                {
                    Estado = "VISITA TU MEDICO MAS CERCANO, TU PESO ES OBESO MORBIDO, PUEDE CAUSARTE DAÑOS A LA SALUD ";

                }//fin de ifs
            }
            else
            {
                if (imc < 14.4)
                {
                    Estado = "Niñ@ Bajo Peso, ";
                }

                if ((imc >= 14.5) && (imc < 17))
                {
                    Estado = "Niñ@ Normal";
                }

                if ((imc >= 18) && (imc < 19))
                {
                    Estado = "Niñ@ sObrepeso";
                }
                if ((imc >= 19.1) && (imc < 40))
                {
                    Estado = "Niñ@ Obeso";
                }
                if (imc >= 40)
                {
                    Estado = "Niñ@ Obeso Morbido";

                }
            }



            Console.WriteLine("Su IMC es de :" + imc);
            Console.WriteLine("Su estado es :" + Estado);



            return mens.ToString();


        }


    }
}
    

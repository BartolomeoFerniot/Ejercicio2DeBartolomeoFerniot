using System;

namespace Ejercicio2DeBartolomeoFerniot
{
    class Program
    {
        static void Main(string[] args)
        {
            Double A, B, C, D, E, radio, coord1, coord2;

            Console.Write("Informe el valor de A: ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe el valor de B: ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe el valor de C: ");
            C = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe el valor de D: ");
            D = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe el valor de E: ");
            E = Convert.ToDouble(Console.ReadLine());


            if(A==0 & B==0)
            {
                Console.WriteLine("Los coeficientes ingresados NO conforman una cónica");
            }
            else
            {
                    if((A!=0 & B==0)||(A==0 & B!=0))
                    {
                    Console.WriteLine("El tipo de cónica con el que se está trabajando en la ecuación es una parábola");
                    }
                    else
                    {
                            if(A!=0 & B!=0 & A==B)
                            {
                            Console.WriteLine("El tipo de cónica con el que se está trabajando en la ecuación es una circunferencia");
                            coord1 = -D/2;
                            coord2 = -E/2;
                            radio = (1/2)*Math.Sqrt(Math.Pow(C,2)+Math.Pow(D,2)-4*E);
                            Console.WriteLine($"El radio de la circunferencia es: {radio}");
                            Console.WriteLine($"Las coordenadas de la circunferencia son: ({coord1},{coord2})");
                            }
                            else
                            { 
                                    if(A!=0 & B!=0 & ((A<0 & B<0) || (A>0 & B>0)) & A!=B)
                                    {
                                    Console.WriteLine("El tipo de cónica con el que se está trabajando en la ecuación es una elipse");
                                    }
                                    else
                                    { 
                                            if(A!=0 & B!=0 & ((A<0 & B>0) || (A>0 & B<0)) & A!=B)
                                            { 
                                            Console.WriteLine("El tipo de cónica con el que se está trabajando en la ecuación es una hipérbola");
                                            }
                                            else
                                            {
                                            Console.WriteLine("Ha sucedido un error");
                                            }
                                    }
                            }
                    }

            }

            Console.ReadLine();

        }
    }
}

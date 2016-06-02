using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {

        struct registro
        {
            public int id;
            public int edad;
            public string name;
            public int sexo;
            
            
        };

        

        static registro[] registros;
        static int cantidadhombres = 0;
        static int cantidadmujeres = 0;
        static int cantidadmenores = 0;
        static int cantidadjovenes = 0;
        static int cantidadadultos = 0;
        static int option = 0;
        static int minimo = 3;
        static int maximo = 10;
        static int i = 0;
        //static string m = "m";
        static void Main()
        {
            registros = new registro[maximo];
            do
            {
                Console.Clear();
                Console.WriteLine("Estudiantes");
                Console.WriteLine("1.\tIngreso de estudiantes\n2.\tModificación de estudiantes\n3.\tBorrado de estudiantes\n4.\tBúsqueda de estudiantes\n5.\tListado de estudiantes\n6.\tInforme clasificación de estudiantes\n7.\tSalir");
                option = int.Parse(Console.ReadLine());


                  switch (option) {
                    case 1:
                        //Ingreso de estudiantes
                        Console.Clear();
                        ingreso();
                        break;


                    case 2:
                        //Modificación de estudiantes
                        Console.Clear();
                        modificacion();
                        break;

                    case 3:
                        //Borrado de estudiantes
                        Console.Clear();
                        borrado();
                        break;

                    case 4:
                        //Búsqueda de estudiantes
                        Console.Clear();
                        busqueda();
                        break;

                    case 5:
                        //Listado de estudiantes
                        Console.Clear();
                        listado();
                        break;

                    case 6:
                        //Informe clasificación de estudiantes
                        Console.Clear();
                        informe();
                        break;

                    case 7:
                        //Salir
                        break;

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione una opción válida..");
                            Console.ReadKey();
                            break;
                        }
                } 


            } while (option != 7);

            }//fin main


        static void ingreso()
        {
            int r = 0;
            while (r != 1 )
            {
                Console.Clear();
                if (i < registros.Length)
                {
                    Console.WriteLine("Ingrese los datos del estudiante");
                    Console.WriteLine("ID");
                    registros[i].id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nombre completo");
                    registros[i].name = Console.ReadLine();
                    Console.WriteLine("Edad");
                    registros[i].edad = int.Parse(Console.ReadLine());
                    if(registros[i].edad < 18)
                    {
                        cantidadmenores = cantidadmenores + 1;
                    }else
                    {
                        if(registros[i].edad > 30)
                        {
                            cantidadadultos = cantidadadultos + 1;
                        }else
                        {
                            cantidadjovenes = cantidadjovenes + 1;
                        }
                    }
                    Console.WriteLine("Sexo \n1-Mujes\n2-Hombre");
                    registros[i].sexo = int.Parse(Console.ReadLine());
                    
                    if(registros[i].sexo==1)
                    {
                        cantidadmujeres = cantidadmujeres + 1;
                    }else
                    {
                        cantidadhombres = cantidadhombres + 1;
                    }
                    

                    if (minimo < i )
                    {
                        Console.WriteLine("Desea agregar mas estudiantes 0-Sí  1-No");
                        r = int.Parse(Console.ReadLine());

                    }

                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de estudiantes lleno..");
                    r = 1;
                    Console.ReadKey();
                }

            }

        }


        static void modificacion()
        {
            Console.WriteLine("Ingrese Registro del Estudiante a modificar");
            int reg = int.Parse(Console.ReadLine());
            Console.WriteLine("ID");
            registros[reg].id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre completo");
            registros[reg].name = Console.ReadLine();
            if (registros[reg].edad < 18)
            {
                cantidadmenores = cantidadmenores - 1;
            }
            else
            {
                if (registros[reg].edad > 30)
                {
                    cantidadadultos = cantidadadultos - 1;
                }
                else
                {
                    cantidadjovenes = cantidadjovenes - 1;
                }
            }
            Console.WriteLine("Edad");
            registros[reg].edad = int.Parse(Console.ReadLine());

            if (registros[reg].edad < 18)
            {
                cantidadmenores = cantidadmenores + 1;
            }
            else
            {
                if (registros[reg].edad > 30)
                {
                    cantidadadultos = cantidadadultos + 1;
                }
                else
                {
                    cantidadjovenes = cantidadjovenes + 1;
                }
            }

            if(registros[reg].sexo == 1)
            {
                cantidadmujeres = cantidadmujeres - 1;
            }
            else
            {
                cantidadhombres = cantidadhombres - 1;
            }
            Console.WriteLine("Sexo \n1-Mujes\n2-Hombre");
            registros[reg].sexo = int.Parse(Console.ReadLine());
            if (registros[reg].sexo == 1)
            {
                cantidadmujeres = cantidadmujeres + 1;
            }
            else
            {
                cantidadhombres = cantidadhombres + 1;
            }

        }

        static void borrado()
        {
            Console.WriteLine("Ingrese el registro del estudiante a borrar");
            int reg = int.Parse(Console.ReadLine());
            registros[reg].id = 0;
            registros[reg].name = "";
            if (registros[reg].edad < 18)
            {
                cantidadmenores = cantidadmenores - 1;
            }
            else
            {
                if (registros[reg].edad > 30)
                {
                    cantidadadultos = cantidadadultos - 1;
                }
                else
                {
                    cantidadjovenes = cantidadjovenes - 1;
                }
            }
            registros[reg].edad = 0;
            if (registros[reg].sexo == 1)
            {
                cantidadmujeres = cantidadmujeres - 1;
            }
            else
            {
                cantidadhombres = cantidadhombres - 1;
            }

        
        registros[reg].sexo = 0;
            if(registros[reg].sexo == 1)
            {
                cantidadmujeres = cantidadmujeres + 1;
            }
            else
            {
                cantidadhombres = cantidadhombres + 1;
            }

        }

        static void busqueda()
        {
            Console.Clear();
            
            Console.WriteLine("============================================");
            Console.WriteLine("\tBusqueda de estudiantes");
            Console.WriteLine("============================================");
            Console.WriteLine("Universidad UH");
            Console.WriteLine("\tDigite el Registro del estudiante");
            int reg = int.Parse(Console.ReadLine());
            Console.WriteLine("Reg\tCódigo\tNombre\t\tSexo\tEdad");
            Console.WriteLine("­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­............................................");
            string sex = "";
            if (registros[reg].sexo == 1)
            {
                sex = "F";
            }
            else
            {
                sex = "M";
            }
            Console.WriteLine(reg + "\t" + registros[reg].id + "\t" + registros[reg].name + "\t" + sex + "\t" + registros[reg].edad);
            Console.WriteLine("============================================");
            Console.WriteLine("Fin de informe");
            Console.ReadKey();

        }

        static void listado()
        {
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("\tListado estudiantil");
            Console.WriteLine("============================================");
            Console.WriteLine("Universidad UH");
            Console.WriteLine("Reg\tCódigo\tNombre\t\tSexo\tEdad");
            Console.WriteLine("­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­­............................................");
            string sex = "";
            for (int x = 0; x < i; x++)
            {
                if(registros[x].sexo == 1)
                {
                    sex = "F";
                }else
                {
                    sex = "M";
                }
                Console.WriteLine(x+"\t"+registros[x].id+"\t"+registros[x].name+"\t"+sex+"\t"+registros[x].edad);

                


            }
            Console.WriteLine("============================================");
            Console.WriteLine("Fin de informe");
            Console.ReadKey();
        }

        static void informe()
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("\tInforme Clasificación estudiantil UH");
            Console.WriteLine("====================================================");
            Console.WriteLine("Clasificación por edad\t||\tClasificación por Género");
            Console.WriteLine("....................................................");
            Console.WriteLine("Menores de edad:" + cantidadmenores+ "\t||\tMujeres:" + cantidadhombres);
            Console.WriteLine("Jóvenes:" + cantidadjovenes + "\t\t||\tHombres:" + cantidadmujeres);
            Console.WriteLine("Adultos:" + cantidadadultos + "\t\t||");
            Console.WriteLine("====================================================");
            Console.WriteLine("Fin de informe");
            Console.ReadKey();
        }


    }
}

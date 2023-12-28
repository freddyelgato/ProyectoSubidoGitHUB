using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_AdivinaElNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroAleatorio=0;
            Console.WriteLine("JUEGO DE ADIVINAR EL NUMERO");
            numeroAleatorio = generarNumero(numeroAleatorio);
            Console.WriteLine("Su numero Aleatorio es: "+numeroAleatorio);
            numeroCerca(numeroAleatorio);
        }


        public static void numeroCerca(int numeroAleatorio)
        {
            int intentos = 0;
            Console.Write("Intenta adivinar el número secreto entre 1 y 100: ");
            while (true)
                {
                    int numeroIngresado=0;
                    bool esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);

                    if (!esNumero || numeroIngresado < 1 || numeroIngresado > 100)
                    {
                        Console.WriteLine("Por favor, ingresa un número válido entre 1 y 100.");
                        continue;
                    }

                    intentos++;

                    int resta = Math.Abs(numeroAleatorio - numeroIngresado); // Calcula la diferencia absoluta entre los números

                    if (resta == 0)
                    {
                        Console.WriteLine("¡Has acertado!");
                        break;
                    }
                    MostrarCercaLejos(resta);
                    
                }
                Console.WriteLine($"¡Lo lograste en {intentos} intentos!");
            Console.WriteLine("FELICITACIONES!!!");
            Felicitaciones();
        }

        public static int generarNumero(int numeroAleatorio)
        {
            Random random = new Random();
            numeroAleatorio = random.Next(1,100);
            return numeroAleatorio;
        }

        public static void MostrarCercaLejos(int resta)
        {
            
            if (resta <= 5)
            {
                Console.WriteLine("Estás muy cerca.");
                Console.WriteLine("Vuelva a Ingresar.... ");
            }
            else if (resta > 5 && resta <= 10)
            {
                Console.WriteLine("Tibio: Sugiere que estás cerca pero aún no lo has acertado.");
                Console.WriteLine("Vuelva a Ingresar.... ");
            }
            else if (resta > 10 && resta <= 20)
            {
                Console.WriteLine("Frío: Indica que estás lejos del número correcto.");
                Console.WriteLine("Vuelva a Ingresar.... ");
            }
            else if (resta > 20 && resta <= 30)
            {
                Console.WriteLine("Congelado: Muestra que estás muy lejos del número correcto.");
                Console.WriteLine("Vuelva a Ingresar.... ");
            }
            else if (resta > 30 && resta <= 40)
            {
                Console.WriteLine("Casi allí: Sugiere que estás muy cerca de acertar.");
                Console.WriteLine("Vuelva a Ingresar.... ");
            }
            else if (resta > 40 && resta <= 50)
            {
                Console.WriteLine("Demasiado lejos: Indica que estás muy alejado del número correcto.");
                Console.WriteLine("Vuelva a Ingresar.... ");
            }
            else if (resta > 50 && resta <= 60)
            {
                Console.WriteLine("A punto: Sugiere que estás a punto de acertar.");
                Console.WriteLine("Vuelva a Ingresar.... ");
            }
            else if (resta > 60 && resta <= 70)
            {
                Console.WriteLine("Fuera de rumbo: Indica que estás en la dirección equivocada.");
                Console.WriteLine("Vuelva a Ingresar.... ");
            }
            else if (resta > 70 && resta <= 80)
            {
                Console.WriteLine("Acércate más: Sugiere que estás cerca pero aún no has acertado.");
                Console.WriteLine("Vuelva a Ingresar.... ");
            }
            else
            {
                Console.WriteLine("Más lejos aún: Indica que necesitas moverte en la dirección opuesta.");
                Console.WriteLine("Vuelva a Ingresar.... ");
            }
        }


        public static void Felicitaciones()
        {
            Console.WriteLine("              .@.                                    .");
            Console.WriteLine("              @m@,.                                 .@");
            Console.WriteLine("             .@m%nm@,.                            .@m@");
            Console.WriteLine("            .@nvv%vnmm@,.                      .@mn%n@");
            Console.WriteLine("           .@mnvvv%vvnnmm@,.                .@mmnv%vn@,");
            Console.WriteLine("          @mmnnvvv%vvvvvnnmm@,.        .@mmnnvvv%vvnm@");
            Console.WriteLine("          @mmnnvvvvv%vvvvvvnnmm@, ;;;@mmnnvvvvv%vvvnm@,");
            Console.WriteLine("          `@mmnnvvvvvv%vvvvvnnmmm;;@mmnnvvvvvv%vvvvnmm@");
            Console.WriteLine("           `@mmmnnvvvvvv%vvvnnmmm;%mmnnvvvvvv%vvvvnnmm@");
            Console.WriteLine("             `@m%v%v%v%v%v;%;%;%;%;%;%;%%%vv%vvvvnnnmm@");
            Console.WriteLine("             .,mm@@@@@mm%;;@@m@m@@m@@m@mm;;%%vvvnnnmm@;@,.");
            Console.WriteLine("          .,@mmmmmmvv%%;;@@vmvvvvvvvvvmvm@@;;%%vvnnm@;%mmm@,");
            Console.WriteLine("       .,@mmnnvvvvv%%;;@@vvvvv%%%%%%%vvvvmm@@;;%%mm@;%%nnnnm@,");
            Console.WriteLine("    .,@mnnvv%v%v%v%%;;@mmvvvv%%;*;*;%%vvvvmmm@;;%m;%%v%v%v%vmm@,.");
            Console.WriteLine(",  @mvv%v%v%v%v%v%v%;;@@vvvv%%;*;*;*;%%vvvvm@@;;m%%%v%v%v%v%v%vnnm@,");
            Console.WriteLine("`    `@mnnvv%v%v%v%%;;@mvvvvv%%;;*;;%%vvvmmmm@;;%m;%%v%v%v%vmm@,''");
            Console.WriteLine("      `@mmnnvvvvv%%%;;@@mvvvv%%%%%%%vvvvmmm@@;;%%mm@;%%nnnnm@'");
            Console.WriteLine("       `@mmmmmmvv%%;;@@mvvvvvvvvvvmmm@@;;%%mmnmm@;%mmm@'");
            Console.WriteLine("          `mm@@@@@mm%;;@m@@m@m@m@@m@@;;%%vvvvvnmm@;@'");
            Console.WriteLine("         ,@m%v%v%v%v%v;%;%;%;%;%;%;%;%vv%vvvvvnnmm@");
            Console.WriteLine("       .@mmnnvvvvvvv%vvvvnnmm%mmnnvvvvvvv%vvvvnnmm@");
            Console.WriteLine("      .@mmnnvvvvvv%vvvvvvnnmm'`@mmnnvvvvvv%vvvnnmm@");
            Console.WriteLine("      @mmnnvvvvvv%vvvvvvnnmm@':%::`@mmnnvvvv%vvvnm@");
            Console.WriteLine("      @mmnnvvvvv%vvvvvnnmm@'`:::%%:::'`@mmnnvv%vvmm@");
            Console.WriteLine("      `@mnvvv%vvnnmm@'     `:;%%;:'     `@mvv%vm@'");
            Console.WriteLine("       `@mnv%vnnm@'          `;%;'         `@n%n@'");
            Console.WriteLine("        `@m%mm@'              ;%;.           `@m@'");
            Console.WriteLine("         @m@'                 `;%;             `@'");
            Console.WriteLine("         `@'                   ;%;.             '");
            Console.WriteLine("          `                    ;%;                 TE HAS GANADO UNA FLOR MORADA");
            Console.WriteLine("          `                    ;%;                 ");
            Console.WriteLine("          `                    ;%;                 ");

        }
    }
}

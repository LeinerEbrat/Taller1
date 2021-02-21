using System;

namespace Ejercicio3
{
    class Program
    {
        static string nombre = " ";
        static string numero = " ";
        static string claveCuenta = " ";
        static decimal SaldoApertura = 0;
        static decimal SaldoTotal = 0;

        static void Main(string[] args)
        {
            int op = 0;
            char op2 = ' ', op3 = 's';

            Capturar();

            do
            {
                do
                {
                    Console.WriteLine("------------ Opciones ------------");
                    Console.WriteLine("1. Consignar");
                    Console.WriteLine("2. Retirar");
                    Console.WriteLine("3. Consultar");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("Digite el numero de la opcion que desea realizar: ");
                    op = Int32.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Esta Seguro que Desea Realizar una Consignacion?");
                            Console.WriteLine("Digite (S) para SI o (N) para NO");
                            op3 = Char.Parse(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Esta Seguro que Desea Realizar un Retiro?");
                            Console.WriteLine("Digite (S) para SI o (N) para NO");
                            op3 = Char.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Esta Seguro que Desea Consulta Su Saldo?");
                            Console.WriteLine("Digite (S) para SI o (N) para NO");
                            op3 = Char.Parse(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Esta Seguro que Desea Salir?");
                            Console.WriteLine("Digite (S) para SI o (N) para NO");
                            op3 = Char.Parse(Console.ReadLine());
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("!ERROR¡ OPCION INCORRECTA");
                            break;
                    }

                } while ((op3 == 'n' || op3 == 'N') && op != 4);
                

                switch (op)
                {
                    case 1: Consignaciones();
                        break;
                    case 2: Retiros();
                        break;
                    case 3: Consulta();
                        break;
                    default : Console.WriteLine("Proceso Terminado Correctamente");
                        break;
                }

                Console.WriteLine("Desea Realizar Otra Opcion? [ S / N ]");
                op2 = Char.Parse(Console.ReadLine());
                Console.Clear();
            } while ( op2 == 's' || op2 == 'S' );
        }

        static void Capturar()
        {
            Console.WriteLine("-------------- DATOS DEL CLIENTE ------------");
            Console.Write("Digite su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Digite Numero de la Cuenta: ");
            numero = Console.ReadLine();
            Console.Write("Digite Su Clave Transaccional: ");
            claveCuenta = Console.ReadLine();
            Console.Write("Digite El Saldo de Apertura: ");
            SaldoApertura = Decimal.Parse(Console.ReadLine());
            Console.Clear();
            SaldoTotal = SaldoApertura;
        }

        static void Retiros()
        {
            decimal monto = 0;
            string clave = " ";
            char validar = 'n';

            Console.WriteLine("------------- RETIROS -----------");
            Console.Write("Digite El Monto a Retirar: ");
            monto = Decimal.Parse(Console.ReadLine());
            Console.Write("Digite Su Clave: ");
            Console.WriteLine("Si Desea Salir Digite (S)");
            clave = Console.ReadLine();
            if (clave == "S")
            {
                Console.WriteLine("Proceso Terminado Correctamente");
            }
            else
            {
                if (!clave.Equals(claveCuenta) && (clave != "s" || clave != "S"))
                {
                    Console.WriteLine("!CONTRASEÑA INCORRECTA¡ RECTIFIQUE");
                    while (validar == 'n')
                    {
                        Console.Write("\nDigite Su Clave: ");
                        Console.WriteLine("Si Desea Salir Digite (S)");
                        clave = Console.ReadLine();

                        if (clave.Equals(claveCuenta))
                        {
                            validar = 's';
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("!CONTRASEÑA INCORRECTA¡ RECTIFIQUE");
                        }
                    }
                }
            }

            if (validar == 's')
            {
                validar = 'n';
                if (monto > SaldoTotal)
                {
                    Console.WriteLine("!SALDO INSUFICIENTE¡ RECTIFIQUE");

                    while (validar == 'n')
                    {
                        Console.Write("Digite El Monto a Retirar: ");
                        Console.WriteLine("Si Desea Salir Digite (0)");
                        monto = Decimal.Parse(Console.ReadLine());

                        if (monto == 0)
                        {
                            validar = 's';
                            Console.WriteLine("Proceso Terminado Correctamente");
                        }
                        else
                        {
                            if (monto < SaldoTotal)
                            {
                                SaldoTotal -= monto;
                                validar = 's';
                                Console.WriteLine("!RETIRO REALIZADO CORRECTAMENTE¡");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("!SALDO INSUFICIENTE¡ RECTIFIQUE");
                            }
                        }
                        
                    }
                }
            }

            Console.Write("\nPresione Una Tecla Para Continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Consignaciones()
        {
            decimal consignacion = 0;
            string clave = " ";
            char validar = 'n';
            Console.WriteLine("--------------- CONSIGNACION ----------------");
            Console.Write("Digite el Monto a Consignar: ");
            consignacion = Decimal.Parse(Console.ReadLine());
            while (validar == 'n')
            {
                Console.WriteLine("Digite Su Clave Transaccional");
                Console.WriteLine("Si no desea Digitar su Clave y Desea Salir Digite (S)");
                clave = Console.ReadLine();

                if (clave == "S")
                {
                    validar = 's';
                }
                else
                {
                    if (clave.Equals(claveCuenta))
                    {
                        validar = 's';
                        SaldoTotal += consignacion;
                        Console.WriteLine("!CONSIGNACION REALIZADA CON EXITO¡");
                    }
                    else
                    {
                        validar = 'n';
                        Console.Clear();
                        Console.WriteLine("!CLAVE INCORRECTA¡ RECTIFIQUE");
                    }
                }
            }

            Console.Write("\nPresione Una Tecla Para Continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Consulta()
        {
            string clave = " ";
            char validar = 'n';
            while (validar == 'n')
            {
                Console.WriteLine("------------ Consulta -------------");
                Console.Write("Digite Su Clave: ");
                clave = Console.ReadLine();

                if (clave.Equals(claveCuenta))
                {
                    Console.WriteLine("-------------- INFORMACION DE LA CUENTA --------------");
                    Console.WriteLine($"Nombre:           {nombre}");
                    Console.WriteLine($"Numero De Cuenta: {numero}");
                    Console.WriteLine($"Saldo:            {SaldoTotal}");
                    validar = 's';
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("!CLAVE INCORRECTA¡ RECTIFIQUE");
                    validar = 'n';
                }
            }

            Console.Write("\nPresione Una Tecla Para Continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

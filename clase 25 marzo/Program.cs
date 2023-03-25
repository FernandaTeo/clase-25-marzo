
using System;

void adivinar()
{
    const int oportunidades = 4;
    int NumeroCPU, NumeroUsuario;
    byte Intentos, BanderaControl;
    string linea;
    //Generar numeros del 1 al 20 unicamente
    Random ran = new Random();
    //do
    //{
        NumeroCPU = Convert.ToInt32(ran.Next(0,20));
       // Console.WriteLine(NumeroCPU);
    //} while (!(((NumeroCPU >= 1) & (NumeroCPU) <= 20)));

    //proceso
    Intentos = 1;
    BanderaControl = 0;

    do
    {
        Console.WriteLine("Estoy pensando en un numero, cual sera");
        linea = Console.ReadLine();
        NumeroUsuario = Convert.ToInt32(linea);

        if (NumeroCPU == NumeroUsuario)
        {
            Console.WriteLine("Adivinaste!!!");
            BanderaControl = 1;
        }

        
            if ((NumeroUsuario > NumeroCPU))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }
            Intentos++;

    } while (((Intentos <= oportunidades) & (BanderaControl == 0))) ;
        if (BanderaControl == 0) ;
        {
            Console.WriteLine("El Numero fue" + NumeroCPU);
        }
        Console.ReadLine();
}
adivinar();
void mayor_menor()
 {
            int numero = 0;
            int mayor = 0;
            int menor = 0;
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                numero = random.Next(10);
                Console.WriteLine(numero);
                if (numero > mayor)
                {
                    mayor = numero;

                }

            }
    Console.WriteLine("El mayor es =" + mayor);
    Console.WriteLine("El menor es =" + menor);

}


nulo ejemploarreglo()
{
    int rifa, rifa1;
    int[] numero = new int[7];

    int suma = 0;
   ejercicio de progra doble;
    numero[0] = 45;
    numero[1] = 50;
    numero[2] = 68;
    numero[3] = 70;
    numero[4] = 86;
    numero[5] = 92;
    numero[6] = 69;
    int elementos = 10;
    cadena[] nombres = nueva cadena[elementos];
    nombres[0] = "Maria";
    nombres[1] = "Juan";
    nombres[2] = "Pedro";
    nombres[3] = "Luis";
    nombres[4] = "Angel";
    nombres[5] = "Vanessa";
    nombres[6] = "Aaron";
    nombres[7] = "Fernada";
    nombres[8] = "Elisa";
    nombres[9] = "Ana";
    nombres[10] = "Fernando";

    Random corrió = new Random();
    rifa = Convertir.ToInt32(corrió.Siguiente(0, 10));
    Aleatorio ran1 = nuevo  Aleatorio();
    rifa1 = Convertir.ToInt32(ran1.Siguiente(0, 10));

    si(rifa >= 0 & rifa <= 9)
    {
        consola _ WriteLine(" El ganador del primer premio esta en la posicion: " + nombres[rifa]);
    }
    si(rifa1 != rifa)
    {
        consola _ WriteLine(" El ganador del segundo premio esta en la posicion: " + nombres[rifa1]);
    }

    // para (int i = 0; i < elementos; i++)
    // {

    // suma = suma + numero[i];

    // Consola.WriteLine(nombres[i]);
    // }
    // baile = suma / elementos;

    // Console.WriteLine("Sumatoria: "+ prom);

}
ejemploarreglo();







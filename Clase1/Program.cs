Console.WriteLine("Ingresar un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());

/*
 * Estructuras de control if y switch
 * 
 */

if (numero > 0)
{
    if (numero % 2 == 0)
    {
        //Caso verdadero, el numero es par
        Console.WriteLine("El numero ingresado es positivo y par");
    }
    else
    {
        //Caso falso, el numero no es par
        Console.WriteLine("El numero ingresado es positivo y no es par");
    }
}
else
{
    //Caso falso, en donde no se cumple la condicion de positividad
    Console.WriteLine("El numero ingresado no es positivo");
}

//switch(numero)
//{
//    case 1:
//        {
//            Console.WriteLine("El numero es 1");
//            break;
//        }
//    case 2:
//        {
//            Console.WriteLine("El numero es 2");
//            break;
//        }
//    case 3:
//        {
//            Console.WriteLine("El numero es 3");
//            break;
//        }
//}

/*
 * Estructura de repeticion
 * 
 * Ciclo For: repetir un conjunto de instrucciones una cantidad finita de veces
 * for (int i = 0; i <= 100; i++)
 * 
 * i++ o ++i o i = i + 1 o i+=1
 */

for (int i = 0; i <= numero; i++)
{
    Console.WriteLine(i);
}

/*
 * Estructura de repeticion
 * 
 * Ciclo While: repetir un conjunto de instrucciones hasta que se cumpla una condicion (antes de entrar al ciclo)
 * si no se cumple con la condicion se sigue ejecutando el conjunto de instrucciones
 * while(j < numero)
 * 
 */

int j = 0;
while (j < numero)
{
    Console.WriteLine(j);
    j++;
}

/*
 * Estructura de repeticion
 * 
 * Ciclo Do-While: repetir un conjunto de instrucciones hasta que se cumpla una condicion (al finalizar el ciclo)
 * si no se cumple con la condicion se sigue ejecutando el conjunto de instrucciones, SIEMPRE entra al ciclo 
 * de iteracion es decir, que al menos se ejecuta una vez
 * while(j < numero)
 * 
 */

int k = 0;
do
{
    Console.WriteLine(k);
    k++;
} while (k < numero);

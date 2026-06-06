// class Program1
// {
// static void Main(string[] args)
// {
// Console.ReadLine(); // Permite ingresar caracteres
// Console.ReadKey(); // Permite ingresar teclas
// }
// }

// Tipos de datos
// int (integer)
// double (real)
// float (decimales)
// string (caracteres)
// bool (booleanos)

// Tipos de Variables
// Constante (declarar datos que no van a mutar a lo largo del proyecto)
// - Por lo general ocupa menos lugar en memoria
// Buena practica de variables: Definir -> Inicializar -> Utilizar o mutar

// int edad; // Inicialización de variable
// edad = 10; // Definición de variable
// int edad1 = 10; // Definición e inicialización a la vez
// edad = 18; //Mutación de la variable

// Console.WriteLine("Ingrese la edad de la persona");
// edad = int.Parse(Console.ReadLine()); //transforma (parse) el string del ReadLine en int

// if (edad < 0)
// {
//     Console.WriteLine("La edad tiene que ser en positivo");
// } else if (edad > 110)
// {
//     Console.WriteLine("Ingresa una edad válida");
// } else if (edad < 14)
// {
//     Console.WriteLine("Eres un niño");
// } else if (edad < 18)
// {
//     Console.WriteLine("Eres un adolescente");
// } else
// {
//     Console.WriteLine("Eres mayor de edad");
// }

// Console.WriteLine("la edad es de " + edad);

// //otro tipo de dato
// const double PI = 3.1415;
// string nombre;
// bool soltero;

// nombre = "Juan";
// soltero = true;

//TP 1.37
// const double PI = Math.PI;
// int radio;
// double perimetro;
// double area;

// radio = 0;
// Console.WriteLine("Ingrese el radio de la circunferencia");
// radio = int.Parse(Console.ReadLine());
// area = PI * Math.Pow(radio, 2);
// perimetro = 2 * PI * radio;

// Console.WriteLine("El area es de: " + area);
// Console.WriteLine("El perimetro es de: " + perimetro);

// Variable definidas e inicializadas
// const double PI = Math.PI;
// Console.WriteLine("Ingrese el radio de la circunferencia");

// int radio = int.Parse(Console.ReadLine());
// double area = PI * Math.Pow(radio, 2);
// double perimetro = 2 * PI * radio;

// Console.WriteLine("El area es de: " + area);
// Console.WriteLine("El perimetro es de: " + perimetro);

////////////////////////////////////////////////////////////

// Interpolación - Template string

// Arrays - Arreglos o vector
// Conjunto de tipos de datos
// int edades = {18, 45, 33};
// Console.WriteLine(5+5); // Muestra pero no guarda el diez

// Definición de variables
// string nombre;
// string apellido;
// int edad;
// bool estudioso;
// string mensaje;

// Inicializo
// nombre = "";
// apellido = "";
// edad = 0;
// estudioso = false;
// mensaje = "";

// Set valores
// nombre = "Matías";
// apellido = "Fiori";
// edad = 19;
// estudioso = true;

// if (estudioso == true)
// {
//     mensaje = "Soy un estudiante aplicado";
// } else
// {
//     mensaje = "No soy un estudiante aplicado";
// }

// mensaje = estudioso == true ? "Soy un estudiante aplicado" : "No soy un estudiante aplicado"; // Ternario

// Console.WriteLine("Hola, me llamo " + nombre + " " + apellido + " tengo " + edad + " años" + " y " + mensaje); // Sin interpolación
// La interpolación es una forma más sencilla de concatenar varias variables
// Console.WriteLine($"Hola, me llamo {nombre} {apellido} tengo {edad} años y {mensaje}"); // Más simple y conciso
// Console.WriteLine($"Hola, me llamo {nombre} {apellido} tengo {edad} años y {(estudioso ? "Soy un estudiante aplicado" : "No soy un estudiante aplicado")}"); // Uso de ternario dentro de una interpolación

////////////////////////////////////////////////////////////

// Parcial semana del 20 de mayo
// Hacer programa unicamente con switch
// Carta de un bar
// Mostrar las opciones en formato de catálogo
// Tienen que listar los menus y los precios
// Tiene que tener entradas, plato principales

/*
// definición de variable
int opcion;
int opcion_bebida;

// inicialización de variables
opcion = 0;
opcion_bebida = 0;

// Imprimir presentación
Console.WriteLine("Bienvenidos al Bar Momentos");
Console.WriteLine("A continuación le pedimos que ingrese un número para ver el menu:");
Console.WriteLine("(1) Entrada, (2) Plato Principal, (3) Bebidas y (4) Postres");

opcion = int.Parse(Console.ReadLine());


// imprimir menu
switch (opcion)
{
    case 1:
        Console.WriteLine("Entradas:");
        Console.WriteLine("Empanadas de carne (por unidad) 1000");
        Console.WriteLine("Empanadas de pollo (por unidad) 900");
        Console.WriteLine("Sfijas ------------------------ 1000");
        Console.WriteLine("Rabas  ------------------------ 10000");
    break;

    case 2:
        Console.WriteLine("Plato principal:");
        Console.WriteLine("Milanesas napolitana con papas españolas 18000");
        Console.WriteLine("Matambre al verdeo con papas españolas - 20000");
        Console.WriteLine("Pizza muzarella ------------------------ 12000");
        Console.WriteLine("Pizza de ternera ----------------------- 15000");
        Console.WriteLine("Ravioles de ricota y verduras ---------- 12000");
        Console.WriteLine("Canelones de verduras (2 unidades) ----- 70000");
    break;

    case 3:
       Console.WriteLine("Elija el tipo de bebida: (1) Con Alcohol, (2) Sin Alcohol");
       opcion_bebida = int.Parse(Console.ReadLine());
       switch (opcion_bebida)
       {
        case 1:
            Console.WriteLine("Bebidas con alcohol:");
            Console.WriteLine("Vino Valentino ------------------------- 3500");
            Console.WriteLine("Vino Cordero con Piel de Lobo ---------- 7000");
            Console.WriteLine("Vino Torrentes Echart Privado ---------- 9000");
            Console.WriteLine("Cerveza Heineken ----------------------- 8000");
            Console.WriteLine("Cerveza Corona ------------------------- 5000");
            Console.WriteLine("Cerveza Quilmes ------------------------ 5000");
        break;

        case 2:
            Console.WriteLine("Bebidas sin alcohol:");
            Console.WriteLine("Agua sin gas (500ml) ------------------------- 2000");
            Console.WriteLine("Agua con gas (500ml) ------------------------- 1800");
            Console.WriteLine("Jarra de Limonada ---------------------------- 5000");
            Console.WriteLine("Coca Cola (1,5l) ----------------------------- 5000");
            Console.WriteLine("Fanta (1,5l) --------------------------------- 5000");
            Console.WriteLine("Sprite (1,5l) -------------------------------- 5000");
            Console.WriteLine("Agua Saborizada (1,5l) (Linea Fresh) --------- 3500");
        break;

        default:
            Console.WriteLine("No ingreso un número válido");
        break;
       }
    break;

    case 4:
        Console.WriteLine("Postres:");
        Console.WriteLine("Tiramisú ---------------- 5000");
        Console.WriteLine("Flan -------------------- 3000");
        Console.WriteLine("Budin de pan ------------ 3000");
        Console.WriteLine("Ensalada de Frutas ------ 3500");
        Console.WriteLine("Brownie c/bocha de helado 8000");
        Console.WriteLine("Helado (2 bochas) ------- 4000");
    break;

    default:
        Console.WriteLine("No ingreso un número válido");
    break;
}
*/
// 20260504 - Ciclos repetitivos (while, do while)

// Console.WriteLine("Ciclos repetitivos!");
// Console.WriteLine("While - Do While - For - For Each");

// While - Do While - For - For Each
/*
 * 1. While (Mientras)
 *     Mientras suceda algo, yo voy a estar en el bucle
 * 2. Do (hacer mientras)
 *     Hace al menos una vez el bucle
 * 3. for (para)
 * 4. foreach (para cada uno)(por cada uno)
 *
 * Necesitamos ciertas variable para los ciclos repetitivos
 *   - Contador: Permite contar cosas
 *   - Acumulador: Permite sumar, acumular cosas
*/

// While
// Se usan los contadores para que puedan hacer algo
// El while depende de una condición que el programador da para poder salir del bucle

/*
int contador = 0;

while (contador < 3)
{
    Console.WriteLine("Eres menor de edad");
    contador++;
    //contador = contador + 1; // También se puede aplicar esto para aumentar el contador
}
*/

// Do while
// Entra una sola vez al menos, ya que primero hace la acción y
// luego compara la condición para poder realizar e bloque o no
/*
do
{
    Console.WriteLine("Eres menor de edad en el do while");
}
while (contador > 3);

// Datos en la base de datos
string Usuario1Pass = "1234";
string Usuario1Mail = "pepe@gmail.com";

string mail = "";
string pass = "";

int ContadorPass = 0;
//do
//{
//    Console.WriteLine("Ingrese el mail");
//    mail = Console.ReadLine();
//    Console.WriteLine("Ingrese la contraseña");
//    pass = Console.ReadLine();

//    ++ContadorPass;
//    Console.WriteLine($"Contador: {ContadorPass}");
//} while (ContadorPass < 3);
*/

/*
while (ContadorPass  < 3)
{
    Console.WriteLine($"Vuelta: {ContadorPass + 1}"); // La vuelta en realidad empieza en 0
    Console.WriteLine("Ingrese el mail:");
    mail = Console.ReadLine();
    Console.WriteLine("Ingrese la contraseña:");
    pass = Console.ReadLine();

    if (mail == Usuario1Mail && pass == Usuario1Pass)
    {
        Console.WriteLine("Bienvenido Jefe!");
        break; // Si hace lo que quiero, entonces corte el while
    }
    else
    {
        Console.WriteLine("Ingresaste algún dato del mail o contraseña erróneo");
        ++ContadorPass;
        Console.WriteLine($"Tienes {3 - ContadorPass} intentos más antes que se bloquee");
    }

    Console.WriteLine($"Contador: {ContadorPass}");
}



if (mail == Usuario1Mail && pass == Usuario1Pass)
{
    Console.WriteLine("Bienvenido Jefe!");
}
else
{
    Console.WriteLine("Ingresaste algún dato del mail o contraseña erróneo");
}

Console.WriteLine($"Tu email es {mail} y tu contraseña es {pass}");
*/

// Ingresar 3 notas y calcular el promedio con while
/*
int cuenta = 0;
int nota;
int acumulador_total_notas = 0;
double promedio = 0;

while (cuenta < 3)
{
    Console.WriteLine($"Ingrese la nota {cuenta + 1}:");
    nota = int.Parse(Console.ReadLine());
    ++cuenta; // Esto es el contador, siempre tiene que estar dentro del bucle para que pueda salir
    acumulador_total_notas += nota; //Esto es el acumulador
}
Console.WriteLine($"El acumulador es: {acumulador_total_notas}");

promedio = acumulador_total_notas / 3;
Console.WriteLine($"El promedio final es {promedio}");
*/

// 20260506
// Primer parcial: 20/05
// Temas hasta el for

/*
int NumeroAIngresar = 0;
int intentos = 0;

//Generación de un número aleatorio
Random numero = new Random();
int NumeroAleatorio = numero.Next(1, 100); //Doy el rango del número
Console.WriteLine($"El número aleatorio es: {NumeroAleatorio}");

int UnidadIngresada = 0;
int UnidadAleatorio = 0;
int DecenaIngresada = 0;
int DecenaAleatoria = 0;

while (intentos < 10)
{
    Console.WriteLine("Ingrese el número a adivinar");
    NumeroAIngresar = int.Parse(Console.ReadLine());

    // DONE(ivan): Necesito indicarle pistas al jugador para que se aproxime al número aleatorio

    if (NumeroAleatorio == NumeroAIngresar)
    {
        Console.WriteLine("Ganaste! Le Pegaste!");
        break;
    } else
    {
        UnidadIngresada = NumeroAIngresar % 10;
        UnidadAleatorio = NumeroAleatorio % 10;
        if (UnidadIngresada < UnidadAleatorio)
        {
            Console.WriteLine($"La unidad del número aleatorio es mayor. La unidad que pusiste es {UnidadIngresada}");
        } else if (UnidadIngresada == UnidadAleatorio)
        {
            Console.WriteLine("Le pegaste al número de la unidad del número aleatorio");
        } else
        {
            Console.WriteLine($"La unidad del número aleatorio es menor. La unidad que pusiste es {UnidadIngresada}");
        }

        if (NumeroAleatorio >= 10)
        {
            DecenaIngresada = (NumeroAIngresar / 10) % 10;
            DecenaAleatoria = (NumeroAleatorio / 10) % 10;
            if (DecenaIngresada < DecenaAleatoria)
            {
                Console.WriteLine($"La decena del número aleatorio es mayor. La decena que pusiste es {DecenaIngresada}");
            } else if (DecenaIngresada == DecenaAleatoria)
            {
                Console.WriteLine("Le pegaste al número de la decena del número aleatorio");
            } else
            {
                Console.WriteLine($"La decena del número aleatorio es menor. La decena que pusiste es {DecenaIngresada}");
            }
        }

        // Aumento los intentos
        ++intentos;
        Console.WriteLine("Segui participando");
        Console.WriteLine($"Te quedan {10 - intentos} intentos");
    }
}
*/

/* Ciclos repetitivos (for, foreach)
 *
 * Proceso de ejecución:
 * while -> Condicion -> acción
 * do while acción -> condición
 * for, foreach igual al while
 *
 * El for tiene inicio y final
 * el foreach se lo hace para arrays
 *
 * FOR
 * for(inicialización de varibale; final del ciclo, iterador)
 * {
 *
 * }
 * for(int iterador = 0; iterador < 100, iterador = iterador +1)
 * {
 *
 * }
 *
 * Si necesito correr todo necesito un for
 * Si necesito tener un corte necesito un while
 */

/*for(int iterador = 0; iterador < 100; iterador = iterador + 1)
{
    Console.WriteLine(iterador);
}
*/
/*for(int i = 0; i < 100; ++i)
{

}*/

// Calculadora de 8
/*for (int i = 0; i <= 12; ++i)
{
    Console.WriteLine($"Esto es 8 * {i} = {8*i}");
}
*/

// DONE(ivan): Hacer que solo se pueda hacer del 1 al 12 y que si no es ese número volver a preguntar
//             Hacerlo con una bandera (booleano que permita mantener el while)
// Tabla multiplicadora
/*
int num = 0;
bool NumerosImposiblesAIngresar = true;

while (NumerosImposiblesAIngresar)
{
    Console.WriteLine("Ingrese el número");
    num = int.Parse(Console.ReadLine());
    if (num > 0 && num < 12)
    {
        for (int i = 0; i <= 12; ++i)
        {
            Console.WriteLine($"Esto es {num} * {i} = {num*i}");
        }
        NumerosImposiblesAIngresar = false;
    } else
    {
        Console.WriteLine("Debe ingresar un número del 0 al 12");
    }

}
*/

/*
int acumulador = 0;

for (int i = 0; i <= 100; ++i)
{
    acumulador = acumulador + i;
    Console.WriteLine(acumulador);
}
*/


// Ejercicios propios
/*Ask the user for a number.

Determine whether it is prime. */
/*
double numero;
double resto;
double divisor;

numero = 0;
resto = 0;
divisor = 0;

Console.WriteLine("Ingrese un número: ");
numero = int.Parse(Console.ReadLine());

//Como averiguar que un número es primo
divisor = Math.Sqrt(numero);

for (int i = 1; i < divisor; ++i)
{
    Console.WriteLine($"Probando con el número {i}");
    resto = divisor / i;
    Console.WriteLine($"El resto es de: {resto}");
    if (resto == 0)
    {
        Console.WriteLine("El número es primo");
        break;
    }
}
*/

// Simulador de cajero

/*
Initial balance: $1000

Show a menu repeatedly:

1 - Deposit
2 - Withdraw
3 - Check balance
4 - Exit

Rules:

Cannot withdraw more than current balance
Negative deposits are invalid
*/
/*
using System;

bool encendido;
int deposito_inicial;
int opcion;
int deposito;
int numero_extraccion;

encendido = true;
deposito_inicial = 1000;
opcion = 0;

while (encendido)
{
    Console.WriteLine("""
                        1 - Deposit
                        2 - Withdraw
                        3 - Check balance
                        4 - Exit
                        """);
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
                Console.WriteLine("Cuanto desea desopitar");
                deposito = int.Parse(Console.ReadLine());
                deposito_inicial += deposito;
                Console.WriteLine($"Su deposito ahora es de: {deposito_inicial}");
                break;
        case 2:
                Console.WriteLine("Cuanto desea Extraer");
                numero_extraccion = int.Parse(Console.ReadLine());
                if (numero_extraccion > deposito_inicial)
                {
                    Console.WriteLine("No puede extraer el monto ingresado, por favor vea su balance.");
                } else
                {
                    deposito_inicial = deposito_inicial - numero_extraccion;
                    Console.WriteLine("Reciba el dinero por favor...");
                    Console.WriteLine($"Su Balance es de: {deposito_inicial}");
                }
                break;

        case 3:
                Console.WriteLine($"Su balance actual es de: {deposito_inicial}");
                break;
        case 4:
                encendido = false;
                Environment.Exit(0);
                break;
        default:
            Console.WriteLine("Inserte un caso válido");
            break;
    }
}
*/

/*
Ask the user for a positive integer.

Calculate its factorial.
Example:
5! = 120

Extra:
Reject negative numbers

Concepts:
loops
multiplication accumulators
validation
*/

/*
int number;
long factorial;

number = 0;
factorial = 1;

Console.WriteLine("Ingrese un número: ");
number = int.Parse(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Ingrese un número positivo");
    Environment.Exit(0);
}

for (int i = 1; i <= number; ++i)
{
    factorial *= i;
}

Console.WriteLine($"El factorial del número {number} es de {factorial}");

/*

10. Student Grades
Ask how many students there are.
For each student: Enter a grade from 0 to 100

At the end print:
Average grade
Highest grade
Lowest grade
Number of students that passed (>= 60)

Concepts: loops comparisons accumulators
*/

/*
11. Pattern Triangle
Ask the user for a number.
Print a triangle using *.

Example for 5:
*
**
***
****
*****

Extra:
Print the inverted triangle too

Concepts: nested loops
*/

/*
string star = "*";
string pyramid = "";

for (int i = 1; i <= 5 ;++i)
{
    pyramid = pyramid + star;
    Console.WriteLine($"{pyramid}");
}

for (int i = 5; i >= 1; --i)
{
    pyramid = "";

    for (int j = 1; j <= i; ++j)
    {
        pyramid = pyramid + star;
    }
    Console.WriteLine($"{pyramid}");
}
*/

/*
15. Mini Casino Game
The player starts with $100.

Each round:
Bet an amount
Guess a number from 1 to 5
Random number is generated

Rules:
Correct guess -> win double
Wrong guess -> lose the bet
Game ends if balance reaches 0 or player exits

Concepts: loops random numbers conditionals game state
*/
/*
int deposito_inicial = 100;
int numero_ingresado = 100; // Número grande para que no salte el while y tenga un valor no basura
int monto_a_apostar;

Random numero = new Random();
int NumeroAleatorio = numero.Next(1, 5); //Doy el rango del número
Console.WriteLine($"El número aleatorio es: {NumeroAleatorio}");

while (deposito_inicial == 0 || numero_ingresado != 0)
{
    if (deposito_inicial == 0)
    {
        Console.WriteLine("Te has quedado sin dinero");
        Environment.Exit(0);
    }

    Console.WriteLine("Ingrese el monto a apostar");
    monto_a_apostar = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un número del 1 al 5");
    numero_ingresado = int.Parse(Console.ReadLine());

    if (numero_ingresado == NumeroAleatorio)
    {
        Console.WriteLine("Has ganado el doble!");
        deposito_inicial += monto_a_apostar;
        Console.WriteLine($"Tu monto total ahora es de: {deposito_inicial}");
    } else
    {
        Console.WriteLine("Le has errado a la apuesta!");
        deposito_inicial -= monto_a_apostar;
        Console.WriteLine($"Tu monto total ahora es de: {deposito_inicial}");
    }
}
*/


// ======================================================
// 1. Fibonacci Sequence
// ======================================================
//
// Ask the user for a number N.
//
// Print the first N Fibonacci numbers.
//
// Example:
// How many numbers? 7
//
// 0
// 1
// 1
// 2
// 3
// 5
// 8
//
// Concepts:
// - loops
// - temporary variables
// ======================================================
/*
int fibonacci;
int previous = 0;
int current = 1;

Console.WriteLine("Ingrese un número para saber su secuencia fibonacci: ");
fibonacci = int.Parse(Console.ReadLine());

for (int i = 0; i < fibonacci; ++i)
{
    Console.Write($"{previous}\n");

    int next = previous + current;
    previous = current;
    current = next;
}
*/
// ======================================================
// 2. Reverse a Number
// ======================================================
//
// Ask the user for a number.
//
// Print the number reversed.
//
// Example:
// Input: 12345
// Output: 54321
//
// Extra:
// - Determine whether the number is a palindrome
//
// Concepts:
// - %
// - /
// - loops
// ======================================================
/*
int number;
int digit;
int cantidad_de_loop;
int number_for_loop;
int initial_number;
string reverse_number;

reverse_number = "";
cantidad_de_loop = 0;

Console.WriteLine("Inserte el numero que quiere revertir: ");
number = int.Parse(Console.ReadLine());

// La pregunta es: se podría usar dos funciones para que no se tenga que almacenar dos veces el número?
number_for_loop = number;
initial_number = number;

// este while me permite saber la cantidad de veces que va a tener que hacer el bucle
// dadas sus cantidad de números
while(number % 10 != 0)
{
    ++cantidad_de_loop;
    number = number / 10;
}

// aca la idea es la de tener que sacar el ultimo digito
// luego eliminarlo para agregarlo a un string vacio
for (int i = 0; i < cantidad_de_loop; ++i)
{
    digit = number_for_loop % 10; // Con esta operación consigo el último número
    number_for_loop = number_for_loop / 10; // Con esta operación saco el último número
    reverse_number = reverse_number + digit.ToString();
}

Console.WriteLine(reverse_number);
if (initial_number == int.Parse(reverse_number))
{
    Console.WriteLine("Son números palindromos");
}
*/

// ======================================================
// 3. Digit Counter
// ======================================================
//
// Ask the user for a number.
//
// Count how many digits it has.
//
// Example:
// 9321 -> 4 digits
//
// Extra:
// - Count even digits and odd digits separately
// ======================================================

/*
int number;
int digit;
int odd_count;
int even_count;
int resto;

digit = 0;
odd_count = 0;
even_count = 0;
resto = 0;

Console.WriteLine("Ingrese el número que desea modificar");
number = int.Parse(Console.ReadLine());

while (number % 10 != 0)
{
    resto = number % 10;
    if (resto % 2 == 0)
    {
        ++odd_count;
    }
    if (resto % 2 != 0)
    {
        ++even_count;
    }

    ++digit;
    number = number / 10;
}

Console.WriteLine($"El número tiene {digit} dígitos. El número tiene {odd_count} dígitos pares y {even_count} dígitos impares");
*/

// ======================================================
// 4. Sum of Digits
// ======================================================
//
// Ask the user for a number.
//
// Calculate the sum of all digits.
//
// Example:
// 1234 -> 10
//
// Concepts:
// - %
// - integer division
// ======================================================



// ======================================================
// 5. Perfect Number Checker
// ======================================================
//
// A perfect number is equal to the sum of its divisors.
//
// Example:
// 6 = 1 + 2 + 3
//
// Ask the user for a number and determine
// whether it is perfect.
//
// Concepts:
// - loops
// - divisibility
// - accumulators
// ======================================================



// ======================================================
// 6. Number Pyramid
// ======================================================
//
// Ask the user for a height.
//
// Print:
//
// Example for 5:
//
// 1
// 12
// 123
// 1234
// 12345
//
// Extra:
// - Print the inverted version too
//
// Concepts:
// - nested loops
// ======================================================



// ======================================================
// 7. Shopping Cart Simulator
// ======================================================
//
// Repeatedly ask:
// - product price
// - quantity
//
// Stop when price is 0.
//
// Print:
// - total items
// - total cost
// - most expensive product
//
// Concepts:
// - sentinel loops
// - accumulators
// - comparisons
// ======================================================



// ======================================================
// 8. Rock Paper Scissors
// ======================================================
//
// User vs computer.
//
// Rules:
// - Rock beats scissors
// - Scissors beats paper
// - Paper beats rock
//
// Play until the user exits.
//
// Keep score:
// - wins
// - losses
// - draws
//
// Concepts:
// - switch
// - random
// - loops
// ======================================================



// ======================================================
// 9. Bank Loan Validator
// ======================================================
//
// Ask:
// - salary
// - monthly expenses
// - requested loan
//
// Rules:
// loan approved only if:
//
// salary - expenses >= loan * 0.30
//
// Print approved or rejected.
//
// Extra:
// - Allow multiple clients
//
// Concepts:
// - conditionals
// - loops
// ======================================================



// ======================================================
// 10. Mini Voting System
// ======================================================
//
// Candidates:
//
// 1 - Alice
// 2 - Bob
// 3 - Charlie
// 4 - Blank vote
// 0 - End voting
//
// Count votes.
//
// At the end print:
// - total votes
// - winner
// - blank votes
//
// Extra:
// - Handle ties
//
// Concepts:
// - counters
// - loops
// - comparisons
// ======================================================



// ======================================================
// 11. Temperature Analyzer
// ======================================================
//
// Ask how many temperatures will be entered.
//
// For each temperature:
//
// Determine if:
// - cold (<10)
// - warm (10-25)
// - hot (>25)
//
// At the end print:
// - average temperature
// - hottest
// - coldest
// - count per category
// ======================================================



// ======================================================
// 12. PIN Code System
// ======================================================
//
// Correct PIN:
//
// 4321
//
// Rules:
// - 3 attempts max
//
// If successful:
// show a menu:
//
// 1 - Balance
// 2 - Deposit
// 3 - Exit
//
// Concepts:
// - nested loops
// - authentication
// - menus
// ======================================================



// ======================================================
// 13. ASCII Rectangle
// ======================================================
//
// Ask:
// - width
// - height
//
// Print a rectangle using *
//
// Example:
//
// *****
// *****
// *****
//
// Extra:
// - Print only the borders
//
// Example:
//
// *****
// *   *
// *   *
// *****
//
// Concepts:
// - nested loops
// - conditions inside loops
// ======================================================



// ======================================================
// 14. Multiplication Quiz Game
// ======================================================
//
// Generate random multiplications.
//
// Example:
//
// 7 * 3 = ?
//
// The player answers.
//
// After 10 questions print:
// - score
// - correct answers
// - incorrect answers
//
// Extra:
// - Add difficulty levels
//
// Concepts:
// - random
// - loops
// - counters
// ======================================================



// ======================================================
// 15. Mini Text Menu RPG
// ======================================================
//
// Player starts with:
//
// Health: 100
// Potions: 3
//
// Menu:
//
// 1 - Fight
// 2 - Drink potion
// 3 - Rest
// 4 - Exit
//
// Rules:
// - Fight causes random damage
// - Potion heals
// - Rest restores small health
// - Game ends at 0 health
//
// Concepts:
// - game loop
// - state management
// - random
// - conditionals
// ======================================================
/*
int health = 100;
int potion_quantity = 3;
int fight = 0;
const int potion_heal = 10;
const int rest = 3;
int option = 0;
Random random_damage = new Random();

Console.WriteLine($"""
                  Bienvenido a la contienda.
                  Tiene una vida de {health} puntos
                 """);

while (health > 0)
{
    Console.WriteLine($"""
                     Tienes las siguientes opciones para adentrarte en la aventura:
                     1 - Fight
                     2 - Drink potion
                     3 - Rest
                     4 - Exit
                     """);
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine("Has decidido pelear");
            fight = random_damage.Next(10, 100);
            health -= fight;
            Console.WriteLine($"Has recibido {fight} de daño");
            Console.WriteLine($"Ahora tu vida es de {health}");
        break;

        case 2:
            if (potion_quantity == 0)
            {
                Console.WriteLine("No tienes más pociones. Ya no puedes curarte con ellas");
                break;
            }

            Console.WriteLine("Has decidido tomar una poción");
            health += potion_heal;
            potion_quantity--;
            Console.WriteLine($"Has curado {potion_heal} puntos de vida. Tienes {potion_quantity} pociones. Ahora tienes {health} puntos de vida");
        break;

        case 3:
            Console.WriteLine("Has decidido descansar");
            health += rest;
            Console.WriteLine($"Has curado {rest} puntos de vida. Ahora tienes {health} puntos de vida");
        break;

        case 4:
            Environment.Exit(0);
        break;

        default:
            Console.WriteLine("Ingresa un numero del 1 al 4");
        break;
    }
}
*/
/*Console.WriteLine("Has perdido!");
*/
///////////////////////////////////////////////////////////////////////////////
// Usando un for, mostrar por pantalla los números del 1 al 10.

/*for (int i = 1; i < 11; ++i)
{
    Console.WriteLine($"El numero es {i}");
}
*/

/*int numero;

Console.WriteLine("Ingrese el numero");
numero = int.Parse(Console.ReadLine());
if (numero < 0)
{
    Console.WriteLine("Ingrese un numero positivo");
} else
{
for(int i = 0; i <= numero; ++i)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
}
*/
// Tabla de multiplicar
/*
int num = 0;
//bool NumerosImposiblesAIngresar = true;

//while (NumerosImposiblesAIngresar)
//{
    Console.WriteLine("Ingrese el número");
    num = int.Parse(Console.ReadLine());
//    if (num > 0 && num < 12)
//    {
        for (int i = 1; i <= 10; ++i)
        {
            Console.WriteLine($"Esto es {num} * {i} = {num*i}");
        }
//        NumerosImposiblesAIngresar = false;
//    } else
//    {
//        Console.WriteLine("Debe ingresar un número del 0 al 12");
//    }
//
//}
*/

// SUma de numeros positivos
/*int num;
int sum;

sum = 0;

do
{
    Console.WriteLine("Ingrese un numero");
    num = int.Parse(Console.ReadLine());

    if (num < 0) break;

    sum = sum + num;
    Console.WriteLine($"La suma es: {sum}");
} while (num >= 0);
*/

/*int num, pares, impares;

num = 0;
pares = 0;
impares = 0;

for (int i = 0; i < 10; ++i)
{
    Console.WriteLine("Ingrese numero");
    num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        ++pares;
    }

    if (num % 2 != 0)
    {
        ++impares;
    }
}

Console.WriteLine($"La cantidad de numeros pares es de: {pares}");
Console.WriteLine($"La cantidad de numeros impares es de: {impares}");
*/

/*int contador;
int nota;
int suma;
int promedio;
int cantidad_a_dividir;

contador = 0;
nota = 0;
suma = 0;
promedio = 0;
cantidad_a_dividir = 5;

while (contador < 5)
{
    Console.WriteLine("Ingrese la nota");
    nota = int.Parse(Console.ReadLine());
    suma = suma + nota;

    contador++;
}

promedio = suma / cantidad_a_dividir;
Console.WriteLine($"El promedio es de: {promedio}");
*/

//Factorial
/*
int num;
int factorial;

num = 0;
factorial = 1;

Console.WriteLine("Ingrese un número para hacer su factorial");
num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; ++i)
{
    factorial *= i;
    Console.WriteLine(factorial);
}

Console.WriteLine($"El factorial de {num} es de: {factorial}");
*/

/*
string pass;

pass = "";

do
{
    Console.WriteLine("Ingrese la contraseña");
    pass = Console.ReadLine();
} while (pass != "admin123");*/

/*
int num;
int mayor;
int menor;

num = 0;
mayor = 0;
menor = 0;

for(int i = 0; i < 5; ++i)
{
Console.WriteLine("Ingrese un numero");
num = int.Parse(Console.ReadLine());

if (num > mayor)
{
    mayor = num;
} else
{
    menor = num;
}
}

Console.WriteLine($"El numero mayor es {mayor}");
Console.WriteLine($"El numero menor es {menor}");
*/
/*
int cantidad_de_vendedores;
int sueldo_basico;
int precio_comision;
double porcentaje_comision;
double sueldo_a_pagar;
double total_a_pagar;

sueldo_basico = 0;
porcentaje_comision = 0.1;
total_a_pagar = 0;
precio_comision = 0;
sueldo_a_pagar = 0;

Console.WriteLine("Ingrese la cantidad de vendedores: ");
cantidad_de_vendedores = int.Parse(Console.ReadLine());

for (int i = 0; i < cantidad_de_vendedores; ++i)
{
    Console.WriteLine("Ingrese el total del precio de la comision: ");
    precio_comision = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese elsueldo básico: ");
    sueldo_basico = int.Parse(Console.ReadLine());

    sueldo_a_pagar = sueldo_basico + (precio_comision * porcentaje_comision);
    Console.WriteLine($"El sueldo para este vendedor será de: {sueldo_a_pagar}");

    total_a_pagar = total_a_pagar + sueldo_a_pagar;
}

Console.WriteLine($"El total a pagar será de: {total_a_pagar}");
*/
/*
int num = 0;
int positivos = 0;
int cantidad_positivos = 0;
int cantidad_negativos = 0;
int negativos = 0;

do
{
    Console.WriteLine("Ingrese un numero. Para salir tipee '0'.");
    num = int.Parse(Console.ReadLine());

    if (num > 0)
    {
        cantidad_positivos++;
        positivos = positivos + num;
    }
    if (num < 0)
    {
        cantidad_negativos++;
        negativos = negativos + num;
    }
} while (num != 0);

Console.WriteLine($"""
                  La cantidad de numeros positivos es de: {cantidad_positivos}
                  La cantidad de numeros negativos es de: {cantidad_negativos}
                  La suma de numeros positivos es de: {positivos}
                  La suma de numeros negativos es de: {negativos}
                  """);
*/

// TODO(ivan): Pasar lo que se hizo de vectores (está en una foto que hay que pasar con gemini)
//////////////////////////////////////////////////////////////////////////////

// 2060527

// Matrices
// En las matrices los length son la cantidad de elementos totales de la matriz
// Esto es una propiedad de la matriz
// Para poder saber la cantidad de elementos de una fila de la matriz tengo un método (GetLength)
// Un método es una función mientras que una propiedad es un valor
// (que van a tener un tipo de dato [int, double, bool, char])

// Para iniciializar una matriz
// Las posiciones de las matrices también arrancan en 0
/*int[,] numeros = new int[2,2]; //Matriz cuadrada de orden 2

int[,] numeros2 = { {1, 2},  // Inicializo y defino a la vez
                    {3, 4} };
*/
// Para saber como mostrar todos los elementos tenemos que hacer un for anidado
// En los for anidados primero se tiene que resolver el for de adentro y luego el for de afuera
// (0, 0) -> (0, 1) -> (1, 0) -> (1, 1) (Dada una matriz cuadrada de orden 2)

/*// Primero va a recorrer las columnas y luego va a recorrer cada una de las filas
for (int i = 0; i < numeros2.GetLength(0); ++i) // Me permite saber las filas
{
    for (int j = 0; j < numeros2.GetLength(1); ++j) // Me permite recorrer las columnas
    {
        Console.Write(numeros2[i, j]);
    }
    Console.WriteLine();
}
*/

/*
// Como se rellenar una matriz
int[,] numeros3 = new int[2, 2];

for (int i = 0; i < numeros3.GetLength(0); ++i) // Me permite saber las filas
{
    for (int j = 0; j < numeros3.GetLength(1); ++j) // Me permite recorrer las columnas
    {
        Console.WriteLine("Ingrese un número para la matriz de orden 2.");
        numeros3[i,j] = int.Parse(Console.ReadLine());
    }

}

// Ahora que mostrar con un nuevo barrido
for (int i = 0; i < numeros3.GetLength(0); ++i) // Me permite saber las filas
{
    for (int j = 0; j < numeros3.GetLength(1); ++j) // Me permite recorrer las columnas
    {
        Console.Write(" " + numeros3[i, j]);
    }
    Console.WriteLine();
}
*/

// TODO(ivan): Hacer un ta te ti con esto, usando matrices
// TATETI con matrices

/*
string[,] table = new string[3,3];
bool winning = false;
bool isX = true;

//while (!winning)
//{
    // Mostrar todo el tablero
    for (int i = 0; i < table.GetLength(0); ++i)
    {
        for (int j = 0; j < table.GetLength(1); ++j)
        {
            table[i,j] = "|_|";
            Console.Write(table[i,j]);
        }
        Console.WriteLine();
    }
    // Pedir la posición de la marca
/*    for (int i = 0; i < table.GetLength(0); ++i)
    {
        for (int j = 0; j < table.GetLength(1); ++i)
        {
            Console.WriteLine("Ingrese la posición de un marca");
        }
    }
    // Chequear posiciones

    // Ver si hay algún ganador
}
*/
////////////////////////////////////////////////////////////////////////////
// Bubble sort y Funciones - 20200601
// Recuperación del primer parcial 10/06

// Método burbuja (Bubble sort)

// Método de ordenamiento de arrays
// Dado un vector = {4,7,3,2,8,9} desordenados
//                  {2,3,4,7,8,9} ordenados
// Para ordenarlos hay que usar el método burbuja
// Se compara un numero con el numero de al lado
// Dependiendo si es mayor se lo empuja hacia adelante
// Otra manera puede ser que si es menor se lo tendría que empujar atrás
// Se necesita dos for
// El primero recorre todo el array
// El segundo es el que permite la comparación
// En el segundo tiene que ser hasta el length menos 1.
// Porque se va a comparar

/// Inicializo el vector
// int[] numeros = { 4, 3, 2, 6, 9, 7, 8 };

///Mostrar array desordenado
//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.Write(" " + numeros[i]);
//}
//Console.WriteLine();

/// Esto es el algoritmo del bubble sort
// for (int i = 0; i < numeros.Length; i++) // Permite recorrer cada uno de los elementos
// {
//    for (int j = 0; j < numeros.Length - 1; j++) // Dentro de este for se realiza el ordenamiento, permite las comparaciones
//    {
//        if (numeros[j] > numeros[j+1]) // Si se pone menor, ordena de mayor a menor, si se pone mayor es de menor a mayor
//        {
//            int auxiliar = numeros[j]; // Es necesaria una variable auxiliar para que no pise los elementos del array
//            numeros[j] = numeros[j+1];
//            numeros[j+1] = auxiliar;
//        }
//    }
// }

///Ahora hay que mostrar el array ordenados
//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.Write(" " + numeros[i]);
//}

//Console.WriteLine();
//Console.WriteLine("Usando el método Sort propio de c#");

//int[] num2 = { 10, 32, 26, 84, 31, 47, 71 };

//for (int i = 0; i < num2.Length; i++)
//{
//    Console.Write(" " + num2[i]);
//}

///Metodo propio de bubble sort
//num2.Sort();
//Console.WriteLine();

///Recorrer ordenado
//for (int i = 0; i < num2.Length; i++)
//{
//    Console.Write(" " + num2[i]);
//}


// Funciones

// Bloque de código que realice una determinada tarea
// Es bueno que las funciones solo tengan una tarea a realizar
// función(parámetros) { bloque de lo que quiere realizar la tarea }
// Hay dos tipos de funciones: con retorno y sin retorno (return)
// Las primeras devuelven un tipo de dato
// Las segundas también son llamadas procedimiento. Su retorno es void
// Se tiene que poner un nombre de la variable de acuerdo a la tarea que va a realizar

// Inicializamos la función. Se coloca void porque no retorna ningún tipo de dato
// Queda solo guardada en memoria
// void Saludar()
// {
//     Console.WriteLine("Hola Com 3");
// }

// Usamos la función para que haga el código
// Llamamos la función para que se use
// Saludar();
// Saludar();
// Saludar();
// Saludar();
// Se invoca a la función 4 veces

// void SaludarAlumno(string nombre) // Tiene un parámetro de tipo string que se lo denomina nombre
// {
//     Console.WriteLine($"Hola {nombre}");
// }
//
// SaludarAlumno("Ivan");   // Se invoca con una string particular
// SaludarAlumno("Hugo");   // Se invoca con una string particular
// SaludarAlumno("Pedro");  // Se invoca con una string particular
// SaludarAlumno("Alicia"); // Se invoca con una string particular

// Puede verse a la funciones como que tiene dos lados
// Un lado donde la definimos y otro lado donde la invoco
// Del lado de la definición la función tiene parámetros
// Del lado de la invocación la función tiene argumentos
// Los argumentos "viajan" a la función

//Funciones con retorno

// int suma(int num1, int num2) //Tengo que poner el tipo de lo que va a retornar. Los parámetros tienen que especificar su tipo
// {
//     // Se puede crear variables dentro de las funciones
//     // Estas variables van a tener un scope (alcance) local
//     int resultado = 0; // Esta variable tiene scope local, solo vive dentro de esta función

//     resultado = num1 + num2;

//     return resultado;
// }

// Alcance (scope) de las funciones
// Puede ser local o global
// Si es local solo tiene que darse dentro de la función o sección de código
// La global tiene que estar en todo el programa

// int numero1 = int.Parse(Console.ReadLine());
// int numero2 = int.Parse(Console.ReadLine());

// int resultado = suma(numero1, numero2);

// Console.WriteLine($"El resultado de la suma es: {resultado}");
/////////////////////////////////////////////////////////////////////////////////////

// 20260603
// Funciones
// Hay que tener en cuenta cuantos parámetros le damos a cada una de las funciones
// Una buena práctica son máximo 6 parámetros
// Más de eso se necesita crear una clase

// Los retornos pueden ser usados para trabajar en otras cosas
// Se puede retornar cualquier estructura de datos (array, matriz, etc)
// Tipos de funciones

// Funciones sin parámetro y sin retorno
// void Saludar()
// {
//     Console.WriteLine("Hola mundo");
// }

// // Funciones con parámetros y sin retorno
// void Saludar2(string nombre) // Los parámetros pueden ser de distintos tipos y todos lo que se desee
// {
//     Console.WriteLine($"Hola {nombre}");
// }

// // Funciones sin parámetros y con retorno
// int Sumar()
// {
//     return 2 + 2;
// }

// string Saludar3()
// {
//     return "Hola comisión 3";
// }

// // Funciones con parámetros y con retorno
// double Dividir(int num1, int num2)
// {
//     return num1 / num2;
//     // return (double)num1 / num2; // Casteo (parse) para que sea un double num1
// }

// // Ejemplo de cómo se tendría que usar la última función
// Console.WriteLine("Ingresa el primer número");
// int numero1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingresa el segundo número");
// int numero2 = int.Parse(Console.ReadLine());
// Dividir(numero1, numero2);

// double resultado = Dividir(numero1, numero2);
// Console.WriteLine($"El resultado de la división de {numero1} y {numero2} es de {resultado}");

// // Funciones Lambda
// double Producto(int num1, int num2) => num1 * num2;
// // La flecha tiene implícita el return

// // Sobrecarga
// double multiplicar_por_si_mismo(int num1)
// {
//     return num1 * num1;
// }
// // Si llamamos a la función tenemos que pasar uno de los valores, si o si necesita de un número
// // Function overloading is a programming feature that allows you to create
// // multiple functions with the exact same name, provided they have different
// // parameter lists.
// double multiplicar_por_si_mismo(int num1, int num2) // Tendría que estar en una clase
// {
//     return num1 * num1 * num2;
// }

// // Funciones con valor por defecto
// // Sirve para poder
// double Restar(int num1 = 0, int num2 = 0)
// {
//     return num1 - num2;
// }

// void
// BuscarNombre(string[] nombres)
// {
//     foreach (var nombre in nombres) // No se tiene acceso al iterador. Se usa para recorrer y mostrar Se usa en arrays frecuentemente
//     {
//         Console.WriteLine(nombre);
//     }
// }

// string[] nombres = ["Juan", "María", "Pedro"];

// BuscarNombre(nombres);

//////////////////////////
// TP Funciones

// 1
//
void Saludar()
{
    Console.WriteLine("Bienvenidos a Programación I");
}

Saludar();

//2
//
void MostrarNombre(string nombre)
{
    Console.WriteLine("Ingresa el nombre deseado:");
    Console.WriteLine($"El nombre ingresado es {nombre}");
}

MostrarNombre("Ivan");

// 3
//
int ObtenerNumero()
{
    return 100;
}

ObtenerNumero();

// 4
//
Console.WriteLine("Ingrese dos números:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int Sumar(int a, int b)
{
    return a + b;
}

Sumar(a, b);

// 5
//
bool EsPar(int numero)
{
    return numero % 2 == 0;
}

EsPar(5);
EsPar(20);
EsPar(0);

// 6
//

double CalcularDescuento(double precio, double porcentaje = 10)
{
    if (porcentaje > 1)
    {
        porcentaje /= 100;
    }

    return precio * porcentaje;
}

CalcularDescuento(1000);
CalcularDescuento(50000, 50);

// 7
//
bool BuscarNombre(string[] nombres, string buscado)
{
    foreach (string nombre in nombres)
    {
        if (nombre == buscado)
        {
            return true;
        }
    }
    return false;
}

// 8
//
int Mayor(int a, int b, int c)
{
    int mayor = a;
    if (mayor > b)
    {
        return mayor;
    }
    else
    {
        mayor = b;
    }

    if (mayor > c)
    {
        return mayor;
    }
    else
    {
        mayor = c;
    }
    return mayor;
}

// 9
//
int LambdaSumar(int a, int b) => a + b;

// 10
//
double CalcularPromedio(double[] notas)
{
    double suma = 0;
    foreach (double nota in notas)
    {
        suma += nota;
    }

    return suma / notas.Length;
}
CalcularPromedio([1, 2, 3, 4, 5, 6]);

// 11
//
double SumarMenu(double num1, double num2)
{
    return num1 + num2;
}

double RestarMenu(double num1, double num2)
{
    return num1 - num2;
}

double MultiplicarMenu(double num1, double num2)
{
    return num1 * num2;
}

double DividirMenu(double num1, double num2)
{
    return num1 / num2;
}

int operacion = 0;

while (operacion != 0)
{
    Console.WriteLine("""
                        Bienvenido a la calculadora.
                        Tiene distintas operaciones para realizar.
                        Ingrese un número dependiendo de las operaciones que desee realizar.
                        1. Suma
                        2. Resta
                        3. Multiplicación
                        4. División
                        0. Para salir
                        A continuación ingrese los dos números a operar.
                     """);
    operacion = int.Parse(Console.ReadLine());
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());

    switch (operacion)
    {
        case 1:
            SumarMenu(num1, num2);
            break;
        case 2:
            RestarMenu(num1, num2);
            break;
        case 3:
            MultiplicarMenu(num1, num2);
            break;
        case 4:
            DividirMenu(num1, num2);
            break;
        default:
            break;
    }
}

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
    //contador = contador + 1;
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
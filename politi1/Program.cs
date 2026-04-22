// class Program1
{
    // static void Main(string[] args)
    {
        // Console.ReadLine(); // Permite ingresar caracteres
        // Console.ReadKey(); // Permite ingresar teclas
    }
}

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
string nombre;
string apellido;
int edad;
bool estudioso;
string mensaje;

// Inicializo
nombre = "";
apellido = "";
edad = 0;
estudioso = false;
mensaje = "";

// Set valores
nombre = "Matías";
apellido = "Fiori";
edad = 19;
estudioso = true;

// if (estudioso == true)
// {
//     mensaje = "Soy un estudiante aplicado";
// } else
// {
//     mensaje = "No soy un estudiante aplicado";
// }

mensaje = estudioso == true ? "Soy un estudiante aplicado" : "No soy un estudiante aplicado"; // Ternario 

Console.WriteLine("Hola, me llamo " + nombre + " " + apellido + " tengo " + edad + " años" + " y " + mensaje); // Sin interpolación
// La interpolación es una forma más sencilla de concatenar varias variables
Console.WriteLine($"Hola, me llamo {nombre} {apellido} tengo {edad} años y {mensaje}"); // Más simple y conciso
Console.WriteLine($"Hola, me llamo {nombre} {apellido} tengo {edad} años y {(estudioso ? "Soy un estudiante aplicado" : "No soy un estudiante aplicado")}"); // Uso de ternario dentro de una interpolación

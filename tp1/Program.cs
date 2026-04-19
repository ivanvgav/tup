// Saludo inicial
Console.WriteLine("Esto es el programa para resolver el TP1.\nTiene que desconmentar cada bloque para ver cada uno de los ejercicios.\n");

//T1.5
// Console.WriteLine("Ingrese el precio del boleto: ");
// int precio_del_boleto = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el número inicial de los boletos: ");
// int boleto_de_salida = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese número final del boleto: ");
// int boleto_de_llegada = int.Parse(Console.ReadLine());

// int total_de_boletos = boleto_de_llegada - boleto_de_salida;
// int total_recaudado = total_de_boletos * precio_del_boleto;
// Console.WriteLine("La recaudación del día es de: " + total_recaudado);

// TP 1.6
// Console.WriteLine("Ingrese la edad de la primera persona");
// int edad1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la edad de la primera persona");
// int edad2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la edad de la primera persona");
// int edad3 = int.Parse(Console.ReadLine());

// int suma_de_edades = edad1 + edad2 + edad3;
// Console.WriteLine("La suma de las edades es de: " + suma_de_edades);

// float promedio = suma_de_edades/3;
// Console.WriteLine("El promedio de las edades es de: " + promedio);

// TP 1.7
// Console.WriteLine("Ingrese el número a dividir: ");
// int dividendo = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el número divisor: ");
// int divisor = int.Parse(Console.ReadLine());

// if (divisor != 0)
// {
//     float cociente = dividendo/divisor;
//     Math.Truncate(cociente);
//     Console.WriteLine("Cociente: " + cociente);

//     int resto = dividendo % divisor;
//     Console.WriteLine("Resto: "+ resto);

//     double resultado = (divisor * cociente) + resto;

//     Console.WriteLine("El dividendo es igual: (" + divisor + ") divisor * " + cociente + " cociente + resto " + resto);
//     Console.WriteLine("El resultado es " + resultado);
// } else
// {
//     Console.WriteLine("No se puede dividir por 0.");
// }

// TP 1.8
// Random random = new Random();
// int numero_aleatorio = random.Next(1, 10);
// Console.WriteLine("Número aleatorio: " + numero_aleatorio);

// TP 1.9
// Random Random = new Random();
// int NumeroAleatorio = Random.Next(0, 100);
// if (NumeroAleatorio < 10)
// {
//     Console.WriteLine("Número aleatorio: 0" + NumeroAleatorio);
// } else
// {
//     Console.WriteLine("Número aleatorio: " + NumeroAleatorio);
// }

// TP 1.10
// Random Random = new Random();
// int NumeroAleatorio = Random.Next(0, 10000);
// if (NumeroAleatorio < 10)
// {
//     Console.WriteLine("Número aleatorio: 000" + NumeroAleatorio);
// } else if (NumeroAleatorio >= 10 && NumeroAleatorio < 100)
// {
//     Console.WriteLine("Número aleatorio: 00" + NumeroAleatorio);
    
// } else if (NumeroAleatorio >= 100 && NumeroAleatorio < 1000)
// {
//     Console.WriteLine("Número aleatorio: 0" + NumeroAleatorio);
    
// } else
// {
//     Console.WriteLine("Número aleatorio: " + NumeroAleatorio);
// }

// TP 1.11
// Console.WriteLine("Conversor de temperatura de grados Celcius a grados Fahrenheit");
// Console.WriteLine("Ingrese la temperatura en grados Celcius");
// int GradosCelcius = int.Parse(Console.ReadLine());

// float Resultado = (GradosCelcius * 9/5) + 32;
// Console.WriteLine("Los grados Celcius son: " + GradosCelcius + ". Los grados Fahrenheit son: " + Resultado);

// TP 1.13
// Console.WriteLine("Conversor de temperatura de grados Fahrenheit a grados Celcius");
// Console.WriteLine("Ingrese la temperatura en grados Fahrenheit");
// int GradosFahrenheit = int.Parse(Console.ReadLine());

// float Resultado = (GradosFahrenheit - 32) * 5/9;
// Console.WriteLine("Los grados Fahrenheit son: " + GradosFahrenheit + ". Los grados Celcius son: " + Resultado);

// TP 1.14
// const int VelocidadDelSonido = 343;

// Console.WriteLine("Ingrese cuantos segundos pasaron desde que cayó el rayo");
// int SegundosTranscurridos = int.Parse(Console.ReadLine());

// if (SegundosTranscurridos > 0)
// {
//     int DistaciaDelRayo = VelocidadDelSonido * SegundosTranscurridos;
//     Console.WriteLine("El rayo está a una distancia en metros de: " + DistaciaDelRayo);
// } else
// {
//     Console.WriteLine("No puedes ingresar segundos negativos o 0 segundos");
// }

// TP 1.15
// const int MontoPorHijo = 15000;
// const int MontoPorInasistencia = 10000;
// const float PorcentajeParaJubilacion = 0.3F;
// const float PorcentajeParaObraSocial = 0.21F;

// Console.WriteLine("Ingrese el sueldo básico: ");
// int SueldoBasico = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese cantidad de hijos, coloque 0 en caso de no tener");
// int CantidadDeHijos = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese cantidad de inasistencias, coloque 0 en caso de no tener");
// int CantidadDeInasistencias = int.Parse(Console.ReadLine());

// float SueldoNeto = SueldoBasico + (CantidadDeHijos * MontoPorHijo) - (SueldoBasico * PorcentajeParaJubilacion) - (SueldoBasico * PorcentajeParaObraSocial) - (MontoPorInasistencia * CantidadDeInasistencias);
// Console.WriteLine("El sueldo neto es de: " + SueldoNeto);

// TP 1.16
// Console.WriteLine("Ingrese el lado del tetraedro");
// int a = int.Parse(Console.ReadLine());

// double area = Math.Sqrt(3) * Math.Pow(a, 2);
// double volumen = Math.Sqrt(2)/12 * Math.Pow(a,3);

// Console.WriteLine("El área del tetraedro es de: " + area);
// Console.WriteLine("El volumen del tetraedro es de: " + volumen);

// TP 1.17
// Console.WriteLine("Ingrese el lado del octaedro");
// int a = int.Parse(Console.ReadLine());

// double area = Math.Sqrt(3) * Math.Pow(a, 2);
// double volumen = Math.Sqrt(2)/3 * Math.Pow(a,3);

// Console.WriteLine("El área del octaedro es de: " + area);
// Console.WriteLine("El volumen del octaedro es de: " + volumen);

// TP 1.18
// Console.WriteLine("Ingrese el lado del isocaedro");
// int a = int.Parse(Console.ReadLine());

// double area = 5 * Math.Sqrt(3) * Math.Pow(a, 2);

// double volumen = Math.Sqrt(5)/12 * (3 * Math.Sqrt(5)) * Math.Pow(a,3);

// Console.WriteLine("El área del isocaedro es de: " + area);
// Console.WriteLine("El volumen del isocaedro es de: " + volumen);

// TP 1.19
// Console.WriteLine("Ingrese el lado del cubo");
// int a = int.Parse(Console.ReadLine());

// double area = 6 * Math.Pow(a, 2);
// double volumen = Math.Pow(a,3);

// Console.WriteLine("El área del cubo es de: " + area);
// Console.WriteLine("El volumen del cubo es de: " + volumen);


// TP 1.20
// Console.WriteLine("Ingrese el radio del cilindro");
// int radio = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del cilindro");
// int altura = int.Parse(Console.ReadLine());

// double area = 2 * Math.PI * radio * (altura * radio);
// double volumen = Math.PI * Math.Pow(radio, 2) * altura;

// Console.WriteLine("El área del cilindro es de: " + area);
// Console.WriteLine("El volumen del cilindro es de: " + volumen);

// TP 1.21
// Console.WriteLine("Ingrese el radio del cono");
// int radio = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del cono");
// int altura = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la pendiente del cono");
// int pendiente = int.Parse(Console.ReadLine());

// double area = 2 * Math.PI * radio * (pendiente * radio);
// double volumen = (Math.PI * Math.Pow(radio, 2) * altura)/3;

// Console.WriteLine("El área del cono es de: " + area);
// Console.WriteLine("El volumen del cono es de: " + volumen);

// TP 1.22
// Console.WriteLine("Ingrese el radio menor del cono");
// int radio = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el radio mayor del cono");
// int RadioMayor = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del cono");
// int altura = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la pendiente del cono");
// int pendiente = int.Parse(Console.ReadLine());

// double area = 2 * Math.PI * (pendiente * (RadioMayor + radio) + Math.Pow(RadioMayor, 2) + Math.Pow(radio, 2));
// double volumen = (Math.PI * altura * (Math.Pow(RadioMayor, 2) + Math.Pow(radio, 2) + RadioMayor + radio))/3;

// Console.WriteLine("El área del cono es de: " + area);
// Console.WriteLine("El volumen del cono es de: " + volumen);

// TP 1.23
// Console.WriteLine("Ingrese el radio de la esfera");
// int radio = int.Parse(Console.ReadLine());

// double area = 2 * Math.PI * radio * 4;
// double volumen = Math.PI * Math.Pow(radio, 2) * 4/3;

// Console.WriteLine("El área de la esfera es de: " + area);
// Console.WriteLine("El volumen de la esfera es de: " + volumen);

// TP 1.24
// Console.WriteLine("Ingrese el radio del casquete");
// int radio = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del casquete");
// int altura = int.Parse(Console.ReadLine());

// double RadioTotal = (Math.Pow(radio,2) + Math.Pow(altura, 2))/2 * altura;

// double area = 2 * Math.PI * RadioTotal * altura;
// double volumen = Math.PI * Math.Pow(altura, 2) * (3 * RadioTotal - altura)/3;

// Console.WriteLine("El área del casquete es de: " + area);
// Console.WriteLine("El volumen del casquete es de: " + volumen);

// TODO: Ver el tema de el punto 25

// TP 1.26
// Console.WriteLine("Ingrese el lado del cuadrado");
// int lado = int.Parse(Console.ReadLine());

// double area = Math.Pow(lado, 2);
// double perimetro = 4 * lado;

// Console.WriteLine("El área del cuadrado es de: " + area);
// Console.WriteLine("El perímetro del cuadrado es de: " + perimetro);

// TP 1.27
// Console.WriteLine("Ingrese la base del rectángulo");
// int Base = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del rectángulo");
// int altura = int.Parse(Console.ReadLine());

// double area = Base * altura;
// double perimetro = (2 * Base) + (2 * altura);

// Console.WriteLine("El área del rectángulo es de: " + area);
// Console.WriteLine("El perímetro del rectángulo es de: " + perimetro);

// TP 1.28
// Console.WriteLine("Ingrese la base del paralelogramo");
// int Base = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del paralelogramo");
// int altura = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la diagonal del paralelogramo");
// int diagonal = int.Parse(Console.ReadLine());

// double area = Base * altura;
// double perimetro = (2 * Base) + (2 * diagonal);

// Console.WriteLine("El área del paralelogramo es de: " + area);
// Console.WriteLine("El perímetro del paralelogramo es de: " + perimetro);

// TP 1.29
// Console.WriteLine("Ingrese lado del rombo");
// int lado = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la diagonal mayor del rombo");
// int DiagonalMayor = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la diagonal menor del rombo");
// int diagonal = int.Parse(Console.ReadLine());

// double area = (diagonal * DiagonalMayor)/2;
// double perimetro = 4 * lado;

// Console.WriteLine("El área del rombo es de: " + area);
// Console.WriteLine("El perímetro del rombo es de: " + perimetro);

// TP 1.30
// Console.WriteLine("Ingrese base menor del trapecio");
// int Base = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese base mayor del trapecio");
// int BaseMayor = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese primera diagonal del trapecio");
// int DiagonalUno = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la segunda diagonal del trapecio");
// int DiagonalDos = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del paralelogramo");
// int altura = int.Parse(Console.ReadLine());

// double area = ((Base * BaseMayor)/2) * altura;
// double perimetro = Base + BaseMayor + DiagonalUno + DiagonalDos;

// Console.WriteLine("El área del paralelogramo es de: " + area);
// Console.WriteLine("El perímetro del paralelogramo es de: " + perimetro);

// TP 1.31
// Console.WriteLine("Ingrese base menor del trapecio");
// int Base = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese base mayor del trapecio");
// int BaseMayor = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la diagonal del trapecio");
// int Diagonal = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del paralelogramo");
// int altura = int.Parse(Console.ReadLine());

// double area = ((Base * BaseMayor)/2) * altura;
// double perimetro = Base + BaseMayor + Diagonal;

// Console.WriteLine("El área del paralelogramo es de: " + area);
// Console.WriteLine("El perímetro del paralelogramo es de: " + perimetro);

// TP 1.32 - 1,35
// Console.WriteLine("¿Qué tipo de triángulo es? Equilatero (1), Isóceles (2), Escaleno (3). Ingrese número del triángulo para pedir las magnitudes: ");
// int TipoTriangulo = int.Parse(Console.ReadLine());

// Console.WriteLine("¿El triángulo tiene un ángulo recto? Ingrese 1 si lo tiene, 0 si no lo tiene ");
// int AnguloRecto = int.Parse(Console.ReadLine());

// int area;
// int perimetro;

// switch (TipoTriangulo)
// {
//     case 1:
//         Console.WriteLine("Ingrese el lado del triángulo");
//         int lado = int.Parse(Console.ReadLine());
//         Console.WriteLine("Ingrese la altura del triángulo");
//         int altura = int.Parse(Console.ReadLine());

//         area = (lado * altura)/2;
//         perimetro = 3 * lado;
//         break;
//     case 2:
//         Console.WriteLine("Ingrese la base del triángulo");
//         int Base = int.Parse(Console.ReadLine());
//         Console.WriteLine("Ingrese el lado del triángulo");
//         int LadoMenor = int.Parse(Console.ReadLine());
//         Console.WriteLine("Ingrese la altura del triángulo");
//         int AlturaIsoceles = int.Parse(Console.ReadLine());

//         area = LadoMenor * AlturaIsoceles/2;
//         perimetro = (2 * LadoMenor) + Base;
//         break;
//     case 3:
//         Console.WriteLine("Ingrese el lado menor del triángulo");
//         int ladoMenor = int.Parse(Console.ReadLine());
//         Console.WriteLine("Ingrese el lado mayor del triángulo");
//         int LadoMayor = int.Parse(Console.ReadLine());
//         Console.WriteLine("Ingrese el tercer lado del triángulo");
//         int TercerLado = int.Parse(Console.ReadLine());
//         Console.WriteLine("Ingrese la altura del triángulo");
//         int Altura = int.Parse(Console.ReadLine());
//         if (AnguloRecto == 0)
//         {
//             area = ladoMenor * Altura/2;
//             perimetro = LadoMayor + ladoMenor + TercerLado;
//         } else
//         {
//             area = ladoMenor * LadoMayor/2;
//             perimetro = LadoMayor + ladoMenor + TercerLado;
//         }
//         break;
//     default:
//         Console.WriteLine("Opción inválida.");
//         return;
// }

// Console.WriteLine("El área del triángulo es de: " + area);
// Console.WriteLine("El área del perímetro es de: " + perimetro);

// TP 1.36
// Console.WriteLine("Ingrese la base del lado del pentágono");
// int Base = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del triangulo interno del pentágono");
// int altura = int.Parse(Console.ReadLine());

// int area = 5 * Base * altura/2;
// int perimetro = 5 * Base;

// Console.WriteLine("El área del triángulo es de: " + area);
// Console.WriteLine("El área del perímetro es de: " + perimetro);

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

// TP 1.38
// Console.WriteLine("Ingrese el radio interno de la corona circular: ");
// int RadioInterno = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el radio externo de la corona circular: ");
// int RadioExterno = int.Parse(Console.ReadLine());

// double area = Math.PI * (Math.Pow(RadioInterno, 2) * Math.Pow(RadioInterno, 2));
// double perimetro = 2 * Math.PI * (RadioInterno * RadioExterno);

// Console.WriteLine("El area de la corona circular es de: " + area);
// Console.WriteLine("El area de la corona circular es de:" + perimetro);

// TP 1.39
// Console.WriteLine("Ingrese lado vertical de la elipse: ");
// int LadoVertical = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el lado horizontal de la elipse: ");
// int LadoHorizontal = int.Parse(Console.ReadLine());

// double area = Math.PI * LadoHorizontal * LadoVertical;
// double perimetro = Math.PI * (LadoVertical + LadoHorizontal);

// Console.WriteLine("El area de la elipse es de: " + area);
// Console.WriteLine("El area de la elipse es de:" + perimetro);

// TP 1.40
// Console.WriteLine("Ingrese diametro Mayor del toro: ");
// int DiametroMayor = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el diametro menor del toro: ");
// int DiametroMenor = int.Parse(Console.ReadLine());

// double area = Math.Pow(Math.PI,2) * DiametroMayor * DiametroMenor;
// double perimetro = Math.Pow(Math.PI,2)/4 * (DiametroMayor + DiametroMenor);

// Console.WriteLine("El area del toro es de: " + area);
// Console.WriteLine("El area del toro es de:" + perimetro);

// TP 1.41
// Console.WriteLine("Ingrese el lado del dodecaedro: ");
// int Lado = int.Parse(Console.ReadLine());

// double area = 3 * Math.Sqrt(25  + 10 * Math.Sqrt(5)) * Math.Pow(Lado, 2);
// double volumen = (15 + 7 * Math.Sqrt(5))/4 * Math.Pow(Lado, 3) ;

// Console.WriteLine("El area del dodecaedro es de: " + area);
// Console.WriteLine("El volumen del dodecaedro es de:" + volumen);

// TP 1.42
// Console.WriteLine("Ingrese el lado del prisma recto: ");
// int Lado = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la profundidad del prisma recto: ");
// int Profundidad = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del prisma recto: ");
// int Altura = int.Parse(Console.ReadLine());

// double area = (2 * Lado * Profundidad) + (2 * Lado * Altura) + (2 * Profundidad * Altura);
// double volumen = Lado * Profundidad * Altura;

// Console.WriteLine("El area del prisma recto es de: " + area);
// Console.WriteLine("El volumen del prisma recto es de:" + volumen);


// TP 1.43
// Console.WriteLine("Ingrese el lado del polígono regular: ");
// int Lado = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese número de lados del polígono regular: ");
// int NumeroDeLados = int.Parse(Console.ReadLine());

// int perimetro = NumeroDeLados * Lado;
// Console.WriteLine("El perímetro del polígono es de: " + perimetro);

// TP 1.44
const int PartidoGanado = 3;
const int PartidoEmpatado = 1;
const int PartidoPerdido = 0l

Console.WriteLine("Ingrese la cantidad de partidos ganados: ");
int PartidosGanados = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de partidos empatados: ");
int PartidosEmpatados = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de partidos perdidos: ");
int PartidosPerdidos = int.Parse(Console.ReadLine());

int PuntosTotales = (PartidosGanados * PartidoGanado) + (PartidosEmpatados * PartidoEmpatadp) + (PartidosPerdidos * PartidoPerdido);
Console.WriteLine("La cantidad de puntos del equipo son de: " + PuntosTotales);

int PartidosJugados = PartidosGanados + PartidosEmpatados + PartidosPerdidos;
float Promedio = PuntosTotales / PartidosJugados;
Console.WriteLine("El promedio del equipo es de: " + Promedio);

// TP 1.46
const int Billete2 = 2;
const int Billete5 = 5;
const int Billete10 = 10;
const int Billete20 = 20;
const int Billete50 = 50;
const int Billete100 = 100;

Console.WriteLine("Ingrese la cantidad de billetes de $2: ");
int CantidadDeBillete2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de billetes de $5: ");
int CantidadDeBillete5 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de billetes de $10: ");
int CantidadDeBillete10 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de billetes de $20: ");
int CantidadDeBillete20 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de billetes de $50: ");
int CantidadDeBillete50 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de billetes de $100: ");
int CantidadDeBillete100 = int.Parse(Console.ReadLine());

int TotalRecaudado = (Billete2 * CantidadDeBillete2) + (Billete5 * CantidadDeBillete5) + (Billete10 * CantidadDeBillete10) + (Billete20 * CantidadDeBillete20) + (Billete50 * CantidadDeBillete50) + (Billete100 * CantidadDeBillete100);
Console.WriteLine("El monto total recaudado es de: $" + TotalRecaudado);

// TP 1.47
const int DistanciaDeFicha = 100;

Console.WriteLine("Ingrese la bajada de línea del taxi: ");
int BajadaDeBandera = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el valor de la ficha cada cien metros: ");
int ValorDeFichaCienMetros = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la distancia recorrida en metros: ");
int DistanciaRecorrida = int.Parse(Console.ReadLine());

float CantidadDeFichas = DistanciaRecorrida / DistanciaDeFicha;
float CostoTotalViaje = BajadaDeBandera + (ValorDeFichaCienMetros * CantidadDeFichas);
Console.WriteLine("La cantidad de fichas usadas en el viaje es de: " + CantidadDeFichas);
Console.WriteLine("El valor total del viaje es de: " + CostoTotalViaje);

// TP 1.48
Random random = new Random();
int NumeroDeTresCifras = random.Next(100, 1000);
Console.WriteLine("El número es de: " + NumeroDeTresCifras);

string Centena = NumeroDeTresCifras.toString()[0];
Console.WriteLine("La Centena del número es de: " + Cetena + "00");
string Decena = NumeroDeTresCifras.toString()[1];
Console.WriteLine("La Decena del número es de: " + Decena + "0");
string Unidad = NumeroDeTresCifras.toString()[2];
Console.WriteLine("La unidad del número es de: " + Unidad);

// TP 1.49
Console.WriteLine("Ingrese el nombre del producto: ");
string NombreDelProducto = Console.ReadLine();

Console.WriteLine("Ingrese precio unitario producto: ");
float PrecioUnitario = float.Parse(Console.ReadLine()); // TODO(ivan): Verificar esto

Console.WriteLine("Ingrese cantidad que va a comprar del producto: ");
int CantidadDelProducto = int.Parse(Console.ReadLine());

float MontoTotal = PrecioUnitario * CantidadDelProducto;
Console.WriteLine("Para poder llevar a cabo la compra de " + CantidadDelProducto + " unidades de " + NombreDelProducto + " a " + PrecioUnitario + "cada una debe disponer de $" + MontoTotal);

// TP 1.50
const float Interes = 0.08F;
const int Cuotas = 6;

Console.WriteLine("Esta por realizar una compra con tarjeta de crédito a 6 cuotas.");
Console.WriteLine("Ingrese el monto de la compra: ");
int MontoCompra = int.Parse(Console.ReadLine());

float ValorCuota = (MontoCompra / Cuotas);
float ValorInteres = (MontoCompra / Cuotas) * Interes;
float ValorTotal = ValorCuota + ValorInteres;
Console.WriteLine("El valor de la cuota serä de: " + ValorTotal);

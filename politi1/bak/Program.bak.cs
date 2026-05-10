// Saludo inicial
Console.WriteLine("Esto es el programa para resolver el TP1.\nTiene que desconmentar cada bloque para ver cada uno de los ejercicios.\n");

//T1.5
// int precio_del_boleto;
// int boleto_de_salida;
// int total_de_boletos;
// int total_recaudado;

// Console.WriteLine("Ingrese el precio del boleto: ");
// precio_del_boleto = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el número inicial de los boletos: ");
// boleto_de_salida = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese número final del boleto: ");
// boleto_de_llegada = int.Parse(Console.ReadLine());

// total_de_boletos = boleto_de_llegada - boleto_de_salida;
// total_recaudado = total_de_boletos * precio_del_boleto;
// Console.WriteLine("La recaudación del día es de: " + total_recaudado);

// TP 1.6
// int edad1;
// int edad2:
// int edad3;
// int suma_de_edades
// float promedio;

// Console.WriteLine("Ingrese la edad de la primera persona");
// edad1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la edad de la primera persona");
// edad2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la edad de la primera persona");
// edad3 = int.Parse(Console.ReadLine());

// suma_de_edades = edad1 + edad2 + edad3;
// Console.WriteLine("La suma de las edades es de: " + suma_de_edades);

// promedio = suma_de_edades/3;
// Console.WriteLine("El promedio de las edades es de: " + promedio);

// TP 1.7
// int dividendo;
// int divisor;
// float cociente;
// int resto;
// double resultado;

// Console.WriteLine("Ingrese el número a dividir: ");
// dividendo = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el número divisor: ");
// divisor = int.Parse(Console.ReadLine());

// if (divisor != 0)
// {
//     cociente = dividendo/divisor;
//     Math.Truncate(cociente);
//     Console.WriteLine("Cociente: " + cociente);

//     resto = dividendo % divisor;
//     Console.WriteLine("Resto: "+ resto);

//     resultado = (divisor * cociente) + resto;

//     Console.WriteLine("El dividendo es igual: (" + divisor + ") divisor * " + cociente + " cociente + resto " + resto);
//     Console.WriteLine("El resultado es " + resultado);
// } else
// {
//     Console.WriteLine("No se puede dividir por 0.");
// }

// TP 1.8
// int numero_aleatorio;

// Random random = new Random();
// numero_aleatorio = random.Next(1, 10);
// Console.WriteLine("Número aleatorio: " + numero_aleatorio);

// TP 1.9
// int NumeroAleatorio;

// Random Random = new Random();
// NumeroAleatorio = Random.Next(0, 100);
// if (NumeroAleatorio < 10)
// {
//     Console.WriteLine("Número aleatorio: 0" + NumeroAleatorio);
// } else
// {
//     Console.WriteLine("Número aleatorio: " + NumeroAleatorio);
// }

// TP 1.10
// int NumeroAleatorio;

// Random Random = new Random();
// NumeroAleatorio = Random.Next(0, 10000);
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
// int GradosFahrenheit;
// float Resultado;
// Console.WriteLine("Conversor de temperatura de grados Fahrenheit a grados Celcius");
// Console.WriteLine("Ingrese la temperatura en grados Fahrenheit");
// GradosFahrenheit = int.Parse(Console.ReadLine());

// Resultado = (GradosFahrenheit - 32) * 5/9;
// Console.WriteLine("Los grados Fahrenheit son: " + GradosFahrenheit + ". Los grados Celcius son: " + Resultado);

// TP 1.14
// const int VelocidadDelSonido = 343;
// int SegundosTranscurridos;
// int DistaciaDelRayo;
// Console.WriteLine("Ingrese cuantos segundos pasaron desde que cayó el rayo");
// int SegundosTranscurridos = int.Parse(Console.ReadLine());

// if (SegundosTranscurridos > 0)
// {
//     DistaciaDelRayo = VelocidadDelSonido * SegundosTranscurridos;
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
// int SueldoBasico;
// int CantidadDeHijos;
// int CantidadDeInasistencias;
// float SueldoNeto;
// Console.WriteLine("Ingrese el sueldo básico: ");
// SueldoBasico = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese cantidad de hijos, coloque 0 en caso de no tener");
// CantidadDeHijos = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese cantidad de inasistencias, coloque 0 en caso de no tener");
// CantidadDeInasistencias = int.Parse(Console.ReadLine());

// SueldoNeto = SueldoBasico + (CantidadDeHijos * MontoPorHijo) - (SueldoBasico * PorcentajeParaJubilacion) - (SueldoBasico * PorcentajeParaObraSocial) - (MontoPorInasistencia * CantidadDeInasistencias);
// Console.WriteLine("El sueldo neto es de: " + SueldoNeto);

// TP 1.16
// int a;
// double area;
// double volumen;

// Console.WriteLine("Ingrese el lado del tetraedro");
// a = int.Parse(Console.ReadLine());

// area = Math.Sqrt(3) * Math.Pow(a, 2);
// volumen = Math.Sqrt(2)/12 * Math.Pow(a,3);

// Console.WriteLine("El área del tetraedro es de: " + area);
// Console.WriteLine("El volumen del tetraedro es de: " + volumen);

// TP 1.17
// int a;
// double area;
// double volumen;

// Console.WriteLine("Ingrese el lado del octaedro");
// a = int.Parse(Console.ReadLine());

// area = Math.Sqrt(3) * Math.Pow(a, 2);
// volumen = Math.Sqrt(2)/3 * Math.Pow(a,3);

// Console.WriteLine("El área del octaedro es de: " + area);
// Console.WriteLine("El volumen del octaedro es de: " + volumen);

// TP 1.18
// int a;
// double area;
// double volumen;

// Console.WriteLine("Ingrese el lado del isocaedro");
// a = int.Parse(Console.ReadLine());

// area = 5 * Math.Sqrt(3) * Math.Pow(a, 2);

// volumen = Math.Sqrt(5)/12 * (3 * Math.Sqrt(5)) * Math.Pow(a,3);

// Console.WriteLine("El área del isocaedro es de: " + area);
// Console.WriteLine("El volumen del isocaedro es de: " + volumen);

// TP 1.19
// int a;
// double area;
// double volumen;

// Console.WriteLine("Ingrese el lado del cubo");
// a = int.Parse(Console.ReadLine());

// area = 6 * Math.Pow(a, 2);
// volumen = Math.Pow(a,3);

// Console.WriteLine("El área del cubo es de: " + area);
// Console.WriteLine("El volumen del cubo es de: " + volumen);


// TP 1.20
// int radio;
// int altura;
// double area;
// double volumen;

// Console.WriteLine("Ingrese el radio del cilindro");
// radio = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del cilindro");
// altura = int.Parse(Console.ReadLine());

// area = 2 * Math.PI * radio * (altura * radio);
// volumen = Math.PI * Math.Pow(radio, 2) * altura;

// Console.WriteLine("El área del cilindro es de: " + area);
// Console.WriteLine("El volumen del cilindro es de: " + volumen);

// TP 1.21
// int radio;
// int altura;
// int pendiente;
// double area;
// double volumen;

// Console.WriteLine("Ingrese el radio del cono");
// radio = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del cono");
// altura = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la pendiente del cono");
// pendiente = int.Parse(Console.ReadLine());

// area = 2 * Math.PI * radio * (pendiente * radio);
// volumen = (Math.PI * Math.Pow(radio, 2) * altura)/3;

// Console.WriteLine("El área del cono es de: " + area);
// Console.WriteLine("El volumen del cono es de: " + volumen);

// TP 1.22
// int radio;
// int altura;
// double area;
// double volumen;

// Console.WriteLine("Ingrese el radio menor del cono");
// radio = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el radio mayor del cono");
// RadioMayor = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del cono");
// altura = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la pendiente del cono");
// pendiente = int.Parse(Console.ReadLine());

// area = 2 * Math.PI * (pendiente * (RadioMayor + radio) + Math.Pow(RadioMayor, 2) + Math.Pow(radio, 2));
// volumen = (Math.PI * altura * (Math.Pow(RadioMayor, 2) + Math.Pow(radio, 2) + RadioMayor + radio))/3;

// Console.WriteLine("El área del cono es de: " + area);
// Console.WriteLine("El volumen del cono es de: " + volumen);

// TP 1.23
// int radio;
// double area;
// double volumen;

// Console.WriteLine("Ingrese el radio de la esfera");
// radio = int.Parse(Console.ReadLine());

// area = 2 * Math.PI * radio * 4;
// volumen = Math.PI * Math.Pow(radio, 2) * 4/3;

// Console.WriteLine("El área de la esfera es de: " + area);
// Console.WriteLine("El volumen de la esfera es de: " + volumen);

// TP 1.24
// int radio;
// int altura;
// double RadioTotal;
// double area;
// double volumen;

// Console.WriteLine("Ingrese el radio del casquete");
// radio = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del casquete");
// altura = int.Parse(Console.ReadLine());

// RadioTotal = (Math.Pow(radio,2) + Math.Pow(altura, 2))/2 * altura;

// area = 2 * Math.PI * RadioTotal * altura;
// volumen = Math.PI * Math.Pow(altura, 2) * (3 * RadioTotal - altura)/3;

// Console.WriteLine("El área del casquete es de: " + area);
// Console.WriteLine("El volumen del casquete es de: " + volumen);

// TODO: Ver el tema de el punto 25

// TP 1.26
// int lado;
// double area;
// double volumen;

// Console.WriteLine("Ingrese el lado del cuadrado");
// lado = int.Parse(Console.ReadLine());

// area = Math.Pow(lado, 2);
// perimetro = 4 * lado;

// Console.WriteLine("El área del cuadrado es de: " + area);
// Console.WriteLine("El perímetro del cuadrado es de: " + perimetro);

// TP 1.27
// int Base;
// int altura;
// double area;
// double volumen;

// Console.WriteLine("Ingrese la base del rectángulo");
// Base = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del rectángulo");
// altura = int.Parse(Console.ReadLine());

// area = Base * altura;
// perimetro = (2 * Base) + (2 * altura);

// Console.WriteLine("El área del rectángulo es de: " + area);
// Console.WriteLine("El perímetro del rectángulo es de: " + perimetro);

// TP 1.28
// int Base;
// int altura;
// int diagonal;
// double area;
// double volumen;

// Console.WriteLine("Ingrese la base del paralelogramo");
// Base = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del paralelogramo");
// altura = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la diagonal del paralelogramo");
// diagonal = int.Parse(Console.ReadLine());

// area = Base * altura;
// perimetro = (2 * Base) + (2 * diagonal);

// Console.WriteLine("El área del paralelogramo es de: " + area);
// Console.WriteLine("El perímetro del paralelogramo es de: " + perimetro);

// TP 1.29
// int lado;
// int DiagonalMayor;
// int diagonal;
// double area;
// double volumen;

// Console.WriteLine("Ingrese lado del rombo");
// lado = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la diagonal mayor del rombo");
// DiagonalMayor = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la diagonal menor del rombo");
// diagonal = int.Parse(Console.ReadLine());

// area = (diagonal * DiagonalMayor)/2;
// perimetro = 4 * lado;

// Console.WriteLine("El área del rombo es de: " + area);
// Console.WriteLine("El perímetro del rombo es de: " + perimetro);

// TP 1.30
// int Base;
// int BaseMayor;
// int DiagonalUno;
// int DiagonalDos;
// int altura;
// double area;
// double volumen;

// Console.WriteLine("Ingrese base menor del trapecio");
// Base = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese base mayor del trapecio");
// BaseMayor = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese primera diagonal del trapecio");
// DiagonalUno = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la segunda diagonal del trapecio");
// DiagonalDos = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del paralelogramo");
// altura = int.Parse(Console.ReadLine());

// area = ((Base * BaseMayor)/2) * altura;
// perimetro = Base + BaseMayor + DiagonalUno + DiagonalDos;

// Console.WriteLine("El área del paralelogramo es de: " + area);
// Console.WriteLine("El perímetro del paralelogramo es de: " + perimetro);

// TP 1.31
// int Base;
// int BaseMayor;
// int Diagonal;
// int altura;
// double area;
// double volumen;

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
// int TipoTriangulo;
// int AnguloRecto;
// int area;
// int perimetro;

// Console.WriteLine("¿Qué tipo de triángulo es? Equilatero (1), Isóceles (2), Escaleno (3). Ingrese número del triángulo para pedir las magnitudes: ");
// TipoTriangulo = int.Parse(Console.ReadLine());

// Console.WriteLine("¿El triángulo tiene un ángulo recto? Ingrese 1 si lo tiene, 0 si no lo tiene ");
// AnguloRecto = int.Parse(Console.ReadLine());

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
// int Base;
// int altura;
// int area:
// int perimetro;
// Console.WriteLine("Ingrese la base del lado del pentágono");
// Base = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del triangulo interno del pentágono");
// altura = int.Parse(Console.ReadLine());

// area = 5 * Base * altura/2;
// perimetro = 5 * Base;

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
// int RadioInterno;
// int RadioExterno;
// double area;
// double perimetro;
// Console.WriteLine("Ingrese el radio interno de la corona circular: ");
// RadioInterno = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el radio externo de la corona circular: ");
// RadioExterno = int.Parse(Console.ReadLine());

// area = Math.PI * (Math.Pow(RadioInterno, 2) * Math.Pow(RadioInterno, 2));
// perimetro = 2 * Math.PI * (RadioInterno * RadioExterno);

// Console.WriteLine("El area de la corona circular es de: " + area);
// Console.WriteLine("El area de la corona circular es de:" + perimetro);

// TP 1.39
// int LadoVertical;
// int LadoHorizontal;
// double area;
// double perimetro;

// Console.WriteLine("Ingrese lado vertical de la elipse: ");
// int LadoVertical = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el lado horizontal de la elipse: ");
// int LadoHorizontal = int.Parse(Console.ReadLine());

// double area = Math.PI * LadoHorizontal * LadoVertical;
// double perimetro = Math.PI * (LadoVertical + LadoHorizontal);

// Console.WriteLine("El area de la elipse es de: " + area);
// Console.WriteLine("El area de la elipse es de:" + perimetro);

// TP 1.40
// int DiametroMayor;
// int DiametroMenor;
// double area;
// double perimetro;

// Console.WriteLine("Ingrese diametro Mayor del toro: ");
// int DiametroMayor = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el diametro menor del toro: ");
// int DiametroMenor = int.Parse(Console.ReadLine());

// double area = Math.Pow(Math.PI,2) * DiametroMayor * DiametroMenor;
// double perimetro = Math.Pow(Math.PI,2)/4 * (DiametroMayor + DiametroMenor);

// Console.WriteLine("El area del toro es de: " + area);
// Console.WriteLine("El area del toro es de:" + perimetro);

// TP 1.41
// int Lado;
// double area;
// double volumen;
// Console.WriteLine("Ingrese el lado del dodecaedro: ");
// Lado = int.Parse(Console.ReadLine());

// area = 3 * Math.Sqrt(25  + 10 * Math.Sqrt(5)) * Math.Pow(Lado, 2);
// volumen = (15 + 7 * Math.Sqrt(5))/4 * Math.Pow(Lado, 3) ;

// Console.WriteLine("El area del dodecaedro es de: " + area);
// Console.WriteLine("El volumen del dodecaedro es de:" + volumen);

// TP 1.42
// int Lado;
// int Profundidad;
// int Altura;
// double area;
// double volumen;

// Console.WriteLine("Ingrese el lado del prisma recto: ");
// Lado = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la profundidad del prisma recto: ");
// Profundidad = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la altura del prisma recto: ");
// Altura = int.Parse(Console.ReadLine());

// area = (2 * Lado * Profundidad) + (2 * Lado * Altura) + (2 * Profundidad * Altura);
// volumen = Lado * Profundidad * Altura;

// Console.WriteLine("El area del prisma recto es de: " + area);
// Console.WriteLine("El volumen del prisma recto es de:" + volumen);


// TP 1.43
// int Lado;
// int NumeroDeLados;
// int Altura;
// double area;
// double perimetro;

// Console.WriteLine("Ingrese el lado del polígono regular: ");
// Lado = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese número de lados del polígono regular: ");
// NumeroDeLados = int.Parse(Console.ReadLine());

// perimetro = NumeroDeLados * Lado;
// Console.WriteLine("El perímetro del polígono es de: " + perimetro);

// TP 1.44
// const int PartidoGanado = 3;
// const int PartidoEmpatado = 1;
// const int PartidoPerdido = 0l
// int PartidosGanados;
// int PartidosEmpatados;
// int PartidosPerdidos;
// int PuntosTotales;
// int PartidosJugados;
// float Promedio;

// Console.WriteLine("Ingrese la cantidad de partidos ganados: ");
// PartidosGanados = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la cantidad de partidos empatados: ");
// PartidosEmpatados = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la cantidad de partidos perdidos: ");
// PartidosPerdidos = int.Parse(Console.ReadLine());

// PuntosTotales = (PartidosGanados * PartidoGanado) + (PartidosEmpatados * PartidoEmpatadp) + (PartidosPerdidos * PartidoPerdido);
// Console.WriteLine("La cantidad de puntos del equipo son de: " + PuntosTotales);

// PartidosJugados = PartidosGanados + PartidosEmpatados + PartidosPerdidos;
// Promedio = PuntosTotales / PartidosJugados;
// Console.WriteLine("El promedio del equipo es de: " + Promedio);

// TP 1.46
// const int Billete2 = 2;
// const int Billete5 = 5;
// const int Billete10 = 10;
// const int Billete20 = 20;
// const int Billete50 = 50;
// const int Billete100 = 100;
// int CantidadDeBillete2;
// int CantidadDeBillete5;
// int CantidadDeBillete10;
// int CantidadDeBillete20;
// int CantidadDeBillete50;
// int CantidadDeBillete100;
// int TotalRecaudado;

// Console.WriteLine("Ingrese la cantidad de billetes de $2: ");
// CantidadDeBillete2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la cantidad de billetes de $5: ");
// CantidadDeBillete5 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la cantidad de billetes de $10: ");
// CantidadDeBillete10 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la cantidad de billetes de $20: ");
// CantidadDeBillete20 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la cantidad de billetes de $50: ");
// CantidadDeBillete50 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la cantidad de billetes de $100: ");
// CantidadDeBillete100 = int.Parse(Console.ReadLine());

// TotalRecaudado = (Billete2 * CantidadDeBillete2) + (Billete5 * CantidadDeBillete5) + (Billete10 * CantidadDeBillete10) + (Billete20 * CantidadDeBillete20) + (Billete50 * CantidadDeBillete50) + (Billete100 * CantidadDeBillete100);
// Console.WriteLine("El monto total recaudado es de: $" + TotalRecaudado);

// TP 1.47
// const int DistanciaDeFicha = 100;
// int BajadaDeBandera;
// int ValorDeFichaCienMetros;
// int DistanciaRecorrida;
// float CantidadDeFichas;
// float CostoTotalViaje;

// Console.WriteLine("Ingrese la bajada de línea del taxi: ");
// BajadaDeBandera = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el valor de la ficha cada cien metros: ");
// ValorDeFichaCienMetros = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese la distancia recorrida en metros: ");
// DistanciaRecorrida = int.Parse(Console.ReadLine());

// CantidadDeFichas = DistanciaRecorrida / DistanciaDeFicha;
// CostoTotalViaje = BajadaDeBandera + (ValorDeFichaCienMetros * CantidadDeFichas);
// Console.WriteLine("La cantidad de fichas usadas en el viaje es de: " + CantidadDeFichas);
// Console.WriteLine("El valor total del viaje es de: " + CostoTotalViaje);

// TP 1.48
// int NumeroDeTresCifras;
// string Centena;
// string Decena;
// string Unidad;

// Random random = new Random();
// int NumeroDeTresCifras = random.Next(100, 1000);
// Console.WriteLine("El número es de: " + NumeroDeTresCifras);

// Centena = NumeroDeTresCifras.toString()[0];
// Console.WriteLine("La Centena del número es de: " + Cetena + "00");
// Decena = NumeroDeTresCifras.toString()[1];
// Console.WriteLine("La Decena del número es de: " + Decena + "0");
// Unidad = NumeroDeTresCifras.toString()[2];
// Console.WriteLine("La unidad del número es de: " + Unidad);

// TP 1.49
// string NombreDelProducto;
// float PrecioUnitario;
// int CantidadDelProducto;
// float MontoTotal;
// Console.WriteLine("Ingrese el nombre del producto: ");
// NombreDelProducto = Console.ReadLine();

// Console.WriteLine("Ingrese precio unitario producto: ");
// PrecioUnitario = float.Parse(Console.ReadLine()); // TODO(ivan): Verificar esto

// Console.WriteLine("Ingrese cantidad que va a comprar del producto: ");
// CantidadDelProducto = int.Parse(Console.ReadLine());

// MontoTotal = PrecioUnitario * CantidadDelProducto;
// Console.WriteLine("Para poder llevar a cabo la compra de " + CantidadDelProducto + " unidades de " + NombreDelProducto + " a " + PrecioUnitario + "cada una debe disponer de $" + MontoTotal);

// TP 1.50
/*const float Interes = 0.08F;
const int Cuotas = 6;
int MontoCompra;
float ValorCuota;
float ValorInteres;
float ValorTotal;
*/
/*Console.WriteLine("Esta por realizar una compra con tarjeta de crédito a 6 cuotas.");
Console.WriteLine("Ingrese el monto de la compra: ");
MontoCompra = int.Parse(Console.ReadLine());
*/
/*ValorCuota = (MontoCompra / Cuotas);
ValorInteres = (MontoCompra / Cuotas) * Interes;
ValorTotal = ValorCuota + ValorInteres;
Console.WriteLine("El valor de la cuota será de: " + ValorTotal);
*/
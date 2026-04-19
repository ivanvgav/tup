//# 20260401
//Variable: Espacio en memoria
//	Las variables son mutables. A lo largo del programa la variable puede cambiar el dato que almacena

//	```psint
//	Definir nombre como numero;
//	```
// Puedo hacer esto pero la idea es que las variables no sean confusas
// En este caso deberia ser
// Definir nombre como caracter;
// nombre <- "Facu"

// Escribir "Hola ", nombre
// nombre <- "Bianca"
// Escribir "Hola ", nombre // Aqui el nombre ser� Bianca, fue pisado por el nuevo valor
// Las variables en este caso son globales
// Algoritmo mutacion_de_variable
	//Definir nombre Como Caracter;
	//nombre <- "Facu";
	//Escribir "Hola ", nombre;

	//nombre <- "Bianca";
	//Escribir "Hola ", nombre;
// FinAlgoritmo

//TP 1.5
//Algoritmo recaudador_de_boletos
//	Definir boleto_de_salida Como Entero;
//	Definir boleto_de_llegada Como Entero;
//	Definir precio_del_boleto Como Real;
//	Definir operacion Como Real;
//	//Definir total_de_boletos como Entero;
//	//Definir total_recaudado como Real;
//
//	Escribir "Ingresa el precio del boleto: ";
//	Leer precio_del_boleto;
//
//	Escribir "Ingresa el n�mero inicial de los boletos: ";
//	Leer boleto_de_salida;
//
//	Escribir "Ingresa el n�mero final de los boletos";
//	Leer boleto_de_llegada;
//
//	//total_de_boletos <- boleto_de_llegada - boleto_de_salida;
//	//total_recaudado <- total_de_boletos * precio_del_boleto;
//
//	operacion <- (boleto_de_llegada - boleto_de_salida) * precio_del_boleto;
//	Escribir "La recaudaci�n del d�a es de: $", operacion;
//	//Escribir "La recaudaci�n del d�a es de: $", total_recaudado;
//FinAlgoritmo

//TP 1.6
//Algoritmo promedio_de_edades
//	Definir edad1 Como Entero;
//	Definir edad2 Como Entero;
//	Definir edad3 Como Entero;
//	Definir suma_de_edades Como Entero;
//	Definir promedio Como Real;
//
//	Escribir "Ingrese la edad de la primera persona";
//	Leer edad1;
//	Escribir "Ingrese la edad de la segunda persona";
//	Leer edad2;
//	Escribir "Ingrese la edad de la tercera persona";
//	Leer edad3;
//
//	suma_de_edades <- edad1 + edad2 + edad3;
//	Escribir "La suma de las edades es de: ", suma_de_edades;
//
//	promedio <- suma_de_edades / 3;
//
//	Escribir "El promedio de las edades es de: ", promedio;
//FinAlgoritmo

//TP 1.7
//Condicionales
//if(condicion) { estructura de lo que se tiene que hacer } else if { }
//En pseint: Si <condicion> entonces
//           SiNo
//           FinSi
//Algoritmo verificador_de_edad
//	Definir edad Como Entero;
//
//	edad <- 150;
//	Si edad < 0 Entonces
//		Escribir "Ingrese la edad correcta";
//	SiNo
//		Si edad >=18 Entonces
//			Escribir "Eres mayor de edad";
//		SiNo
//			Escribir "Eres menor de edad";
//		FinSi
//	FinSi
//
//FinAlgoritmo
//Algoritmo dividir
//	Definir dividendo Como Entero;
//	Definir divisor Como Entero;
//	Definir cociente Como Real;
//	Definir resto Como Entero;
//	Definir resultado Como Entero;
//
//	Escribir "Ingrese el n�mero a dividir:";
//	Leer dividendo;
//	Escribir "Ingrese el n�mero divisor:";
//	Leer divisor;
//
//	Si divisor <> 0 Entonces
//		cociente <- trunc(dividendo / divisor);
//		Escribir "Cociente: ", cociente;
//
//		resto <- dividendo mod divisor;
//		Escribir "Resto: ", resto;
//
//		resultado <- (divisor * cociente) + resto;
//		Escribir "El dividendo es igual: ", "(", divisor, " divisor * ", cociente, " cociente ) + ", resto, " resto";
//		Escribir "El resultado: ", resultado;
//	SiNO
//		Escribir "No se puede dividir por 0";
//	FinSi
//
//FinAlgoritmo

//# 20260406
//TP 1.8
//Algoritmo numero_al_azar
//	definir numero como Real;
//
//	numero <- Aleatorio(1,10);
//	Escribir "N�mero aleatorio: ", numero;
//FinAlgoritmo

//TP 1.9
//Algoritmo azar_dos_digitos
//	Definir numero como entero;
//
//	numero <- Aleatorio(0,99);
//
//	Si numero < 10 Entonces
//		Escribir "El n�mero aleatorio es: 0",numero;
//	SiNo
//		Escribir "El n�mero aleatorio es: ", numero;
//	FinSi
//FinAlgoritmo

//TP 1.10
//Algoritmo azar_dos_digitos
//	Definir numero como entero;
//
//	numero <- Aleatorio(0,9999);
//
//	Si numero < 10 Entonces
//		Escribir "El n�mero aleatorio es: 000",numero;
//	SiNo
//		Escribir "El n�mero aleatorio es: ", numero;
//	FinSi
//FinAlgoritmo

//TP 1.11
//Algoritmo conversor_de_temperatura
//	Definir grados_celcius como Real;
//	Definir resultado como Real;
//
//	Escribir "Conversor de temparatura de grados Celcius a grados Fahrenheit.";
//	Escribir "===============================================================";
//	Escribir "Ingrese la temperatura en grados Celcius";
//	Leer grados_celcius;
//
//	resultado <- (grados_celcius * 9/5) + 32;
//	Escribir "Los grados Celcius son: ", grados_celcius, " Los grados Fahrenheit son: ", resultado;
//FinAlgoritmo

//TP 1.13
//Algoritmo conversor_a_celcius
//	Definir grados_fahrenheit como Real;
//	Definir resultado como real;
//
//	Escribir "Conversor de grados Fahrenheit a Celcius";
//	Escribir "========================================";
//	Escribir "Ingresar temperatura en grados Fahrenheit";
//	Leer grados_fahrenheit;
//
//	resultado <- (grados_fahrenheit - 32) * 5/9;
//
//	Escribir "Los grados celcius son: ", resultado;
//
//FinAlgoritmo

//TP 1.14
//Algoritmo medidor_de_distancia_rayo
//	Definir velocidad_del_sonido como Entero;
//	Definir segundos_transcurridos como Entero;
//	Definir distancia_del_rayo como Entero;
//
//	velocidad_del_sonido <- 343;
//
//	Escribir "Ingrese cuantos segundos pasaron desde que cay� el rayo";
//	Leer segundos_transcurridos;
//
//	Si segundos_transcurridos > 0 Entonces
//		distancia_del_rayo <- velocidad_del_sonido * segundos_transcurridos;
//		Escribir "El rayo est� a una distancia en metros de: ", distancia_del_rayo;
//	SiNo
//		Escribir "No puedes ingresar segundos negativos o en 0";
//	FinSi
//FinAlgoritmo

//TP 1.15
//Algoritmo calculadora_de_remuneracion
//	Definir sueldo_basico como Real;
//	Definir cantidad_de_hijos como Entero;
//	Definir monto_por_hijo como Entero;
//	Definir cantidad_de_inasistencias como Entero;
//	Definir monto_por_inasistencias como Entero;
//	Definir porcentaje_para_jubilacion como Real;
//	Definir porcentaje_para_obra_social como Real;
//	Definir sueldo_neto como Real;
//
//	monto_por_hijo <- 15000;
//	monto_por_inasistencias <- 10000;
//
//	Escribir "Ingrese el sueldo basico";
//	Leer sueldo_basico;
//	Escribir "Ingrese cantidad de hijos, coloque 0 en caso de no tener";
//	Leer cantidad_de_hijos;
//	Escribir "Ingrese cantidad de inasistencias, coloque 0 en caso de no tener";
//	Leer cantidad_de_inasistencias;
//
//	sueldo_neto <- sueldo_basico + (cantidad_de_hijos * monto_por_hijo) - (sueldo_basico * porcentaje_para_jubilacion) - (sueldo_basico * porcentaje_para_obra_social) - (monto_por_inasistencias * cantidad_de_inasistencias);
//	Escribir "El sueldo neto es de : $", sueldo_neto;
//FinAlgoritmo

//TP 1.16
//Algoritmo calculadora_de_area_y_de_volumen
//	Definir area como real;
//	definir volumen como real;
//
//	Escribir "Ingrese el lado del tetraedro";
//	Leer a;
//	area <- raiz(3) * a ^ 2;
//	volumen <- raiz(2)/12 * a ^ 3;
//
//	Escribir "El area del tetraedo es de: ", area;
//	Escribir "El volumen del tetraedo es de: ", volumen;
//FinAlgoritmo

//TP 1.17
//Algoritmo calculadora_de_area_y_de_volumen
//	Definir area como real;
//	definir volumen como real;
//
//	Escribir "Ingrese el lado del octaedro";
//	Leer a;
//	area <- 2 * raiz(3) * a ^ 2;
//	volumen <- raiz(2)/3 * a ^ 3;
//
//	Escribir "El area del octaedro es de: ", area;
//	Escribir "El volumen del octaedro es de: ", volumen;
//FinAlgoritmo

//TP 1.18
//Algoritmo calculadora_de_area_y_de_volumen
//	Definir area como real;
//	definir volumen como real;
//
//	Escribir "Ingrese el lado del isocaesdro";
//	Leer a;
//	area <- 5 * raiz(3) * a ^ 2;
//	volumen <- (raiz(5)/12 * (3 * raiz(5))) * a ^ 3;
//
//	Escribir "El area del isocaedro es de: ", area;
//	Escribir "El volumen del isocaedro es de: ", volumen;
//FinAlgoritmo

//TP 1.19
//Algoritmo calculadora_de_area_y_de_volumen
//	Definir area como real;
//	definir volumen como real;
//
//	Escribir "Ingrese el lado del cubo";
//	Leer a;
//	area <- 6 * a ^ 2;
//	volumen <- a ^ 3;
//
//	Escribir "El area del cubo es de: ", area;
//	Escribir "El volumen del cubo es de: ", volumen;
//FinAlgoritmo

//TP 1.20
// Algoritmo calculadora_de_area_y_de_volumen
// 	Definir area como real;
// 	definir volumen como real;
// 	definir radio como real;
// 	definir altura como real;

// 	Escribir "Ingrese el radio del cilindro";
// 	Leer radio;

// 	Escribir "Ingrese la altura del cilindro";
// 	Leer altura;

// 	area <- 2* PI * radio * (altura * radio);
// 	volumen <- PI * radio ^ 2 * altura;

// 	Escribir "El area del cilindro es de: ", area;
// 	Escribir "El volumen del cilindro es de: ", volumen;
// FinAlgoritmo

// 1.21
// Algoritmo calcular_area_y_volumen_cono
//     Definir altura como Real;
//     Definir radio como Real;
//     Definir pendiente como Real;
//     Definir area como Real;
//     Definir volumen como Real;

//     Escribir "Ingrese la altura del cono";
//     Leer altura;
//     Escribir "Ingrese el radio del cono";
//     Leer radio;
//     Escribir "Ingrese la pendiente del cono";
//     Leer pendiente;

//     area <- PI * radio * (pendiente + radio);
//     volumen <- (PI * pot(radio) * altura)/3;

//     Escribir "El area del cono es de: ", area;
//     Escribir "El volumen del cono es de: ", volumen;

// FinAlgoritmo

// 1.22
// Algoritmo calcular_area_y_volumen_cono_truncado
//     Definir altura como Real;
//     Definir radio como Real;
//     Definir radio_mayor como Real;
//     Definir pendiente como Real;
//     Definir area como Real;
//     Definir volumen como Real;

//     Escribir "Ingrese la altura del cono";
//     Leer altura;
//     Escribir "Ingrese el radio menor del cono";
//     Leer radio;
//     Escribir "Ingrese el radio mayor del cono";
//     Leer radio_mayor;
//     Escribir "Ingrese la pendiente del cono";
//     Leer pendiente;

//     area <- PI * (pendiente * (radio_mayor + radio) + pot(radio_mayor) + pot(radio));
//     volumen <- (PI * altura * (pot(radio_mayor) + pot(radio) + radio_mayor + radio))/3;

//     Escribir "El area del cono truncado es de: ", area;
//     Escribir "El volumen del cono truncado es de: ", volumen;

// FinAlgoritmo

// 1.23
// Algoritmo calcular_area_y_volumen_esfera
//     Definir radio como Real;
//     Definir area como Real;
//     Definir volumen como Real;

//     Escribir "Ingrese el radio de la esfera";
//     Leer radio;

//     area <- PI * 4 * radio;
//     volumen <- (PI * pot(radio)) * 4/3;

//     Escribir "El area de la esfera es de: ", area;
//     Escribir "El volumen de la esfera es de: ", volumen;

// FinAlgoritmo

// 1.24
// Algoritmo calcular_area_y_volumen_casquete_esferico
//     Definir radio_del_casquete como Real;
//     Definir altura_casquete como Real;
//     Definir area como Real;
//     Definir volumen como Real;
//     Definir radio como Real;

//     Escribir "Ingrese el radio del casquete";
//     Leer radio_del_casquete;

//     Escribir "Ingrese la altura del casquete";
//     Leer altura_casquete;

//     radio <- (pot(radio_del_casquete) + pot(altura_casquete))/ 2 * altura_casquete;
//     area <- 2 * PI * altura_casquete * radio;
//     volumen <- (PI * pot(altura_casquete) * (3 * radio - altura_casquete))/3;

//     Escribir "El area casquete de la esfera es de: ", area;
//     Escribir "El volumen casquete de la esfera es de: ", volumen;

// FinAlgoritmo

// 1.25
// Algoritmo calcular_area_y_volumen_casquete_esferico
//     Definir radio_del_casquete como Real;
//     Definir altura_casquete como Real;
//     Definir area como Real;
//     Definir volumen como Real;
//     Definir radio como Real;

//     Escribir "Ingrese el radio del casquete";
//     Leer radio_del_casquete;

//     Escribir "Ingrese la altura del casquete";
//     Leer altura_casquete;

//     radio <- (pot(radio_del_casquete) + pot(altura_casquete))/ 2 * altura_casquete;
//     area <- 2 * PI * altura_casquete * radio;
//     volumen <- (PI * pot(altura_casquete) * (3 * radio - altura_casquete))/3;

//     Escribir "El area casquete de la esfera es de: ", area;
//     Escribir "El volumen casquete de la esfera es de: ", volumen;

// FinAlgoritmo

// 1.26
// Algoritmo calcular_area_y_perimetro_cuadrado
//     Definir lado como Real;
//     Definir area como Real;
//     Definir perimetro como Real;

//     Escribir "Ingrese lado del cuadrado: ";
//     Leer lado;

//     area <- pot(lado);
//     perimetro <- 4 * lado;

//     Escribir "El area del cuadrado es de: ", area;
//     Escribir "El perímetro del cuadrado es de: ", perimetro;

// FinAlgoritmo

// 1.27
// Algoritmo calcular_area_y_perimetro_rectangulo
//     Definir base como Real;
//     Definir altura como Real;
//     Definir area como Real;
//     Definir perimetro como Real;

//     Escribir "Ingrese base del rectangulo: ";
//     Leer base;

//     Escribir "Ingrese altura del rectangulo: ";
//     Leer altura;

//     area <- base * altura;
//     perimetro <- (2 * base) + (2 * altura);

//     Escribir "El area del rectangulo es de: ", area;
//     Escribir "El perímetro del rectangulo es de: ", perimetro;

// FinAlgoritmo

// 1.28
// Algoritmo calcular_area_y_perimetro_paralelogramo
//     Definir base como Real;
//     Definir altura como Real;
//     Definir diagonal como Real;
//     Definir area como Real;
//     Definir perimetro como Real;

//     Escribir "Ingrese base del paralelogramo: ";
//     Leer base;

//     Escribir "Ingrese altura del paralelogramo: ";
//     Leer altura;

//     Escribir "Ingrese la diagonal del paralelogramo: ";
//     Leer diagonal;

//     area <- base * altura;
//     perimetro <- (2 * base) + (2 * diagonal);

//     Escribir "El area del paralelogramo es de: ", area;
//     Escribir "El perímetro del paralelogramo es de: ", perimetro;

// FinAlgoritmo

// 1.29
// Algoritmo calcular_area_y_perimetro_rombo
//     Definir lado como Real;
//     Definir diagonal_mayor como Real;
//     Definir diagonal_menor como Real;
//     Definir area como Real;
//     Definir perimetro como Real;

//     Escribir "Ingrese lado del rombo: ";
//     Leer lado;

//     Escribir "Ingrese diagonal mayor del rombo: ";
//     Leer diagonal_mayor;

//     Escribir "Ingrese la diagonal menor del rombo: ";
//     Leer diagonal_menor;

//     area <- (diagonal_menor * diagonal_mayor)/2;
//     perimetro <- 4 * lado;

//     Escribir "El area del rombo es de: ", area;
//     Escribir "El perímetro del rombo es de: ", perimetro;

// FinAlgoritmo

// 1.30
// Algoritmo calcular_area_y_perimetro_trapecio
//     Definir base_menor como Real;
//     Definir base_mayor como Real;
//     Definir diagonal_uno como Real;
//     Definir diagonal_dos como Real;
//     Definir altura como Real;
//     Definir area como Real;
//     Definir perimetro como Real;

//     Escribir "Ingrese base menor del trapecio: ";
//     Leer base_menor;

//     Escribir "Ingrese base mayor del trapecio: ";
//     Leer base_mayor;

//     Escribir "Ingrese primera diagonal del trapecio: ";
//     Leer diagonal_uno;

//     Escribir "Ingrese segunda diagonal del trapecio: ";
//     Leer diagonal_dos;

//     Escribir "Ingrese altura del trapecio: ";
//     Leer altura;

//     area <- ((base_menor * base_mayor)/2) * altura;
//     perimetro <- base_menor + base_mayor + diagonal_uno + diagonal_dos;

//     Escribir "El area del trapecio es de: ", area;
//     Escribir "El perímetro del trapecio es de: ", perimetro;

// FinAlgoritmo

// 1.31
// Algoritmo calcular_area_y_perimetro_trapecio_recto
//     Definir base_menor como Real;
//     Definir base_mayor como Real;
//     Definir diagonal como Real;
//     Definir altura como Real;
//     Definir area como Real;
//     Definir perimetro como Real;

//     Escribir "Ingrese base menor del trapecio: ";
//     Leer base_menor;

//     Escribir "Ingrese base mayor del trapecio: ";
//     Leer base_mayor;

//     Escribir "Ingrese diagonal del trapecio: ";
//     Leer diagonal;

//     Escribir "Ingrese altura del trapecio: ";
//     Leer altura;

//     area <- ((base_menor * base_mayor)/2) * altura;
//     perimetro <- base_menor + base_mayor + diagonal_uno;

//     Escribir "El area del trapecio es de: ", area;
//     Escribir "El perímetro del trapecio es de: ", perimetro;

// FinAlgoritmo


// // 1.32 - 1.35
// Algoritmo calcular_area_y_perimetro_triangulo
//     Definir lado como Real;
//     Definir lado_menor como Real;
//     Definir lado_tres como Real;
//     Definir altura como Real;
//     Definir area como Real;
//     Definir perimetro como Real;
//     Definir tipo_triangulo como Entero;
//     Definir angulo_recto como Entero;

//     Escribir "�Qu� tipo de triangulo es? Equilatero (1), is�celes(2) , escaleno (3). Ingrese el n�mero del triangulo para pedir las magnitudes: ";
//     Leer tipo_triangulo;

//     Escribir "�El tri�ngulo tiene un �ngulo recto?. Ingrese 1 si lo tiene, 0 si no lo tiene: ";
//     Leer angulo_recto;


//     Si tipo_triangulo = 1 Entonces
//         Escribir "Ingrese lado del tri�ngulo: ";
//         Leer lado;

//         Escribir "Ingrese altura del tri�ngulo: ";
//         Leer altura;

//         area <- (lado * altura)/2;
//         perimetro <- 3 * lado;
//     FinSI

//     Si tipo_triangulo = 2 Entonces
//         Escribir "Ingrese base del tri�ngulo: ";
//         Leer lado;

//         Escribir "Ingrese lado del tri�ngulo: ";
//         Leer lado_menor;

//         Escribir "Ingrese altura del tri�ngulo: ";
//         Leer altura;

//         area <- (lado * altura)/2;
//         perimetro <- 2 * lado_menor + base;
//     FinSI

//     Si tipo_triangulo = 3 Entonces
//         Escribir "Ingrese lado mayor del tri�ngulo: ";
//         Leer lado;

//         Escribir "Ingrese lado menor del tri�ngulo: ";
//         Leer lado_menor;

//         Escribir "Ingrese el tercer lado del tri�ngulo: ";
//         Leer lado_tres;

//         Escribir "Ingrese altura del tri�ngulo: ";
//         Leer altura;

//         Si angulo_recto = 0 Entonces
//             area <- (lado_menor * altura)/2;
//             perimetro <- lado + lado_menor + lado_tres;
//         SiNo
//             area <- (lado_menor * lado)/2;
//             perimetro <- lado + lado_menor + lado_tres;

//         FinSi
//     FinSi

//     Escribir "El area del tri�ngulo es de: ", area;
//     Escribir "El perímetro del tri�ngulo es de: ", perimetro;

// FinAlgoritmo


// 20260413
//TP Politi

// Algoritmo comparacion_numeros
//     Definir num1 como Entero;
//     Definir num2 como Entero;
//     Definir producto como Entero;
//     Definir division como Real;
//     Definir suma como Entero;
//     Definir diferencia como Entero;

//     Escribir "Ingrese un primer n�mero entero: ";
//     Leer num1;
//     Escribir "Ingrese un segundo n�mero entero: ";
//     Leer num2;

//     Si num1 > num2 Entonces
//         suma <- num1 + num2;
//         diferencia <- num1 - num2;

//         Escribir "La suma de los dos n�meros es de: ", suma;
//         Escribir "La diferencia de los dos n�meros es de: ", diferencia;
//     SiNo
//         producto <- num1 * num2;
//         Escribir "El producto de los dos n�meros es de: ", producto;

//         Si num2 == 0 Entonces
//             Escribir "No se puede dividir en 0.";
//         FinSi
//         division <- num1 / num2;
//         Escribir "La division de los dos n�meros es de: ", division;
//     FinSi
// FinAlgoritmo

// Algoritmo edades_y_sexo
//     Definir edad como Entero;
//     Definir sexo como Caracter;

//     Escribir "Ingresa tu edad";
//     Leer edad;

//     Escribir "Ingresa tu sexo. Masculino (M) y Femenino (F)";
//     Leer sexo;

//     Si (edad <= 0 Y edad >= 110) Entonces
//         Escribir "Edad no v�lida. Ingrese correctamente la edad";
//     FinSi

//     Escribir "Tu edad es de: ", edad;
// FinAlgoritmo

// Algoritmo promedio_notas
//     Definir nota1 Como Entero;
//     Definir nota2 Como Entero;
//     Definir nota3 Como Entero;
//     Definir promedio Como real;

//     Escribir "Ingrese la primera nota";
//     Leer nota1;

//     Escribir "Ingrese la segunda nota";
//     Leer nota2;
    
//     Escribir "Ingrese la tercera nota";
//     Leer nota3;

//     Si (nota1 < 1 O nota1 > 10) O (nota2 < 1 O nota2 > 10) O (nota3 < 1 O nota3 > 10) Entonces
//         Escribir "Ingres� alguna nota inv�lida. Revise y compute una nota v�lida";
//     SiNo
//         promedio <- (nota1 + nota2 + nota3)/3;
//         Escribir "El promedio es de: ", promedio;
//     FinSi
// FinAlgoritmo
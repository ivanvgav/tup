---
title: Programación teórico
subtitle: (Ing. Estrada) - TUP - UTN-FRT - 2026
author: Gavriloff, Ivan Vladimir
---

# 20260416

Características de los algoritmos:

1. Secuencial
    - Se da un paso a paso
1. Lleva un orden lógico
    - No se puede pasar a la siguiente tarea si no se ha terminado la tarea anterior
1. Definido y finito
    - No debe tener ambigüedad
    - Debe tener un inicio y un fin
1. Eficiente
    - Debe tratar de consumir la menor cantidad de recursos (tiempo de memoria)
    - Debe ser lo más rápido posible (tiempo de procesamiento)
Se construyen en base a estructuras:
    - Secuencial
    - Condicionales
    - Iteraciones

Los algoritmos tienen una entrada (input) y una salida (output).

## Estrategias para resolución de los problemas

- Entender bien el problema *prima facie*
- Descomponer el problema en problemas más pequeños
- Planificar antes de programar
    - Realizar DFD o pseudocódigo
- Empezar por lo más básico
- Depurar (debug) sistemáticamente
    - Uso consiente del debugger para poder saber que es lo que se hace en cada uno de los pasos del programa
    - Permite detectar errores de manera precisa
- Refactorizar
    - Quiere decir la manera posible para poder mejorar el algoritmo
    - Se puede hacer limpieza, se saca lo redundante
    - Puede ser importante para sacar todo el "código muerto" (aquello que no se usa en el algoritmo)

- En lo posible a cada error siempre documentarlo para cuando se ha encontrado la solución

### Diseño de algoritmo

- Caso de uso esperado: ver cuales son los resultados que uno espera tener con el algoritmo
- Edge cases: cuales son los casos límites que el algoritmo puede tener problemas
- Se tiene que contemplar todas las posibilidades

## Pseudocódigo

En la escritura puede ser escrito de manera secuencial.
Es la escritura en lenguaje natural de lo que se ha realizado en el DFD.

Ejemplo de pseudocódigo:

```
Inicio
    Leer numero1
    Leer numero2
    Si número1 > numero2 entonces
        Imprimir "El numero mayor es numero1"
    Sino
        Imprimir "El número mayor es número2"
    FinSi
Fin
```

Buscar error en el pseudocodigo y hacer DFD

```
Inicio
    Definir numero1
    Definir numero2

    Imprimir "Ingrese el primer número:"
    Leer numero1
    Imprimir "Ingrese el segundo número:"
    Leer numero2

    Si numero 1 == numero2 entonces
        Imprimir "Los numero son iguales. Ingrese números distintos."
    FinSi

    Si numero1 > numero2 entonces
        Imprimir "El numero mayor es numero1"
    Sino
        Imprimir "El número mayor es número2"
    FinSi
Fin
```

DFD:

# 20260417 - Unidad 4 Tipos de datos y variable

Una dato se lo considera como una unidad mínima de información.
El dato puede ser procesado por un algoritmo.
Conjunto o secuencia de bits.
EL dato no es el valor.
EL dato `nombre_del_dia` tiene un valor `viernes`.

## Tipos de datos

- Simples o primitivos
    - Enteros (int): representan los números enteros.
        - Ej: `int edad = 25`
    - Flotantes y dobles (float y double)
        - `float` para decimales
            - Ocupa hasta 4 bytes
            - mantiene hasta 7 cifras precisas
            - usa menos memoria que double (32 bits)
        - `double` para números reales
            - Ocupa hasta 8 bytes
            - mantiene hasta 15 cifras precisas
            - usa mas memoria que float (64 bits)
    - Caracter (char)
        - Almacenan un único caracter
        - `char letra = 'A';` su tamaño va a ser de un 1 byte
        - Cuando se habla de cadena doble se tiene que hacer distintas
    - Booleanos (bool)
        - Representan valores lógicos (true o false)
        - `bool es_valido = true;` tiene tamaño de 1 byte
    - Punteros (pointer)
        - Almacenan direcciones de memoria
        - `int* ptr = &edad;` su tamaño va a depender de la arquitectura
          (4 bytes para sistemas de 32 bits).
- Compuestos
    - Estructuras que combinan múltiples valores
    - Arreglos (arrays o vectores)
        - Colección de elementos del mismo tipo
        - Estructuras lineales
        - Ej: `int numeros[5] = {1, 2, 3, 4, 5};`.
          Lo que esta en corchetes es la cantidad que permite guardar el vector.
        - Su tamaño en memoria depende del número de elementos
    - Estructuras (struct)
        - Agrupan datos de diferentes tipo bajo una misma denominación
        - Ej:
          ```c
          struct Persona
          {
            char nombre[50];
            int edad;
            float altura;
          }
          ```
    - Estructuras dinámicas
        - Listas
            - FIFO (first in first out)
            - Primera en entrar primera al salir
        - Pilas
        - Colas
    - Objetos
        - Instancias de clases que encapsulan datos y comportamientos
        - EJ:
          ```java
          class Persona
          {
            String nombre;
            int edad;

            public void Saludar()
            {
                console.log("Hola");
            };
          }
          ```

# 20260423

## Operadores

Símbolos para poder realizar distintas operaciones (matemáticas, lógicas, de asignación)
Estos operadores actúan sobre variables y valores

- Aritmética: Suma, resta, división y multiplicación, modulo
    - La Suma sirve para anexar algo (concatenar)
- Relacionales: Igualdad (==), Diferencia (!=), Mayor a (>), menor a (<), mayor o igual a (>=), menor o igual a (<=)
- Lógica: Y Conjunción (&&), O Disyunción (||), negación (!)
- Asignaciones: =

# 20260424

## TP

1. Booleano
2. El primero es de asignación mientras que el segundo es un operador relacional de igualdad
3. $F$
4. $V$
5. Y (&&)
6.
    - $10 + 5 * 2 = 20$
    - $V$
    - $V$
    - $F$
    - $V$
7. - $V$
   - $V$
   - $V$
   - $F$
   - $V$
8. Para almacenar un dato en memoria y poder utilizarlo después
9. Una constante es una variable pero que no tiene mutabilidad
10. `const`
11. b
12. `string`
13. `bool`
14. En que el segundo permite decimales mientras que el primero solo enteros
15. e porque tiene un espacio
16. Si tienen el mismo valor es la misma variable
17. Guarda el string Buenos Aires en la variable con nombre cuidad usando un espacio de memoria correspondiente
18. La primera va a dar un número entero y el segundo permite un número real
19. `string ejemplo = "Esto es un ejemplo;"`
20. `const`. Si tratamos de cambiar su valor, nos tira un error debido a que dicha palabra clave vuelve inmutable a esa variable
21. Cada uno es más preciso que el otro
22. Sirve para iniciar y finalizar el diagrama de flujo
23. Para ingresar datos
24. EL rectángulo
25. Permite dar la condición para comparación
26. Muestra un mensaje
27. Siempre es desde arriba hacia abajo
28. Siempre debe terminar en uno solo
29. $V$ o $F$
30. Esta mal diagramado
31. Inicio; Leer el número; ¿El número es mayor a 0?; Mostrar "Es positivo"; Fin.

# 20260430

***Parcial: Semana del 15 de Mayo (semana posible de examen)***

## Estructuras de datos

*Estructura secuencial*: Se va paso a paso en cada una de las tareas.
Hasta que no se termina una no se empieza la otra.

*Estructura condicional*: Sucede cuando hay algo que comparar o evaluar.
Se tiene dos posibles ramas de evaluación (condición verdadera o condición falsa).
Dependiendo de cuando se hace cada una de ellas, dependiendo el caso
se vuelve al flujo de información.

# TP Estructura secuencial condicional

1. Es un tipo de estructura donde las intrucciones se realizan una después de la otra
2. Es una estructura que va paso a paso para llevar a cabo su objetivo
3. Calentar agua
4. Estructura que permite tomar decisiones dependiendo si se cumple o no
5. El `if` sirve para evaluar una condición comparandola y ejecutar una acción
6. Se diferencia porque el `if else` permite comparar alternativas mientras que el `if` solo permite evaluar *una* condición
7. Comprobar si la condición es verdadera $V$ o $F$
8. Operadores relacionales: Igual (==), Distinto (!=), Menor (<), Mayor (>), Menor o igual (<=), Mayor o igual (>=)
9. `if else if else` permite evaluar dos condiciones distintas. En la primera evalua una condición, por ejemplo (si un numero mayor) y realiza una acción si es verdadero,
si es
10. Se evaluan booleanos (`bool`)
11. $F$
12. $V$
13. $V$
14. $V$
15. Una estructura secuencial. Evalúa una condición. El bloque else.
16. Inicio
     Leer numero
     resultado = numero * 2
     Imprimir resultado
     Fin
17. Inicio
     Leer edad
     Si edad >= 18
        Entonces
          Imprimir "Eres mayor de edad"
     Sino
          Imprimir "Eres menor de edad"
     Fin
18. Es mayor
19. Inicio
     Leer numero
     Si numero > 0 Entonces
        Imprimir "Es positivo"
     Sino
          Imprimir "Es negativo"
     Fin
20. Inicio
     Leer numero1, numero2
     Si numero1 > numero2 Entonces
        Imprimir "El número mayor es", numero1
     Si numero1 == numero2 Entonces
          Imprimir "Los números son iguales"
     Fin

1. Realice un algoritmo para determinar si un número es positivo o negativo
   Realice el diagrama de flujo de datos, pseudocódigo y prueba de escritorio
2. Realice un algoritmo para determinar cuánto se debe pagar por x cantidad de
   lápices considerando que si son 1000 o más el costo es de $\$600$ c/u; de lo
   contrario el precio es de $\$900$ c/u. Realice un diagrama de flujo de datos,
   pseudocódigo y prueba de escritorio


```
Inicio
Leer numero
Si numero >= 0 Entonces
  Imprimir "Es positivo"
Sino
  Imprimir "Es negativo"
Fin
```

| variable | valor | resultado |
| --------- | ----- | ----------- |
| numero   | 1     | Es positivo |
| numero   | 0     | Es positivo |
| numero   | -1     | Es negativo |


2.

```
Inicio
Leer cantidad_de_lapices
Si cantidad_de_lapices >= 1000
  Imprimir "El precio es de \$600"
Sino
  Imprimir "El precio es de \$900"
Fin
```

| variable  | valor | resultado |
| --------- | ----- | ----------- |
| cantidad_de_lapices   | 1000     | El precio es de \$600 |
| cantidad_de_lapices   | 500      | El precio es de \$900 |
| cantidad_de_lapices   | 1200     | El precio es de \$600 |

# 20260507

**Primer parcial: 28 de Mayo**

## Estructuras repetitivas

Pseudocode `while`

```
Mientras condicion
  Ejecución
FinMientras
```

Pseudocode `do while`

```
Repite
  Ejecución
HastaQue condicion
```

Pseudocode `for`
```
Desde valor inicial Hasta valor final
  Ejecución
FinDesde
```
## TP Estructuras de bucles

1. b
2. c
3. a
4. b
5. b
6. $V$
7. `for`
8. | Tipo de estructura | Característica                                           | Diferencia                       |
   | ------------------ | -------------------------------------------------------- | -------------------------------- |
   | `while`            | Ejecuta en tanto se cumpla la condición                  | -                                |
   | `do while`         | Ejecuta primero y luego comprueba la condición del bucle | La condición es evaluada después |
   | `for`              | Ejecuta un número finito y determinado de veces          | Tiene un inicio y fin explícitos |
9. I. b
   II. `for`
   III. `while`

1. El negocio "Loren" tiene una promoción: a todos los trajes que tienen un precio superior a $25000
   se les aplicará un descuento de 15%, a todos los demás se les aplicará un 8%.
   Realice un algoritmo para determinar el precio final que debe pagar una persona por comprar un traje
   y de cuánto es el descuento que obtendrá.
   Representarlo mediante diagrama de flujo y pseudocódigo.

```
Inicio
  descuento_de_15;
  descuento_de_8;
  precio_de_traje;
  monto_del_descuento;
  precio_total;

  descuento_de_15 = 0.15;
  descuento_de_8  = 0.08;


  Imprimir "Ingrese el monto del traje";
  Leer precio_de_traje

  Si precio_de_traje > 25000 entonces
    monto_del_descuento = precio_de_traje * descuento_de_15
    precio_total = precio_de_traje - monto_del_descuento
  Sino
    monto_del_descuento = precio_de_traje * descuento_de_8
    precio_total = precio_de_traje - monto_del_descuento
  FinSi

  Imprimir "El precio total del traje es de: ", precio_total
Fin
```

# 202060508

1. Se requiere algún algortimo para obtener la suma de diez cantidades mediante
   la realización de un ciclo `while`. Realice el diagrama de flujo, el pesudocódigo
   y prueba de escritorio.
    - Debe ingresar hasta 10 números y sumarlos. No olvidar tener también un contador.

    ```
    Inicio
        Definir numero entero;
        Definir contador entero;
        Definir suma entero;
        contador = 0;
        numero = 0;
        suma = 0;

        Imprimir "Ingrese un número";
        Leer numero;

        Mientras contador < 10
            suma += numero; // suma = suma + numero;
            contador++; // contador = contador + 1;
        FinMientras
    Fin
    ```

    **Prueba de escritorio**

    | variable | valor | resultado |
    | -------- | ----- | --------- |
    | numero   | 100   | 100       |
    | contador | 0     | 1         |
    | suma     | 0     | 100       |
    | numero   | 200   | 100       | 200 |
    | contador | 1     | 2         |
    | suma     | 100   | 300       |
    | numero   | 50    | 200       | 50 |
    | contador | 2     | 3         |
    | suma     | 300   | 350       |
    | numero   | 200   | 50        | 200 |
    | contador | 3     | 4         |
    | suma     | 350   | 550       |
    | numero   | 200   | 100       | 100 |
    | contador | 4     | 5         |
    | suma     | 550   | 650       |

2. Elabore un algoritmo que imprima los números del 1 al 100

    ```
    Inicio
        entero i;

        Para i = 1 hasta que i <= 100
            Imprimir "El número es: ", i;
        FinPara
    Fin
    ```

    **Prueba de escritorio**

    | variable | valor | resultado       |
    | -------- | ----- | ---------       |
    | i        | 1     | El número es: 1 |
    | i        | 2     | El número es: 2 |
    | i        | 3     | El número es: 3 |
    | i        | 4     | El número es: 4 |
    | i        | 5     | El número es: 5 |
    | i        | 6     | El número es: 6 |
    | i        | 7     | El número es: 7 |
    | i        | 8     | El número es: 8 |
    | i        | 9     | El número es: 9 |
    | i        | 10    | El número es: 10 |

# 20260514

1. A. No hay un contador inicializado ni hay dentro del mientras la introducción
      del aumento del contador
   B. No incluye el 10
      ```
      Inicio
        definir suma como entero;
        definir i como entero;

        Para i = 1 hasta i <= 10
          suma = suma + i
        FinPara

        Imprimir suma;
      Fin
      ```
   C. Esta bien
      ```
      Inicio
        definir numero como entero;

        Mientras numero != 0
          Escribir "Ingrese un número: ";
          Leer numero;
          Escribir numero;
        FinMientras
      Fin
      ```
   D. Para que quede más claro deberia tener una variable promedio para guardar la operación de la suma yla división en $3$
   E. El problema está en la variable factorial. Como inicializa en 0 toda multiplicación dentro del para va a ser $0$.
      Dentro del para tendria que tener una operacion que al numero le reste el i y luego lo multiplique al factorial.

# 20260528
## Estructuras de datos
Pueden ser de datos simples (entero, real, caracter, lógico) o también los
definidos por el programador (subrango, enumetarivos [días de la semana])

Luego los datos estrcuturados tenemos datos estáticos o dinámicos.
Entre los *estáticos* tenemos a los arrays, registros, ficheros, conjuntos (Sets), cadenas (strings).
Entre los *dinámicos* Listas (Pilas/Colas), Listas enlazadas, Árboles y Gráfos

## Vectores
Para poder determinar la posición de un elemento se pone `A[i]`
donde `i` es la posición del elemento `A` hace mención al nombre del vector.

### Operación con vectores
- Asignaciones
- Lectura/escritura
    - En C# tenemos que usar Console.WriteLine() para escritura y
      Console.ReadLine() para la lectura de agregar elementos al array
- Recorrido
    - Se realiza con los ciclos `for`
- Actualizar (añadir, borrar, reemplazar)
- Ordenar
- Búsqueda

## TP Vectores
1. ¿Qué significa acceso secuencial al vector?
    - Quiere decir que para acceder a los datos de un vector se tiene que
      acceder de uno a uno. Por medio de una secuencia, por ello es que para
      recorrerlo se necesita de una estructura de bucles
1. Explique las diferencias entre un vector y una matriz
    - Un vector puede ser entendido por una matriz con una sola fila y sin
      columnas.7 La matriz si o si tiene filas y columnas, es decir que guarda
      elementos entre filas y columnas
1. Grafique cómo sería un vector y una matriz
    - Vector:
      ```
        | a | b | c | d | e | f | g | <- letras
        | 0 | 1 | 2 | 3 | 4 | 5 | 6 | (Posiciones)
      ```
    - Matrices:
      ```
        1 2 3
        4 5 6 <- Fila
        7 8 9
        ^ Columna
      ```
      Para poder determina la posición tendría que ser `a[i][j]` donde `i` son
      las filas y `j` las columnas
1. ¿Qué tipo de estructuras se utiliza para las distintas operaciones en un vector?
    - Para las operaciones de recorrido se hace uso de estructuras repetitivas.
      Para las operaciones de orden y de búsqueda se hacen uso de estructuras
      de repetición y estructuras de control para comparar a la hora de ordenar
      los elementos, o para la búsqueda de algún elemento. Para las operaciones
      de actualización también tienen que usarse estructuras de repetición y de
      control
1. ¿Cuál es la principal ventaja de utilizar un vector frente a declarar variables independientes?
    - Permite agrupar datos del mismo tipo en vez de tener que declararlos uno por uno.
      También permite que se puedan hacer operaciones en conjunto evitando
      operaciones repetitivas.
1. ¿Qué tipo de datos se pueden almacenar dentro de un vector?
    - Pueden ser almacenados cualquier tipo de dato simple, solo con la
      condición de que tienen que ser el mismo tipo de dato. Al menos C# no
      permite hacer mezcla de tipos de datos.

# 20260529
Los vectores se almacena en la memoria de la computadora.
Se representa en la cantidad de elementos en los lugares adyacentes en la memoria

# 20260406
## Matrices
Son arrays bidimensionales. Por lo que se va a tener dos índices.
Uno que se identifica con las filas de las matrices y otro que se identifica con las columnas.
Tienen que ser distintos índices.

### TP Matrices
1. Las matrices bidimensionales se almacenan en la memoria de la computadora
   (que es lineal o unidimensional) guardando todas sus filas una detrás de
   otra. Para organizar el salto entre filas, existen dos métodos principales:
   Row-major order (por filas) y Column-major order (por columnas). Row-major
   order (Almacenamiento por filas): Este método guarda toda la primera fila,
   luego toda la segunda fila, y así sucesivamente. Column-major order
   (Almacenamiento por columnas): Este método guarda toda la primera columna,
   luego toda la segunda columna, y así sucesivamente.
1. Una matriz es un array bidimensional. Sus elementos tienen que ser
   almacenados en filas y en columnas. Por lo que cada elemento dentro de una
   matriz tiene una posición para la fila y otra para la columna.
1. Se puede hacer una analogía con un edificio donde las filas serían los pisos
   del edificio mientras que las columnas son los números de los departamentos
1. 
  - Puede almacenar 12 elementos
  - Las cordenadas son (0, 0)
  - Las cordenadas son (3, 4)
1. Se tiene que usar dos bucles para poder realizar una matriz porque un bucle
   realiza el recorrido de los bucles por parte de las filas por un lado y de
   las columnas, por parte de otro bucle. El primer bucle es el que permite
   recorrer las filas, mientras que el segundo bucle es el que recorre las
   columnas. Las operaciones sobre los elementos de la que se quieran realizar
   tienen que hacerse dentro del bucle de las columnas ya que con el bucle de
   las filas permite moverse entre los elementos mientras que en el segundo
   permite hacer operaciones sobre los elementos.
1. 
   ```
   Definir matriz, i, j como Entero;
   matriz <- [6, 6];

   Para i = 0 hasta i = 5
     Para j = 0 hasta j = 5
       Escribir "Escribir un número para la posición [", i, "][", j,"]: ";
       Leer matriz[i,j];
     FinPara
   FinPara
   ```

# 20260611

## Colecciones
### TP Colecciones
1. ¿Cuál es la diferencia fundamental entre un array tradicional y una colección como `List<T>`?
2. ¿Qué ventaja principal ofrecen las colecciones genéricas (espacio de nombres `System.collection.Generic`) frente a las no genéricas?
3. Explica que es una colección de tipo clave-valor y menciona dos clases en C# que implementan este modelo
4. ¿Qué es un `HashSet<T>` y en que casos de uso preferirías utilizarlo en lugar de una `List<T>`
5. Nombra las diferencias entre una Cola (Queue<T>) y una Pila (Stack<T>) en cuanto al orden en que procesan los elementos
6. ¿Para qué sirve la interfaz `IEnumerable<T>` y qué permite hacer en conjunto con un bucle `foreach`?
7. Explica la diferencia entre las estructuras `Dictionary<They, TValue>` y `SortedDictionary<TKey, TValue>`
8. ¿Podría decir si existen varios tipos de colecciones? De ser así, explique detalladamente

#### Desarrollo

1. 
  * **Array tradicional:** Tiene un **tamaño fijo e inmutable** desde el
    momento de su creación. Si necesitas agregar más elementos de los que
    inicialmente reservaste, estás obligado a instanciar un nuevo array de
    mayor tamaño y copiar los elementos de forma manual.
  * **List<T>:** Es una colección **dinámica**. Modifica su tamaño de manera
    automática bajo el capó (reestructurando su array interno) a medida que
    agregas (`Add`) o eliminas (`Remove`) elementos.
2.
  Las colecciones genéricas ofrecen dos ventajas críticas para el desarrollo de software moderno:

  1. **Seguridad de tipos (Type Safety):** Al declarar un `List<int>`, el
  compilador garantiza que solo se puedan insertar enteros. Con las colecciones
  no genéricas (como `ArrayList`), todo se almacena como object, lo que eleva el
  riesgo de lanzar un `InvalidCastException` en tiempo de ejecución si se
  introduce un tipo incorrecto.
  
  2. **Rendimiento optimizado:** Evitan los procesos de **Boxing y
  Unboxing** al trabajar con tipos de valor (`int, double, bool, structs`). No es
  necesario transformar el dato a object para guardarlo, ni desempaquetarlo para
  leerlo, lo que ahorra ciclos de CPU y reduce el trabajo del `Garbage Collector`.
3. 
  Una colección de clave-valor es una estructura asociativa donde cada elemento
  guardado está compuesto por una **clave única** (que actúa como identificador
  o índice personalizado) y un **valor asociado** a dicha clave. No se accede a
  los datos por un índice numérico secuencial, sino mediante su clave.

  Dos clases nativas en C# que implementan este modelo son:
    * Dictionary<TKey, TValue>
    * SortedDictionary<TKey, TValue>
4. 
  Un `HashSet<T>` es una colección matemática de elementos **únicos** que **no
  garantiza un orden** específico.

  **¿Cuándo es preferible usarlo sobre una `List<T>`?**

  * **Para asegurar la unicidad:** Si necesitas evitar duplicados de forma
    nativa. `HashSet<T>` ignora automáticamente cualquier elemento repetido sin
    lanzar errores.
  * **Por rendimiento extremo en búsquedas:** Verificar si un elemento existe
    con `.Contains()` en una `List<T>` requiere recorrer la lista elemento por
    elemento (complejidad lineal `O(n)`). En un `HashSet<T>`, gracias a su algoritmo
    de hashing, la búsqueda, inserción y eliminación toman un tiempo constante
    promedio de O(1), haciéndolo ideal para procesar grandes volúmenes de datos.
5.
| Colección | Principio de Ordenamiento | Comportamiento Interno | Caso de Uso Típico |
| --------- | ------------------------- | ---------------------  | ------------------ |
| **Queue<T> (Cola)** | **FIFO** (*First-In, First-Out*) | El primer elemento en ingresar es el primero en salir. | Colas de impresión, procesamiento de tareas en segundo plano. |
| **Stack<T> (Pila)** | **LIFO** (*Last-In, First-Out*) | El último elemento en ingresar es el primero en salir. | Mecanismo de "Deshacer" (Ctrl+Z), historial de navegación. |

6.
  La interfaz `IEnumerable<T>` es el contrato base de lectura para todas las
  colecciones fuertemente tipadas en .NET. Su único propósito es exponer un
  enumerador (`IEnumerator<T>`), el cual permite recorrer la estructura de datos
  secuencialmente hacia adelante.

  **El secreto del bucle foreach:** foreach es azúcar sintáctico. El compilador
  de C# transforma el bucle en llamadas al método `.GetEnumerator()` de la
  interfaz. Esto te permite iterar cualquier colección (sea una lista, un array
  o un árbol) de forma unificada y segura sin preocuparte por índices o punteros
  internos.


```csharp
List<string> nombres = new List<string> { "Ana", "Beto", "Carlos" };

foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}
```

Lo que hace el compilador por dentro:

```csharp
List<string> nombres = new List<string> { "Ana", "Beto", "Carlos" };

// 1. Se obtiene el enumerador gracias a que List<T> implementa IEnumerable<T>
IEnumerator<string> enumerador = nombres.GetEnumerator();

try
{
    // 2. MoveNext() avanza al siguiente elemento. Devuelve 'false' cuando ya no hay más.
    while (enumerador.MoveNext())
    {
        // 3. Current obtiene el valor del elemento actual
        string nombre = enumerador.Current;
        
        Console.WriteLine(nombre);
    }
}
finally
{
    // 4. IEnumerator implementa IDisposable. 
    // Esto asegura que, incluso si hay un error, los recursos se liberen.
    if (enumerador != null)
    {
        enumerador.Dispose();
    }
}
``` 

* Abstracción total: Al foreach no le importa si estás recorriendo una List<T>,
  un Array, un `HashSet<T>` o una fila de una base de datos. Mientras la
  estructura tenga un método `GetEnumerator()`, el bucle funcionará exactamente
  igual.

* Seguridad: No hay peligro de equivocarse con el clásico error de índice fuera
  de rango (IndexOutOfRangeException) que suele pasar con los bucles for
  tradicionales (como poner `i <= nombres.Count` por error).

* Solo lectura y hacia adelante: El enumerador solo sabe ir hacia el frente y
  leer (Current). No puedes modificar la estructura de la colección (añadir o
  quitar elementos) mientras la recorres, lo que previene errores catastróficos
  en tiempo de ejecución

7. 
  Aunque ambas resuelven el almacenamiento de pares clave-valor, difieren
  drásticamente en su arquitectura interna y su rendimiento:
  
  * **Dictionary<TKey, TValue>:** Utiliza una **tabla hash** internamente. No
    mantiene ningún orden en las claves. Sus operaciones fundamentales
    (búsqueda, inserción, borrado) son extremadamente rápidas, operando en un
    tiempo constante de $O(1)$.
  * **SortedDictionary<TKey, TValue>:** Utiliza una estructura de **árbol
     binario de búsqueda balanceado** (árbol rojinegro). Mantiene las claves
     ordenadas automáticamente según su criterio de comparación. Debido al costo
     de mantener el árbol en equilibrio, sus operaciones son ligeramente más
     lentas, con una complejidad logarítmica de $O(\log n)$.
8.
   Sí, en el ecosistema de .NET las colecciones se categorizan en varias
   familias especializadas según el escenario arquitectónico donde se utilicen:
  
  * **Colecciones Genéricas (System.Collections.Generic):** Son el estándar
    moderno de la industria (`List<T>`, `Dictionary<TKey, TValue>`). Garantizan
    seguridad de tipos y alto rendimiento.
  
  * **Colecciones Concurrentes (System.Collections.Concurrent):** Diseñadas
    específicamente para entornos multihilo (*multithreading*). Clases como
    `ConcurrentDictionary<TKey, TValue>` son *thread-safe*, lo que significa que
    múltiples hilos pueden leer y escribir en ellas simultáneamente sin
    corromper los datos y sin necesidad de usar bloqueos manuales (lock).
  
  * **Colecciones Inmutables (System.Collections.Immutable):** Son estructuras
    que no pueden ser alteradas una vez creadas. Cualquier operación que intente
    modificarlas devuelve una nueva instancia modificada, dejando la original
    intacta. Son muy utilizadas en arquitectura de software funcional y estados
    compartidos.
  
  * **Colecciones No Genéricas (System.Collections):** Son las colecciones
    originales de C# 1.0 (`ArrayList`, `Hashtable`). Operan únicamente con el tipo
    base `object`. Actualmente están **en desuso** y solo se preservan en el
    framework por motivos de compatibilidad hacia atrás.

# 20260618
Hay distintos tipos de colecciones:

* Listas
  * Listas dinámicas
  * Enlazadas (Linked List)
    * Permite acceso aleatorio
  * Pilas (Stack)
    * LIFO Ultima entrada primera salida
  * Colas (Queue)
    * Primera entrada primera salida (FIFO)
* Diccionarios
  * Almacena elementos con estructura de clave-valor
* SortedList
  * Igual que los diccionarios pero que están ordenados
* Conjuntos
  * Listas de valores pero sin ordenar
* HashTable
<!--TODO: Buscar Lo que establece un diccionario, un conjunto y una hash table-->

`namespace System.Collections` forma parte de lo que se tiene que poner para que se pueda acceder a las colecciones.

### TP
1. Defina que es una lista.
2. Cual es son las caracetrísticas de una lista
3. Mencione los distintos tipos de listas
4. Cómo se declara una lista en C#. Explique cada uno de sus elementos.
5. Cómo se añade elementos a la lista en C#
6. Explique que función cumple:
    - Add()
    - Count()
    - Remove() / RemoveAt()
    - Sort()

#### Desarrollo
1. Una lista es una clase de colección genérica dinámica en la que se guardan
   elementos fuertemente tipado que ofrece expasión automática de tamaño.
2. Tiene seguridad de tipo, tiene indexación en 0 y posee una serie de métodos
   varios para poder trabjar sobre ellos.
3. Hay `LinkedList<T>`, `SortedList<T>`
4. 
   List<T> NombreDeLaLista = new List<T>();
   

   Se tiene que inicializar con la lista, el tag del tipo de dato, el nombre
   que se le asigna a la variable, la asignación, y la creación de un nuevo
   objeto List con el tipo de dato.
5. Se utiliza el método Add().
   
   Ej:

   
   List<int> numeros = new List<int>();
   numeros.Add(5);
   
   
6.
    * Add(): Agrega un elemento a la lista
    * Count(): Permite saber cuantos elementos tiene una lista
    * Remove(): Permite remover el elemento indicando el elemento de la lista a
      ser removido
    * RemoveAt(): Permite remover el elmento por su índice
    * Sort(): Ordena los elementos de la lista

# 20260619

1. Ventajas, desventajas lista
2. ```
   | |-> | |->| |-> | |->| |-> | |
   ```
3. Una lista de inventario de objetos del mismo tipo,
   un listado de números de identificación,
   una lista de precios
4. Un nodo contiene dos componentes:
   - El dato: información que se desea guardar
   - Puntero: Apunta al siguiente nodo de la secuencia
5. Se da cuenta que se ha llegado al final porque el último nodo apunta a un puntero nulo
6. Es de comportamiento LIFO (Last In, First Out). Es decir que todo elemento que sale es el último
de la estructura
   mientras que para entrar entra al final de la estructura.

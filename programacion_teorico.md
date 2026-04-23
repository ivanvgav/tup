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

Simbolos para poder realizar distintas operaciones (matemáticas, lógicas, de asignación)
Estos operadores actuan sobre variables y valores

- Aritmetica: Suma, resta, división y multiplicación, modulo
    - La Suma sirve para anexar algo (concatenar)
- Relacionales: Igualdad (==), Diferencia (!=), Mayor a (>), menor a (<), mayor o igual a (>=), menor o igual a (<=)
- Lógica: Y Conjunción (&&), O Disyunción (||), negación (!)
- Asignaciones: =
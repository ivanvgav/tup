---
title: Arquitectura y SO
subtitle: Ing. Irina Ayunta - TUP - UNT-FRT
author: Gavriloff, Ivan Vladimir
year: 2026
---

PARCIAL: MITAD DE MAYO

# Unidad 2 - Sistemas Operativos

> Intermediario entre el usuario y el hardware

Objetivos principales:

- Hacer un entorno conveniente para el usuario
- Hacer que el sistema sea fácil de usar para el usuario final

Gestión de hardware:

- Administra los recursos del sistema: tiempo del CPU, espacio de memoria, dispositivos de entrada y salida

Control de ejecución:

- Funciona en el control de los programas para que no haya conflicto entre los programas

El SO oculta la complejidad del sistema (oculta registros y procesos)
Además hace que sea fácil usar cada uno de los cada periféricos, gracias al SO.

## Conceptos fundamentales
Multiprogramación:

- Capacidad de mantener varios trabajos en memoria simultáneamente
- Maximizar la utilización del procesador, siendo que el CPU siempre tenga algo que ejecutar.
    - El SO hace la asignación de particiones de memoria para cada uno de los trabajos
    - No se trabaja en simultáneo, solo se ordena

Multitarea (Concurrencia):

- La CPU alterna entre los procesos de manera rápida para que los usuarios puedan trabajar con ellos.
  Esto se hace de manera concurrente.
- Pone en foco el tiempo del respuesta para el usuario

Multiprocesamiento (Paralelismo):

- Uso de uno o más procesadores (CPU) para la ejecución de uno o varios procesos (Wikipedia)
- Se distribuye partes de una tarea en distintas partes de una tarea
- Sirve de referencia a la cantidad de procesadores utilizados

Estos tres conceptos no son lo mismo.
El primero tiene que ver con la relación en el uso de la memoria y como se mantienen los procesos en ella.
La multitarea tiene que ver como se ejecutan los programas y procesos de manera concurrente en un mismo CPU.
El multiprocesamiento tiene que ver con el uso de múltiples CPUs para la ejecución de un mismo o proceso o de varios,
en este no hay uso de concurrencia.

## Características del SO

- Garantiza una cierta seguridad y protección de virus

## Kernel
Se encarga de los recursos básicos, la planificación de CPU, la gestión de procesos y la comunicación con ellos
Ej: Kernel Linux, Kernel Windows

## El núcleo
Único programa que se ejecuta en todo momento
Su modo Kernel lo que permite tener acceso sin restricciones a todos los recursos físicos (`modo = 0`)

El modo usuario (`modo = 1`):
Está restringido en donde se ejecuta las aplicaciones sin acceso al hardware

Para cambiar de modo se hace un llamado al sistema (trap) cuando el se necesita un servicio del SO

# Situaciones de modos

Referencias:
- MU $\rightarrow$ Modo Usuario
- MK $ \rightarrow$ Modo Kernel

1. MU
2. MK
3. MU
4. MK -> En realidad es MU ya que se tiene que hacer la ejecución de `trap`.
   El `trap` es el cambio de modo.
   El ciclo completo es: se ejecuta el programa (MU), pide guardar (cambio a MK),
   el kernel escribe el disco (MK) y luego cambia a MU.
5. MK
6. MU
7. MK
8. MU
9. MK
10. MU

## Uso de `trap` en acción

```c
#include <unistd.h>

int main()
{
  char nombre[20];

  read(0, nombre, 20); //modo kernel

  //Aquí se juega el `trap` ya que se cambia el modo de kernel a usuario
  write(1, nombre, 20); //modo usuario

  return 0;
}
```

## Actividades
Explica qué pasa cuando guardas un archivo en la computadora. ¿Qué hace el programa? (MU)
¿Qué hace el kernel? (MK)

- Al guardar primero el programa pide guardar el archivo, para hacerlo debe de cambio de MU a MK.
  Luego MK escribe el archivo en el disco para luego volver a MU.

Indica $V$ o $F$:

- Los programas pueden acceder directamente al kernel $F$ ✅
- EL kernel tiene acceso total a la computadora $V$ ✅
- El modo usuario es más seguro que el modo kernel $V$ ✅
- El kernel solo se ejecuta cuando abrimos un programa $F$ ✅
- El SO protege el hardware de los programas $V$ ✅

## 20260416

# Bit

Bit (b) $=$ Binary Digit
Tiene los valores de `0` y `1`.
Unidad de almacenamiento más pequeña que existe

Byte (B)
Cada caracter tiene el tamaño de un byte.
Un byte son 8 bits

| 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | Almacenamiento de `8` bits
| 7 | 6 | 5 | 4 | 3 | 2 | 1 | 0 | posición de `8` bits

| 0 | 0 | 0 | 0 | 0 | 0 | 0 | 1 | Almacenamiento de `8` bits

| 0 | 0 | 0 | 0 | 0 | 0 | 1 | 0 | Almacenamiento de `8` bits

| 0 | 0 | 0 | 0 | 0 | 0 | 1 | 1 | Almacenamiento de `8` bits

TABLAS ASCII-UTF

ASCII trabajaba con 7 bits

Binario a Decimal:
Tomar en cuenta los bits que son `1`.
Se va de atrás para adelante
Nos interesa las posiciones.
Se ve los `1` multiplicados por 2 elevado a la posición del único.
Por cada uno se suman las multiplicaciones.

EJ:

| `0` | `0` | `1` | `0` | `1` | `0` | `0` | `1` | = $1 * 2^0 + 1 * 2^3 + 1 * 2^5 = 41$


| `1` | `1` | `1` | `1` | `1` | `1` | `1` | `1` | = $1 * 2^0 + 1 * 2^1 + 1 * 2^2 + 1 * 2^3 + 1 * 2^4 + + 1 * 2^5 + + 1 * 2^6 + + 1 * 2^4 = 255$ más el $0$ que serían 256.

bit (b) -> Byte (B) -> KB -> ---- MB -> ---- GB -> ------- TB

-------- / 8 ------- / 1024 - / 1024 - / 1024 - / 1024

bit (b) <- Byte (B) <- KB <- ---- MB <- ---- GB <- ------- TB

-------- * 8 ------- * 1024 - * 1024 - * 1024 - * 1024

Se pueden simplificar los cálculos en 1000.

## Actividad

Mi reproductor de MP# tiene una capacidad de almacenamiento de 8 GB,
si se tiene en cuenta que una canción ocupa 5 MB.

1. Cuantas canciones caben em el reproductor
1. SI cada canción dura aprox. 4 min.
  ¿Cuantos minutos de sonido puede almacenar el reproductor?

---

  1. $(8 * 1024)/5 = 1638.4$
  2. $1638 * 4 = 6552$

---

UN celular tiene una tarjeta de memoria de 4GB
- Calcular cuantas fotos 2,5 mb puede almacenar
- ¿y si cada foto ocupara un espacio de 850 kb?

En una carta redactada hay un total 8600 B o caracteres ¿Cuantos kb ocupan de espacio?

1638.4

4934.475294117647

8.3984375


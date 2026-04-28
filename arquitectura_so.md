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

# 20260421

## TP Unidad 2

### Problema 2
$2GB = (2 * 1024)MB = 2048MB$

Cantidad de fotos: $2048/2 = 1024$ fotos

### Problema 3


### Problema 5

450 bytes en MB

$(450/1024)/1024 = 0.0004291534423828125$ MB

### Problema 6

88276,80MB = $86.2078125$ GB

10.7GB

1048.231 Kb = $0.0009996709823608398$ GB

3045760996 Bytes = $2.836585972458124$ GB

$10.7 + 2.836585972458124 + 0.0009996709823608398$ = $13.537585643440485$ GB ocupados

$86.2078125 - 13.537585643440485$ = $72.67022685655952$ GB libres

### Problema 7
2715kb

$1$ GB = $1048576$ kb

Cantidad de imágenes: $1048576 / 2715$ = $386$
### Problema 8

4.7GB en MB
CD de 700 MB

$4.7 * 1024 = 4812.8$ MB

Cantidad de CDs: $4812.8 / 700 = 6.8754285714285714$ casi 7 CDs

### Problema 9
64 GB a Bytes

$64 * 1024 * 1024 * 1024 = 68719476736$ Bytes

### Problema 10

100 temas de 3072 kb
Mp3 de 512MB

$3072/1024$ = 3 MBs

$3 * 100 = 300$ MBS

Si entran

### Problema 11
`Juliana.doc` 1034 kb $\rightarrow$ $1034/1024 = 1.009765625$ MB

`Carlos.RTF` 2048 Bytes $\rightarrow$ $2048/(1024*2) = 1$ MB

`Guia_de_clientes` 5120 kb $\rightarrow$ $5120/1024 = 5$ MB

Suma total: $1.009765625 + 1 + 5 = 7.009765625$ MB

DVD 48128 MB

Se necesita 1.

# 20260423

- SO integrados - microprocesadores (arduino, electrodomesticos)
- SO distribuidos - muchas computadoras en una sola
- SO tiempo real - para errores totalmente mínimos (aviones)
- SO cluster - administra grupo de computadoras que permite realizar un tarea en base a varias computadoras
- SO popular - Para uso cotidiano y personales

Mainframe:
  - Computadora de uso empresarial, de uso potente
  - Se usa en los bancos o ciertas áreas de gobiernos

Tipos de arquitectura de SO
  - Núcleo monolítico
    - La mayoría de los procesos trabaja en modo kernel
  - A diferencia del micro kernel
    - La mayoría es en modo usuario
  - Híbrido
    - Ofrece un equilibrio entre rendimiento y modularidad

## Procesos

Los programas en realidad son procesos.
El proceso no solo implica el código, sino todo lo necesario para poder trabajar

Parcial: Semana del 19/5 o 21/5

# 20260428

## Algoritmos de procesos

Un proceso es una entidad activa, incluye los recursos asignados y los estados asociados en cada momento.
El proceso incluye:
- Código
- Estado actual
- Datos para su ejecuación (en memoria)
- Recursos asignados (CPU)

### Ciclo de vida
1. Nuevo
2. Listo (ready) -> Espera la ejecución
3. Activo (en ejecución)
4. Bloqueado (espera a un evento)

Luego se termina el proceso cuando finaliza su proceso

PCB (Process control  block)
- Identificador de procesos
- Estado actual
- Recursos asignados

### Procesos vs hilos
Los hilos comparten misma memoria de un proceso padre
Un error de un hilo afectan a todos los demás.
Se usan para tareas paralelas de una misma aplicación.
Son más eficientes que un proceso en si mismo

## TP 3
1. a. Primero: Nuevo - Listo
      Segundo: Activo
      Cuarto: Bloqueado (espera información)
      Quito: Ejecución
      Sexto: Proceso terminado
   b. El nuevo es provocado por la apertura del navegador. (no interviene la CPU)
      El proceso es seleccionado por el planificador del SO (interviene la CPU)
      Se bloquea ante la solicitud de recursos por parte del proceso (no interviene la CPU
      Al tener nuevos recursos disponibles se vuelve a cambiar el estado del proceso para mostrarlo (interviene la CPU)
      Se termina el proceso una vez cerrado (no interviene la CPU)
2. 

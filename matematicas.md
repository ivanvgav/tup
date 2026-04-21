# 20260413 - matemáticas

- [/] Hacer el práctico n1

## TP 1

1. b (Se puede comprobar históricamente); c (se puede verificar si es un lenguaje);
   e (se puede verificar la nacionalidad y la profesión); g (se puede verificar si es un número primo);
   h (es una suma de dos números); j (se puede verificar si es un número par).

2. a. $V$ b. $F$ c. $V$ d. $F$ e. $V$ f. $F$ g. $F$ h. $V$ i. $V$ j. $F$ (no es proposición) k. $V$ l. $V$ m. $F$

3. a. $p \rightarrow q$ b. $\neg (p \land q)$ c. $p \lor \neg q$ d. $p \iff q$
   e. $q \iff (p \land \neg r)$ f. $(p \land q) \rightarrow (\neg r \lor s)$ g.
   $(p \rightarrow q) \land (q \rightarrow p)$

8. a. No es cierto que no estudié.
   b. Trabajo en docencia e investigación
   c. No es cierto que iré al cine o a la fiesta
   d. No es cierto que si estudio, apruebo

10.

##### 1. $\neg (p \land q) \iff (p \lor q)$

| $p$ | $q$ | $p \land q$ | $\neg (p \land q)$ | $p \lor q$ | $\neg (p \land q) \leftrightarrow (p \lor q)$ |
|-----|-----|-------------|--------------------|------------|----------------------------------------------|
| $T$ | $T$ | $T$         | $F$                | $T$        | $F$                                          |
| $T$ | $F$ | $F$         | $T$                | $T$        | $T$                                          |
| $F$ | $T$ | $F$         | $T$                | $T$        | $T$                                          |
| $F$ | $F$ | $F$         | $T$                | $F$        | $F$                                          |

---

##### 2. $(p \lor q) \iff (\neg p \land \neg q)$

| $p$ | $q$ | $p \lor q$ | $\neg p$ | $\neg q$ | $\neg p \land \neg q$ | $(p \lor q) \leftrightarrow (\neg p \land \neg q)$ |
|-----|-----|------------|----------|----------|------------------------|----------------------------------------------------|
| $T$ | $T$ | $T$        | $F$      | $F$      | $F$                    | $F$                                                |
| $T$ | $F$ | $T$        | $F$      | $T$      | $F$                    | $F$                                                |
| $F$ | $T$ | $T$        | $T$      | $F$      | $F$                    | $F$                                                |
| $F$ | $F$ | $F$        | $T$      | $T$      | $T$                    | $F$                                                |

---

##### 3. $q \land (\neg r \land p)$

| $p$ | $q$ | $r$ | $\neg r$ | $\neg r \land p$ | $q \land (\neg r \land p)$ |
|-----|-----|-----|----------|------------------|----------------------------|
| $T$ | $T$ | $T$ | $F$      | $F$              | $F$                        |
| $T$ | $T$ | $F$ | $T$      | $T$              | $T$                        |
| $T$ | $F$ | $T$ | $F$      | $F$              | $F$                        |
| $T$ | $F$ | $F$ | $T$      | $T$              | $F$                        |
| $F$ | $T$ | $T$ | $F$      | $F$              | $F$                        |
| $F$ | $T$ | $F$ | $T$      | $F$              | $F$                        |
| $F$ | $F$ | $T$ | $F$      | $F$              | $F$                        |
| $F$ | $F$ | $F$ | $T$      | $F$              | $F$                        |

---

##### 4. $(q \rightarrow p) \rightarrow \neg q$

| $p$ | $q$ | $q \rightarrow p$ | $\neg q$ | $(q \rightarrow p) \rightarrow \neg q$ |
|-----|-----|-------------------|----------|----------------------------------------|
| $T$ | $T$ | $T$               | $F$      | $F$                                    |
| $T$ | $F$ | $T$               | $T$      | $T$                                    |
| $F$ | $T$ | $F$               | $F$      | $T$                                    |
| $F$ | $F$ | $T$               | $T$      | $T$                                    |

---

##### 5. $p \rightarrow (\neg q \land r)$

| $p$ | $q$ | $r$ | $\neg q$ | $\neg q \land r$ | $p \rightarrow (\neg q \land r)$ |
|-----|-----|-----|----------|------------------|----------------------------------|
| $T$ | $T$ | $T$ | $F$      | $F$              | $F$                              |
| $T$ | $T$ | $F$ | $F$      | $F$              | $F$                              |
| $T$ | $F$ | $T$ | $T$      | $T$              | $T$                              |
| $T$ | $F$ | $F$ | $T$      | $F$              | $F$                              |
| $F$ | $T$ | $T$ | $F$      | $F$              | $T$                              |
| $F$ | $T$ | $F$ | $F$      | $F$              | $T$                              |
| $F$ | $F$ | $T$ | $T$      | $T$              | $T$                              |
| $F$ | $F$ | $F$ | $T$      | $F$              | $T$                              |

---

##### 6. $\neg (p \lor r) \rightarrow (\neg q \lor \neg p)$

| $p$ | $q$ | $r$ | $p \lor r$ | $\neg (p \lor r)$ | $\neg q$ | $\neg p$ | $\neg q \lor \neg p$ | $\neg (p \lor r) \rightarrow (\neg q \lor \neg p)$ |
|-----|-----|-----|------------|--------------------|----------|----------|------------------------|----------------------------------------------------|
| $T$ | $T$ | $T$ | $T$        | $F$                | $F$      | $F$      | $F$                    | $T$                                                |
| $T$ | $T$ | $F$ | $T$        | $F$                | $F$      | $F$      | $F$                    | $T$                                                |
| $T$ | $F$ | $T$ | $T$        | $F$                | $T$      | $F$      | $T$                    | $T$                                                |
| $T$ | $F$ | $F$ | $T$        | $F$                | $T$      | $F$      | $T$                    | $T$                                                |
| $F$ | $T$ | $T$ | $T$        | $F$                | $F$      | $T$      | $T$                    | $T$                                                |
| $F$ | $T$ | $F$ | $F$        | $T$                | $F$      | $T$      | $T$                    | $T$                                                |
| $F$ | $F$ | $T$ | $T$        | $F$                | $T$      | $T$      | $T$                    | $T$                                                |
| $F$ | $F$ | $F$ | $F$        | $T$                | $T$      | $T$      | $T$                    | $T$                                                |---

Esto es una tautología

## Leyes lógicas

Las Leyes lógicas son tautológicas son verdaderas siempre, son formas válida del razonamiento
Sin importar el valor de verdad de las proposiciones componentes.
Se nota con el $T$ (*true*) o $\top$.

Ej.: Propiedad distributiva de la disyunción:

$$[p \lor (q \land r)] \iff [(p \lor q) \land (p \lor r)]$$
<!-- TODO: Mostrar tablas de verdad -->

Si se hace la tabla de verdad su resultante va a ser todas verdaderas.
Sin importar lo que sean esa proposiciones siempre va a dar verdadera.

## TP 2
### Simplificación de proposiciones

2. a.

    $p  \lor [p \land (q \lor p)] \iff p$

    $p \lor p \iff p$ Absorción total de la disyunción

    $p \iff p$ Idempotencia

    $p$ Definición del bicondicional

    ---

b.

   $[(p \lor q) \lor (p \lor r)] \iff (p \lor q) \lor r$

   $[p \lor q \lor p \lor r] \iff (p \lor q) \lor r$ Propiedad asociativa

   $[p \lor p \lor q \lor r] \iff (p \lor q) \lor r$ Propiedad conmutativa

   $[p \lor q \lor r ] \iff (p \lor q) \lor r$ Idempotencia

   $(p \lor q \lor r ) \iff (p \lor q \lor r)$ Propiedad asociativa

---

c.

   $\neg (\neg p \lor \neg q) \iff p \land q$

   $(\neg \neg p \land \neg \neg q) \iff p \land q$ De Morgan

   $(p \land q) \iff p \land q$ Involución

---

d.

   $\neg [(r \lor p) \land \neg p] \iff \neg r \lor p$

   $\neg [(r \land \neg p)] \iff \neg r \lor p$ Absorción parcial

   $(\neg r \lor \neg \neg p) \iff \neg r \lor p$ De Morgan

   $(\neg r \lor p) \iff \neg r \lor p$ Involución

---

3. Determinar el valor de verdad dada solo que $p = V$

a. $(p \lor q) \iff (\neg p \land \neg q)$

Va a ser siempre verdadero. El primero es una disyunción que siempre va a ser $V$.
El segundo va a ser falso porque es una conjunción. Entonces el bicondicional es distintos
por lo que es falso. Por tanto, el bicondicional $F$.

b. $(p \land q) \rightarrow (p \lor q)$

$p$ es verdadero por lo que va a depender del valor de q. Puede ser verdadero o falso.
El consecuente va a ser siempre verdadero porque $p$ es $V$ siempre.
Tenemos un consecuente que siempre es verdadera por lo que el condicional es $V$.

c. $(p \land q) \rightarrow r$

El antecedente va a depender del valor de $q$. $r$ no sabemos su valor de verdad.
Por tanto el condicional va a depender del valor de $r$.
No basta saber solo el valor de verdad de $p$ para determinar toda la proposición.

# 20260414

4. $p = V \ q = V\  r = F$

$\neg [(p \iff q) \land \neg (\neg q \lor r)] = \bot$

$\neg [(\top \iff \top) \land \neg (\bot \lor \bot)] = \bot$

$\bot \land \top = \bot$

$\bot = \bot$

5. $(\neg p \land q) \rightarrow q = \bot$

a. $(\neg p \land q \land r)$

Si $(\neg p \land q)$ es $V$ y $q$ es $F$. Para que $(\neg p \land q)$ sea $V$
la conjunción tiene que ser $V$, por lo que $\neg p$ es

$(\neg p \land q \land r)$ $\neg q$ es $V$ pero no puedo determinar el valor de verdad
de la proposición. Faltan los valores de $\neg p$ y $r$.

d. $(\neg r \lor q) \lor p$

Si $q$ es $F$ pero no podemos saber el valor de disyunción interna, y lo mismo
con la disyunción de $p$ porque no podemos saber el valor de $p$.

##### 6.

a. $(p \lor q) \iff (\neg p \land \neg q)$ con $q = V$

El primer disyunto del bi condicional es $V$. En la conjunción siempre va a ser $F$
ya que $\neg q$ es falsa.
El bicondicional tiene distinto valores de verdad, por lo que es $F$.

b. $(p \land q) \rightarrow (p \lor r)$ con $p = V$ y $r = F$

La disyunción va a ser verdadera. Pero en el antecedente hay una conjunción y
no tenemos el valor de $q$ ya que depende de esta proposición.
Por lo que el antecedente no sabemos su valor y si el del consecuente ($V$).
Esto siempre va a ser verdadero. EL condicional es verdadero.

c. $p \land (q \rightarrow r)$ con $q = V$

No tenemos el valor de $r$ por lo que no podemos saber si el condicional es verdadero o no.
Y como no podemos saber el valor de uno de los coyuntos no se puede saber el valor de conjunción
ya que depende de $p$ y de $r$.
Por tanto, la información no es suficiente para saber el valor de verdad de la proposición.

##### 7. $p = V q = F r = F s = V$

a. $[(p \lor q) \lor r] \land s$

La disyunción entre $p$ y $q$ es verdadera y también la disyunción con $r$ es verdadera.
Como $s$ es verdadera, ambos conyuntos son verdaderos.
Por lo que toda la conjunción es verdadera.

##### 8. Simplificar

a. $\neg (\neg p \lor \neg q) \rightarrow p \land q$ por De Morgan e involución

---

b. $\neg (p \lor q) \lor (\neg p \land q)$

$(\neg p \land \neg q) \lor (\neg p \land q)$ Por De Morgan

$\neg p \land (\neg q \lor q)$ Distribución de la conjunción

$\neg p \land \top$ Principio de tercer excluido (opuesto para la disyunción)

$\neg p$ Elemento neutro de la conjunción

---

b'. $\neg (p \lor \neg q) \lor \neg (p \land q)$

$(\neg p \land q) \lor (\neg p \lor \neg q)$ De Morgan

$[(\neg p \land q) \lor \neg p \lor \neg q$ Propiedad asociativa

$\neg p \lor \neg q$ Absorción total

---

c. $(\neg p \rightarrow q) \lor \neg (q \rightarrow p)$

$(p \lor q) \lor \neg (\neg q \lor p)$ Definición de condicional

$(p \lor q) \lor (q \land \neg p)$ De Morgan

$(p \lor q \lor q) \land \neg p$ Asociativa

$(p \lor q) \land \neg p$ Idempotencia

---

$(\neg \neg p \lor q) \lor \neg (q \rightarrow p)$ Def de implicacia

$(p \lor q) \lor (q \land \neg p)$ Equivalencia de negación de implicancia

$p \lor q \lor (\neg p \land q)$ Asociativa

$p \lor [q \lor (\neg p \land q)]$ Asociativa

$p \lor q$ Absorción total

# 20160420

8. d. $(p \rightarrow \neg q) \land \neg (\neg q \rightarrow p)$

$(\neg p \lor \neg q) \land (\neg q \land \neg p)$ Equivalencia de la negación de implicacia

$(\neg p \lor \neg q) \land \neg q \land \neg p$ Asociativa

$[(\neg p \lor \neg q) \land \neg q] \land \neg p$ Asociativa

$\neg q \land \neg p$ Absorción total

$\neg p \land \neg q$ Conmutativa

---

## Circuitos lógicos

La verdad de una propisición se puede asociar al paso de corriente en un
circuito electrico. Si la proposición es $V$ entonces el circuito está cerrado y
si es $F$ está abierto.

La conjunción y la disyunción tienen asociada un circuito. Por lo que para
trabajar con ellas hay que hacer transformaciones.

La conjunción es un circuito en serie (una línea), se abre con solo con que una
de las proposiciones sea $F$. La disyunción es un circuito en paralelo (dos
líneas). No pasa corriente si las dos están $F$ ya que ambas están abiertas.
Sino una va a estar cerrada y puede pasar corriente por ahí. Ni la implicancia,
ni el bicondicional ni la disyunción exclusiva tienen circuitos asociados.
Al diagramar los circuitos estos tienen que quedar abiertos.

Para poder diagramar bien hay que tener en cuenta los alcances de las conjunciones y disyunciones.
Hay que tener en cuenta de nombrar cada una de las puertas con las proposiciones que tienen.
Siempre hay que tener en cuenta por donde hay que cerrar los circuitos.

### Ejercicios de circuitos lógicos (electrónicos)
<!-- TODO(ivan): Agregar las fotos. Para eso crear una carpeta con las imágenes -->
<!-- TODO(ivan): Modificar los últimos puntos porque no están bien todos -->
<!-- TODO(ivan): Verificar en el 11 donde se puede hacer el gráfico inicial -->

# 20260421

Se realizo los ejercicios 10b y 10e; 11a, 11b; 12a, 12d de circuitos eléctricos
En 11b se da con que las disyunciones van a irse y luego quedaría $\top$
porque siempre va a ser verdadera la disyunción.
En 11d se puede seguir, hacer inversa de la distribución y luego opuesto de conjunción
quedaría ($q \lor \bot$) y luego elemento neutro quedando $q$.

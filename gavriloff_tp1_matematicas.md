---
title: TP 1 - Matemáticas
subtitle: TUP - 2026 - UTN-FRT
author: Gavriloff, Ivan Vladimir
pagesize: a4
header-includes:
  - \usepackage{array}
  - \usepackage{booktabs}
format: pdf
---

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

###### 1. $\neg (p \land q) \iff (p \lor q)$

\[
\begin{array}{c c c c c c}
\toprule
p & q & p \land q & \neg (p \land q) & p \lor q & \neg (p \land q) \leftrightarrow (p \lor q) \\
\midrule
T & T & T & F & T & F \\
T & F & F & T & T & T \\
F & T & F & T & T & T \\
F & F & F & T & F & F \\
\bottomrule
\end{array}
\]

###### 2. $(p \lor q) \iff (\neg p \land \neg q)$

\[
\begin{array}{c c c c c c c}
\toprule
p & q & p \lor q & \neg p & \neg q & \neg p \land \neg q & (p \lor q) \leftrightarrow (\neg p \land \neg q) \\
\midrule
T & T & T & F & F & F & F \\
T & F & T & F & T & F & F \\
F & T & T & T & F & F & F \\
F & F & F & T & T & T & F \\
\bottomrule
\end{array}
\]

###### 3. $q \land (\neg r \land p)$

\[
\begin{array}{c c c c c c}
\toprule
p & q & r & \neg r & \neg r \land p & q \land (\neg r \land p) \\
\midrule
T & T & T & F & F & F \\
T & T & F & T & T & T \\
T & F & T & F & F & F \\
T & F & F & T & T & F \\
F & T & T & F & F & F \\
F & T & F & T & F & F \\
F & F & T & F & F & F \\
F & F & F & T & F & F \\
\bottomrule
\end{array}
\]

###### 4. $(q \rightarrow p) \rightarrow \neg q$

\[
\begin{array}{c c c c c}
\toprule
p & q & q \rightarrow p & \neg q & (q \rightarrow p) \rightarrow \neg q \\
\midrule
T & T & T & F & F \\
T & F & T & T & T \\
F & T & F & F & T \\
F & F & T & T & T \\
\bottomrule
\end{array}
\]

###### 5. $p \rightarrow (\neg q \land r)$

\[
\begin{array}{c c c c c c}
\toprule
p & q & r & \neg q & \neg q \land r & p \rightarrow (\neg q \land r) \\
\midrule
T & T & T & F & F & F \\
T & T & F & F & F & F \\
T & F & T & T & T & T \\
T & F & F & T & F & F \\
F & T & T & F & F & T \\
F & T & F & F & F & T \\
F & F & T & T & T & T \\
F & F & F & T & F & T \\
\bottomrule
\end{array}
\]

###### 6. $\neg (p \lor r) \rightarrow (\neg q \lor \neg p)$

\[
\begin{array}{c c c c c c c c c}
\toprule
p & q & r & p \lor r & \neg (p \lor r) & \neg q & \neg p & \neg q \lor \neg p & \neg (p \lor r) \rightarrow (\neg q \lor \neg p) \\
\midrule
T & T & T & T & F & F & F & F & T \\
T & T & F & T & F & F & F & F & T \\
T & F & T & T & F & T & F & T & T \\
T & F & F & T & F & T & F & T & T \\
F & T & T & T & F & F & T & T & T \\
F & T & F & F & T & F & T & T & T \\
F & F & T & T & F & T & T & T & T \\
F & F & F & F & T & T & T & T & T \\
\bottomrule
\end{array}
\]

Esto es una tautología

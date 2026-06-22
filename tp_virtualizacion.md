---
title: TP Virtualización
subtitle: TUP - UTN-FRT - 2026
author: "Gavriloff, Ivan Vladimir; García Argañaraz Uriel y Germano Cabezas, Victoria"
format: pdf
---

1. La virtualización es la tecnica que permite utilizar multiples SO en un mismo hardware usando software intermedios
2. Es la emulación de un sistema completo informático, tiene su propio vm, su
   propia configuración. Tiene su propia memoria, nucleos y almacenamiento
3.
  - T1: Sevidores empresariales, se instala directo del hardware físico
    - VMware, PROMOX, ESXi, Hyper-V
  - T2 Hosted:
    - En entornos educativos
    - VirtualBox, WMware workstation
4. El hipervisor es el software intermedio que permite virtualizar las vm en base al hardware
5. El aislamiento de una vm quiere decir que si hay alguna falla en la vm esta
   no rompe o perjudica a todo el sistema completo o físico
6. Se pueden virtualizar la memoria y los núcleos. La virtualización es el
   proceso por el cual se genera los recursos físicos de un sistema informatico de
   manera virtual, actua *como si* tuvieramos dicho hardware en la maquina virtual
7. Se produce un ahorro de costos. Se pueden tener distintos servidores dentro
   de una misma computadora fisica, por lo que no es necesario muchas
   computadoras para proveer distintos servicios (ej: servidor de
   almacenamiento, de mail en una misma computadora)
8. Un snapshot es una fotografia del estado de la maquina virtual que permite
   restaturarla rápidamente en ese momento específico. Permite una recuperación
   rápida, pruebas seguras, actualizaciones y desarrollo y capacitación.
9. Se usa virtualización en los ámbitos educativos para que los estudiantes
   puedan aprender a usar distintos software o sistemas operativos sin el
   peligro de que se rompan los equipos mientras se los testea. Además permite
   un ahorro de costo para la institución porque pueden albergar distintos
   servicios en pocas computadoras físicas
10. Al tener 4 servidores se puede hacer que uno de ellos sea específico para
    almacenamiento de distintas cosas (archivos y mails) por lo que se tendría
    que virtualizar en el dos vm que tengan cada una dicho servicio. Luego
    también es posible que uno de los servidores se emulen todo lo necesairio
    para la seguridad de todas las redes de la empresa (como ser VPN entre otros
    servicios de seguridad) por lo que la virtualización también sería necesaria
    allí. Los dos restantes podrían ser para virtualizar todo el software
    necesario para la empresa que necesita para su desarrollo (base de datos,
    contabilidad) por lo que sería necesario que se virtualice dichos servicios
    en los restasntes servidores.

# Laboratorio 04

- [Laboratorio 04](#laboratorio-04)
  - [Clonando el código](#clonando-el-c-digo)
  - [Ejercicio 1](#ejercicio-1)
  - [Ejercicio 02](#ejercicio-02)
    - [Ejemplo 2.1](#ejemplo-21)
    - [Ejemplo 2.2](#ejemplo-22)
    - [Ejemplo 2.3](#ejemplo-23)
  - [Ejercicio 03](#ejercicio-03)
    - [Ejemplo 3.1](#ejemplo-31)
    - [Ejemplo 3.2](#ejemplo-32)
    - [Ejemplo 3.3](#ejemplo-33)
  - [Ejercicio 4](#ejercicio-4)
    - [Ejemplo 4.1](#ejemplo-41)
    - [Ejemplo 4.2](#ejemplo-42)
    - [Ejemplo 4.3](#ejemplo-43)
  - [Ejercicio 5](#ejercicio-5)
    - [Ejemplo 5.1](#ejemplo-51)
    - [Ejemplo 5.2](#ejemplo-52)
    - [Ejemplo 5.3](#ejemplo-53)

## Clonando el código

1. Para iniciar el laboratorio, debe crear un *Fork* del repositorio:

![fork button](images/fork.png)

2. Clone el nuevo repositorio en su computadora y ábralo en Visual Studio.

3. Abra el archivo **Program.cs** que se encuentra en el proyecto de **Laboratorio04** y modifíquelo para que imprima su nombre, carnet y sección:

![Program](images/Program.png)

| ![Ejemplo de información del estudiante](images/NameExample.png) |
|:--:|
| *Ejemplo 0.1: Imprimiendo información del estudiante* |

## Ejercicio 1

1. En el menú de Visual Studio, en la seccion de Tests, seleccione *Run All Tests*

![Ejecutar Pruebas](images/RunTests.png)

2. La mayoría de las pruebas deberían fallar.

![Pruebas fallidas](images/FailedTests.png)

3. Abra el archivo **Ejercicio01.cs** que se encuentra en el proyecto **Laboratorio04**

![Ejercicio 01](images/Ejercicio01.png)

4. Cambie el valor de retorno de la función **Sumar** para que retorne el valor de la suma entre las variables **a** y **b**

![Funcion Sumar](images/SumFunction.png)

5. Al hacer los cambios necesarios, ejecute todas las pruebas nuevamente

![Pruebas exitosas](images/SuccessfulTests.png)

6. Agregue los cambios, haga commit y luego `git push` a su repositorio en GitHub

7. Si siguió los pasos correctamente, en su repositorio de GitHub, podrá ver los resultados de la ejecucion de sus pruebas remotamente

![GitHub Actions](images/ActionsButton.png)

## Ejercicio 02

Dado un arreglo de números enteros, calcule la suma total y el promedio de todos los números en ese arreglo.

- La función Calcular debe retornar un arreglo con la suma total en la posición 0 y el promedio en la posición 1.

### Ejemplo 2.1

    nums = [4, 8, 0, 6, 2]
    resultado = [20.0, 4.0]
___

### Ejemplo 2.2

    nums = [-1, 0, 1]
    resultado = [0.0, 0.0]
___

### Ejemplo 2.3

    nums = [100]
    resultado = [100.0, 100.0]
___

## Ejercicio 03

Dados dos strings que representan números enteros mayores o iguales a cero, **num1** y **num2**, calcule la suma de esos dos números.

- Si cualquiera de los dos números es mayor que cero, no habrán ceros previos a cualquier dígito (ejemplo: "07" no será una entrada válida)

### Ejemplo 3.1

    num1 = "1"
    num2 = "5"
    resultado = "6"
___

### Ejemplo 3.2

    num1 = "278"
    num2 = "19"
    resultado = "297"
___

### Ejemplo 3.3

    num1 = "0"
    num2 = "999999999999999999999999"
    resultado = "999999999999999999999999"
___

## Ejercicio 4

Dada una cantidad de dinero y un arreglo de billetes de diferentes denominaciones, calcule cuántos billetes se necesitan de cada denominación para suplir la cantidad de dinero.

- El arreglo de billetes se encuentra ordenado según la prioridad, es decir si el billete de 20 aparece antes que el de 50, se debe calcular antes la cantidad de billetes de 20 y luego la cantidad de billetes de 50.
- La última denominación de billetes siempre será 1.
- La cantidad de dinero NO tendrá decimales, solo se considerarán cantidades enteras.
- Ninguna cantidad de billetes aparece más de una vez.

### Ejemplo 4.1

    cantidad = 347
    billetes = [100, 50, 20, 5, 1]
    resultado = [3, 0, 2, 1, 2]

**Explicación:** la denominación con mayor prioridad es 100, por lo cual el resultado requiere 3 billetes de 100 (347 / 100). No se necesitan billetes de 50 para satisfacer la necesidad de billetes para la cantidad restante (resultado[1]). Y, por último, se requieren 2 billetes de 20, 1 de 5 y 2 de 1 para lograr la repartición de 347.
___

### Ejemplo 4.2

    cantidad = 23
    billetes = [1]
    resultado = [23]
___

### Ejemplo 4.3

    cantidad = 550
    billetes = [20, 10, 50, 1]
    resultado = [27, 1, 0, 0]
___

## Ejercicio 5

Dada una cantidad de dinero y un arreglo de billetes de diferentes denominaciones y límites por cada billete, calcule cuántos billetes se necesitan de cada denominación para suplir la cantidad de dinero.

- La posición 0 de cada arreglo de billetes representa la denominación.
- La posición 1 de cada arreglo de billetes representa el límite de billetes para esa denominación.
- Si el límite es menor a cero, se considera que no hay límite para esa denominación
- La última denominación de billetes siempre será 1 y no habrá límite para esa denominación.
- La cantidad de dinero NO tendrá decimales, solo se considerarán cantidades enteras.
- Ninguna cantidad de billetes aparece más de una vez.

### Ejemplo 5.1

    cantidad = 347
    billetes = [[100, 1], [50, 3], [20, 10], [5, -1], [1, -1] ]
    resultado = [1, 3, 4, 3, 2]

**Explicación:** se necesitan 3 billetes de denominación 100 para la cantidad de 347, sin embargo hay un límite de 1 billete para esa denominación, por lo cual resultado[0] es 1. Esto nos deja con 247 en la cantidad de dinero restante, la siguiente denominación es 50 pero tiene un límite de 3 billetes, entonces resultado[1] es 3, sin el límite se resultado[1] sería 4. Quedan 97 por repartir y la siguiente denominación es 20 con límite de 10 billetes; la cantidad de billetes requerida para esa denominación (4) es menor al límite. La siguientes denominaciones tienen límites negativos, lo cual implica que no hay límites y quedan 17 de cantidad de dinero por repartir, para lo cual se necesitan 3 billetes de 5 y 2 de 1.

___

### Ejemplo 5.2

    cantidad = 23
    billetes = [[1, -1]]
    resultado = [23]

### Ejemplo 5.3

    cantidad = 550
    billetes = [[20, 10], [10, 10], [50, 4], [1, -1]]
    resultado = [10, 10, 4, 50]
___

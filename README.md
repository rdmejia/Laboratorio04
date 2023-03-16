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

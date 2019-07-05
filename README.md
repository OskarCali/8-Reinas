# 8 REINAS con Algoritmo genetico

Esta aplicacion resuelve el problema de las 8 Reinas de ajedrez utilizando el algoritmo genetico.  
Dicha aplicacion esta desarrollada en VS 2019.1.6 :purple_heart:

---

## Contenido

* [Algoritmo Genetico](#algoritmo-genetico)
* [Problema](#problema)
* [Solucion](#soluciones)
* [Pantallas](#pantallas)
* [Acerca de](#acerca-de)

---

## Algoritmo genetico

El algoritmo genetico es un algoritmo bio-inspirado ya que esta basado en comportamientos de sistemas biologicos o de la naturaleza.  
Dicho algoritmo cuenta con una serie de pasos.

1) Iniciar poblacion con individuos al azar
2) Evaluar cada individuo
3) Repetir
    1) Seleccionar 2 padres por seleccion de torneo
    2) Generar 2 hijos a partir de los padres por cruce
    3) Modificar dichos hijos por mutacion
    4) Evalua cada hijo
    5) Selecciona los 2 mejores entre padres e hijos
    6) Remplaza los 2 mejores en los padres
4) Hasta cumplir el numero de ciclos
5) Seleccionar el mejor de toda la poblacion

<details>
<summary>Ver Pseudocodigo</summary>

``` cs
iniciarPoblacion();
evaluar(poblacion);

for(i = 0; i < ciclos; i++)
{
    padres = torneo(poblacion);
    if(random <= pCruce)
        hijos = cruce(padres);
    else
        hijos = padres;

    if(anotherRandom <= pMutacion)
        mutacion(hijos);

    evaluar(hijos);
    mejores = mejor(padres, hijos);
    generacion(mejores, padres);
}

apto(poblacion);
```

</details>

## Problema

El problema de las 8 reinas consiste en poder colocar 8 reinas en el tablero sin que ninguna de estas se amenacen entre ellas, dicho juego o planteamiento fue propuesto por el aleman Max Bezzel en 1843.

## Solucion

Para la solucion a dicho problema se cuentan con algunas restricciones que permiten o ayudan a conseguir el resultado de una manera mas sencilla.

**Restricciones:**

* Cada individuo solo podra contar con un digito del 1 al 8 sin repetirse.
* La probabilidad de cruce es de 0.65 a 0.85
* La probabilidad de mutacion es de 0.01 a 0.10

## Pantallas


## Acerca de

> Desarrollado por:  
> Oskar Cali :man_technologist: :purple_heart:  
> Camilo Emmanuel Hernandez Rosales.

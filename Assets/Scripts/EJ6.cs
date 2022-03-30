/*Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
en una variable llamada num1 y muestre un mensaje por pantalla indicando "el número es
par" o "el número es impar". Deberá utilizar el operador “módulo” es el caracter %.*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ6 : MonoBehaviour
{

    public int num1;

    void Start()
    {
        if (num1 < 1)
        {
            Debug.Log("El numero debe ser mayor que 0");
        }
        else if (num1 % 2 == 0)
        {
            Debug.Log("El número es par");
        }
        else if (num1 % 2 != 0)
        {
            Debug.Log("El número es impar");
        }
    }

    void Update()
    {
        
    }
}

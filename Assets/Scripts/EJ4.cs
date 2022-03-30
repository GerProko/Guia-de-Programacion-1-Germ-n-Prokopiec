/*Realizá un programa que permita ingresar dos números enteros num1 y num2 por
Inspector. Luego, mostrar el resultado de la suma entre ambos al ejecutar la escena
utilizando el siguiente formato: “La suma entre “ + num1 + “ y “ + num2 + “ da como
resultado “ + num1 + num2.*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ4 : MonoBehaviour
{

    public int num1;
    public int num2;

    void Start()
    {
        Debug.Log("La suma entre " + num1 + "y " + num2 + "da como resultado " + (num1 + num2));
    }

  
    void Update()
    {
        
    }
}

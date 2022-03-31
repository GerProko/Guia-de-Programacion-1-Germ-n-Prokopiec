/*Realizá un programa que, dados dos números enteros num1 y num2 cargados desde el
Inspector muestre el resultado de la división del primero por el segundo en la consola
siguiendo el formato num1 + “ / “ + num2 + “ = “ + resultado.
En el caso de que el segundo valor num2 sea cero, mostrar el siguiente mensaje de error:
“No se puede dividir por cero”.*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ5 : MonoBehaviour
{

    public int num1;
    public int num2;

    void Start()
    {

        float num1_float = (float)num1;
        float num2_float = (float)num2;

        if (num2 == 0)
        {
            Debug.Log("No se puede dividir por cero");
        }
        else
        {
        float resultado = num1_float / num2_float;
        Debug.Log (num1 + "/" + num2 + " = " + resultado);
        }
    }

    void Update()
    {
        
    }
}

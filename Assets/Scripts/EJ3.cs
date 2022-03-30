/*Crear una variable pública que permita ingresar texto. Permitir que al ejecutar el programa
se muestre en la consola un mensaje de saludo que incluya el texto de la variable. Por
ejemplo, si en la variable se ingresa el texto “Ana”, el mensaje en consola debe decir “Hola
Ana”.*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ3 : MonoBehaviour
{

    public string texto;

    void Start()
    {
        Debug.Log ("Hola " + texto);
    }

    void Update()
    {
        
    }
}

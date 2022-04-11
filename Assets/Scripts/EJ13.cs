/*Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente
manera:
• Si trabaja 40 horas o menos se le paga $16 por hora (crear una constante para almacenar
el 16)
• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20
por cada hora extra. (crear una constante para almacenar el 20)
Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla
el salario correspondiente.*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ13 : MonoBehaviour
{

    public int horas;
    int salario;
    int precio1 = 16;
    int precio2 = 20;
    int restodeHoras;

    void Start()
    {
        if (horas <= 0)
        {
            Debug.Log("La hora ingresada no es valida");
        }
        else if (horas <= 40)
        {
            Debug.Log("El salario correspondiente es $" + horas * precio1);

        }
        else if (horas > 40)
        {
            restodeHoras = horas - 40;
            Debug.Log("El salario correspondiente es $" + (40 * precio1 + restodeHoras * precio2));
        }
       
    }

    void Update()
    {
        
    }
}

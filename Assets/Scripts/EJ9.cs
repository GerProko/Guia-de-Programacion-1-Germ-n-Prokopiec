/*Realizá un programa que resuelva el siguiente problema:
Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
por las tres.
Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
mostrar lo pedido en el siguiente formato:
Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ9 : MonoBehaviour
{

    public string nombre1;
    public double ingresos1;
    public string nombre2;
    public double ingresos2;
    public string nombre3;
    public double ingresos3;
    double total;
    
        
    void Start()
    {
        total = ingresos1 + ingresos2 + ingresos3;

        double porcentaje1 = ingresos1 * 100 / total;
        double porcentaje2 = ingresos2 * 100 / total;
        double porcentaje3 = ingresos3 * 100 / total;

        Debug.Log(nombre1 + ": Capital aportado: $" + ingresos1 + ", Porcentaje del capital: " + porcentaje1 + "%");
        Debug.Log(nombre2 + ": Capital aportado: $" + ingresos2 + ", Porcentaje del capital: " + porcentaje2 + "%");
        Debug.Log(nombre3 + ": Capital aportado: $" + ingresos3 + ", Porcentaje del capital: " + porcentaje3 + "%");
        Debug.Log("Monto total aportado: " + total);
    }

    void Update()
    {
        
    }
}

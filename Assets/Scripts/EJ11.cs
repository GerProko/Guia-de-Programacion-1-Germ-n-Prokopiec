/*Realizá un programa que resuelva el siguiente problema:
Deberá ingresarse por Inspector una fecha de compra (String en el siguiente formato:
YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del
producto comprado. Mostrá a modo de ticket, la información ingresada y el monto a pagar.
Modelo de Ticket:
Fecha de Compra: YYYYMMDD
Nombre del Comprador: xxxxx xxxxx
Producto solicitado: xxxxx
Cantidad solicitada: xx
Precio Unitario: $xxx
Total a Pagar: $xxxxx*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ11 : MonoBehaviour
{
    public string fecha;
    public string nombre;
    public string producto;
    public int cantidad;
    public int precio;

    void Start()
    {
        Debug.Log("Fecha de Compra: " + fecha);
        Debug.Log("Nombre del Comprador: " + nombre);
        Debug.Log("Producto solicitado: " + producto);
        Debug.Log("Cantidad solicitada: " + cantidad);
        Debug.Log("Precio Unitario: $" + precio);
        Debug.Log("Total a Pagar: $" + cantidad * precio);
    }

    void Update()
    {
        
    }
}

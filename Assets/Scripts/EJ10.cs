    /*Realizá un programa que resuelva el siguiente problema: Nos piden desarrollar un
    programa que informe si un estacionamiento se encuentra o no abierto según la hora
    ingresada por el usuario.
    Nosotros sabemos que el estacionamiento se encuentra abierto entre las 10 y las 18hs.
    (Crear constante HORA_APERTURA = 10, y HORA_CIERRE = 18).
    Al iniciar el programa, se tomará como hora actual el valor de una variable expuesta en el
    Inspector, y deberemos setear una variable booleana llamada estaAbierto en true o false,
    según corresponda, e informar por pantalla mediante la misma si el estacionamiento se
    encuentra abierto o no. Obs: En el caso de que el valor de la variable correspona a una hora
    menor a 0 o mayor a 24, mostrar el mensaje: “Ha ingresado una hora incorrecta”*/
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class EJ10 : MonoBehaviour
    {

        const int HORA_APERTURA = 10;
        const int HORA_CIERRE = 18;
        public int hora;
        bool estaAbierto = false;

        void Start()
        {
            if (hora <= 0 || hora >= 25)
            {
                Debug.Log("La hora ingresada no es valida. (variable estaAbierto = " + estaAbierto + ")");
            }
            else if (hora > 18 || hora < 10)
            {
                estaAbierto = false;
                Debug.Log("El estacionamiento esta cerrado.(variable estaAbierto = " + estaAbierto + ")");
            
            }
            else if (hora >= 10 && hora <= 18)
            {
                estaAbierto = true;
                Debug.Log("El estacionamiento esta abierto. (variable estaAbierto = " + estaAbierto + ")" );
            }
        }

        void Update()
        {
        
        }
    }

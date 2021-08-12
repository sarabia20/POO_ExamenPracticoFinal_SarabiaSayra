using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: Registrar información del player
*/

public class BasePlayer : MonoBehaviour
{
    //Mando a llamar los datos del script ConstructorPlayer y declaro un array
    public ConstructorPlayer[] nuevoJugador;
    
    
   
    void Awake()
    {
        // Asigno datos a la cantidad de informacion que manejara los datos de constructor player
        nuevoJugador = new ConstructorPlayer [1];

        nuevoJugador[0] = new ConstructorPlayer(1,"Sofí",10,0,0);

       

    }

    
}


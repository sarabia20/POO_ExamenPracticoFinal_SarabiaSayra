using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: Registrar la colision del player con enemigo. 
*/

public class Colision : MonoBehaviour
{
    //registro de nueva variable 
    public float daño;
    
    //sirve para decir que al colisionar hara una acción
    private void OnCollisionEnter(Collision other)
    {
        //Si un objeto con la etiqueta PLayer 
        if(other.gameObject.tag == "Player")
        {
            //El objeto que tenga el script daño jugador le hara daño
            other.gameObject.GetComponent<DañoJugador>().damage(daño);
            
        }
       
    }
    
    
}


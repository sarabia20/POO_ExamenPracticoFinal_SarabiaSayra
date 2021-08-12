using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: Registrar información del daño a player. 
*/

public class DañoJugador : MonoBehaviour
{
    //variable que ayuda a relacionar al player con el daño
    Player playerData;
   
    
    
    
    void Start()
    {
        //Player data esta emparentado al componente del script Player
        playerData=GetComponentInParent<Player>();
    }
    
    
    public void damage(float daño)
    {
       //Disminuye del script player el factor llamdo vida al registrar daño
       playerData.vida -= daño;
    }

}
 

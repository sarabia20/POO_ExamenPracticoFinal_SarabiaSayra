using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: Registrar información del item al colisionar con.
*/

public class ColisionItem : MonoBehaviour
{
    //Dos varibles que alamcenaran información de item y puntos
    public float playerItem;
    public float playerKey;
    public float playerVida;
   
    
    //Registrarta la colision 
    private void  OnTriggerEnter(Collider other)
    {
          if(other.gameObject.tag == "Player")
        {
            //registra la colision en la base del control de poder con player para asi aumentar vida
            other.gameObject.GetComponent<ControlPoder>().SumaVida(playerVida);
            Destroy(gameObject);

        }
        
        //Si un objeto con la etiqueta player
        if(other.gameObject.tag == "Player")
        {
            //registra la colision en la base del control de poder con player item 
            other.gameObject.GetComponent<ControlPoder>().SumaItem(playerItem);
            Destroy(gameObject);
        }
        
        //Si un objeto con la etiqueta player
        if(other.gameObject.tag == "Player")
        {
            //registra la colision en la base del control de poder con player para darle una llave
            other.gameObject.GetComponent<ControlPoder>().SumaKey(playerKey);
            Destroy(gameObject);
        }
      

    }
    
}


 

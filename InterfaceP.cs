using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: Registrar información del player en pantalla.
*/

public class InterfaceP : MonoBehaviour
{
    [Header ("Interfaces basicas")]
    //Nueva varaible usara la informacion de la propiedad texto 
    public  Text VidaTXT; 
    public  Text ScoreTXT; 
    public  Text KeyTXT; 
    
   
   
    //El script Player sera la nueva variable playerData
    Player playerData;
    
    
    
    void Start()
    {
      //La variable playerdata sera igual al componente emparentado con el script Player
        playerData = GetComponentInParent<Player>();

      //La velocidad con que mostraran los datos
        StartCoroutine(AsignarDatos(0.1f));
    }

    
    void Update()
    {
      //Si item es nulo 
        if (VidaTXT != null)
        {
          //Mostrar el texto 
          VidaTXT.text=playerData.vida.ToString();
        }
        
        //Si score es nulo 
        if (ScoreTXT != null)
        {
          //Mostrar el texto
          ScoreTXT.text=playerData.score.ToString();
        }

        if (KeyTXT != null)
        {
          //Mostrar el texto
          KeyTXT.text=playerData.key.ToString();
        }

        
    }

    IEnumerator AsignarDatos(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

       
        if (VidaTXT != null)
        {
          VidaTXT.text=playerData.vida.ToString();
        }
        if (ScoreTXT != null)
        {
          ScoreTXT.text=playerData.score.ToString();
        }
        if (KeyTXT != null)
        {
          KeyTXT.text=playerData.key.ToString();
        }
        
    }
}
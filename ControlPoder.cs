using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: Registrar información del item al colisionar con.
*/

public class ControlPoder : MonoBehaviour
{
  //El script Player sera la nueva variable playerData
    Player playerData;
    
    
    void Start()
    {
      //La variable player data en igual al componente emparentado al script player 
      playerData=GetComponentInParent<Player>();
    }
    
    public void SumaVida (float vida)
    {
      //al componente player data sumare vida al score del script player
      playerData.vida += vida;
    }

    //Este void ayudara a registrar la accióna a hacer al momento de que pase la colicion 
    public void SumaItem (float score)
    {
      //al componente player data sumare item al item del script player
      playerData.score += score;
    }

    //Este void ayudara a registrar la accióna a hacer al momento de que pase la colicion 
    public void SumaKey (float key)
    {
      //al componente player data sumare lllave a llave del script player
      playerData.key += key;
    }
    
}


 

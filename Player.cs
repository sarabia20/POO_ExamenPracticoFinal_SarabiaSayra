using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: Registrar información del player
*/

public class Player : MonoBehaviour
{
   //Variable que alamcenan datos principales
   public int playerId;
   public string nombre;
   public float vida;
   public float score;
   public float key;

   //El script base enemigo es igual a la variable bdPlayer
    BasePlayer bdJugador;

   private void Start()
   {
    //bdPlayer es igual al objeto que tenga el script base enemigo
    bdJugador=GameObject.FindObjectOfType<BasePlayer>();

    //Carga los datos del ID
    CargarDatos(playerId);
   }

   void CargarDatos(int id)
   { 
      for (int i = 0; i <bdJugador.nuevoJugador.Length; i++)
      {
         if (bdJugador.nuevoJugador[i].playerId==id)
         {
            this.nombre= bdJugador.nuevoJugador[i].nombre;
            this.vida= bdJugador.nuevoJugador[i].vida;
            this.score= bdJugador.nuevoJugador[i].score;
            this.key= bdJugador.nuevoJugador[i].key;

            
         }
      }
   }
}


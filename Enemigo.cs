using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: Contiene la información proncipal del enemigo
*/

public class Enemigo : MonoBehaviour
{
   //Variable que alamcenan datos principales
    public int enemigoId;
    public string nombre;
    public int vida;
    private int daño;
   
   //El script base enemigo es igual a la variable bdEnemi
   BaseEnemigo bdEnemi;

   private void Start()
   {
    //bdEnemi es igual al objeto que tenga el script base enemigo
    bdEnemi=GameObject.FindObjectOfType<BaseEnemigo>();

    //Carga los datos del ID
    CargarDatos(enemigoId);
   }

   void CargarDatos(int id)
   { 
      for (int i = 0; i <bdEnemi.nuevoEnemigo.Length; i++)
      {
         if (bdEnemi.nuevoEnemigo[i].enemigoId==id)
         {
            this.nombre= bdEnemi.nuevoEnemigo[i].nombre;
            this.vida= bdEnemi.nuevoEnemigo[i].vida;
         }
      }
   }

   
}

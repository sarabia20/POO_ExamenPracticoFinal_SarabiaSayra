using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: Registrar información de lo enemigos. 
*/

[System.Serializable]
public class ConstructorEnemigo
{
    
    //Declaro variables publicas
    public int enemigoId;
    public string nombre;
    public int vida;
    private int daño;

    //Estas varables seran visualisadas y contendran información numerica y alfabetica 
    public ConstructorEnemigo(int id, string n, int vida)
    {
        //Relaciono 
        this.enemigoId = id;
        this.nombre =n;
        this.vida = vida;
    }

    //Metodos y Comportamientos 

}

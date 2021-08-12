using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: Registrar información del player
*/

[System.Serializable]
public class ConstructorPlayer 
{
    //Declaro variables publicas que alamcenaran informacionprincipal del jugador
    public int playerId;
    public string nombre;
    public int vida;
    public int score;
    public int key;
    private int daño;

    //Estas varables seran visualisadas y contendran información numerica y alfabetica    
    public ConstructorPlayer(int id, string n, int vida, int s, int i)
    {
        this.playerId = id;
        this.nombre =n;
        this.vida = vida;
        this.score = s;
        this.key = i;

    }

    //Metodos y Comportamientos 

}


 

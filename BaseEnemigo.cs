using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: Registrar datos de lo enemigos. 
*/

public class BaseEnemigo : MonoBehaviour
{
    //Mando a llamar los datos del script ConstructorPlayer y declaro un array
    public ConstructorEnemigo[] nuevoEnemigo;

    
    
    // Asigno datos a la cantidad de informacion que manejara los datos de constructor player
    void Awake()
    {
        nuevoEnemigo = new ConstructorEnemigo [3];

        nuevoEnemigo[0] = new ConstructorEnemigo(1,"calaquita1",5);
        nuevoEnemigo[1] = new ConstructorEnemigo(2,"calaquita2",7);
        nuevoEnemigo[2] = new ConstructorEnemigo(3,"calaquita3",10); 

        
    }

}

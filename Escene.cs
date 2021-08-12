using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Nombre del desarrollador: Sarabia Cruz Sayra Alondra
//Asignatura: Programcaion Orientada a Objetos
//Descripcion del usos de este codigo:
/*
Este script se utilizara para generar el cambio de escena.
*/

public class Escene : MonoBehaviour
{
    [SerializeField]
    //manda a llamar las variables de esta varable de su script original
    Player playerPuntaje;
    
    //es una variable publica con int que almacenara escenas 
    public int numeroEscena;

    

    void Start()
    {
        //player puntaje es igual a buscar un objeto con el tag Player y a su comoponenete player control
        playerPuntaje = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        //el player puntaje mandara a traer a la variable de key y esta es igual a cero
        playerPuntaje.key = 0;
    }

    private void OnTriggerEnter(Collider collision)
    {
       //si un objeto con el tag player colisiona con el dueño del script
       if (collision.gameObject.tag == "Player")
       {
            // si el player puntaje con la variable de crayola es igual a 1 
            if (playerPuntaje.key ==1 )
            {
                //cambia de escena 
                SceneManager.LoadScene(1);
            }
                
       }
        
    }

}

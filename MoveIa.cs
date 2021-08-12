using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: En este codigo enparentamos a quien debe seguir
asi miso su velocidad de avance y la distancia en la que debe detonar la persecucion,
tambien almacenamos las animaciones
*/



//Almacena las animaciones del componente Animator 
public enum EstadosAI
{ 
    Idle,
    Persecusion,
    AtaqueDistancia
}

public class MoveIa : MonoBehaviour
{
    //Todas estas son variables que nos ayudan a almacenar informacion que se utliza en todo este script 
    public EstadosAI estadoActual; 
    public Transform target;
    public float speed;
    public Animator animEne;
    public float distanciaExacta;



    void Start()
    {
      //animEne esta emparentado al componente Animator
      animEne =GetComponent<Animator>();
      //El estado incial es iddle 
      estadoActual = EstadosAI.Idle; 


      //si el target es igual a nulo
      if(target == null)
      //salta
      return;
    }

    


    void Update()
    {
      //Gnera el movimiento hacia el player     
      Vector3 direccion = target.position - transform.position;

      //Si la direccion es mayor que la distancia exacata entre el 
      //player y el enemigo 
      if(direccion.magnitude<distanciaExacta)
      {
        //Muevete en direccion al player
        Move(direccion);
        //y activa la animacion correr, lo cual es verdadero 
        ActivarAnimacionBool("run",true);
      }
      
      //Este switch administra las animaciones del componbente animator,
      //las cuales unicamente se actiavaran si se encuentran en el mismo 

      //El switch sirve para manejar diferentes casos 
        switch(estadoActual)
        {
          case EstadosAI.Idle:
          PlayAnimation("Idle");
          break;

          case EstadosAI.Persecusion:
          PlayAnimation("run");
          break;

          case EstadosAI.AtaqueDistancia:
          PlayAnimation("ataque");
          break;

          default:
          break;
        }
    }

    
    //Normaliza el movimiento del enemigo, en mi caso funciono ya que mi 
    //juego tiene una mezcla de 3d y 2d, y ayuda a nivelar todo 
    private void Move(Vector3 direccion)
    {
      this.transform.Translate(direccion.normalized*speed*Time.deltaTime, Space.World);
    }
      
    //Activar y Play me funcionan para activar las animaciones en diferentes sircunstrancias  
    private void ActivarAnimacionBool(string nombreAnimacion, bool valor)
    {
      animEne.SetBool(nombreAnimacion,valor);
    }

    private void PlayAnimation(string nombreClip)
    {
      animEne.Play(nombreClip);
    }
   
    
}

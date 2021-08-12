using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: En este codigo generamos radares para el enemigo, 
ayuda a girar a el enemigo, asi mismo a detonar animaciones de ataque y persecusion  
*/

public class RdarZona : MonoBehaviour
{

    //Todas estas son variables que nos ayudan a almacenar informacion que se utliza en todo este script 
   MoveIa estados;

   public float rangoAtaque;

   public LayerMask layerMask;

   public Transform radarIzq;
   public Transform radarDer;



   public float rangIzq, rangDer;

   public SpriteRenderer sprite;

   
   //
   void Start() 
   {
       //estados esta emparentado al componente del script MoveIA
       estados = GetComponentInParent<MoveIa>();
       
       //Si el sprite es nulo 
       if(sprite !=null)
       //entonces sprite es igual al componente Sprite Renderer 
       sprite=GetComponent<SpriteRenderer>();
   }

    
    //Todo esto le da color a la esfera para identificar los diferentes radares 
    void OnDrawGizmos() 
   {
       Gizmos.color =Color.red;
       Gizmos.DrawWireSphere(transform.position,rangoAtaque);

       
       Gizmos.color =Color.cyan;
       Gizmos.DrawWireSphere(radarDer.position, rangDer);
       
       Gizmos.color =Color.green;
       Gizmos.DrawWireSphere(radarIzq.position, rangIzq);
   }

   //Se encarga de ejecutar
   void Update()
   {
       RdarAta3D();
       RdarDer3D();
       RdarIzq3D();
   }


    
    //Almacena la informacion la animacion de ataque mediante radar 
void RdarAta3D()
    {
       //El bool hace que podamos usar el true y false, en este caso radar ataque es igual a la esfera
       bool radarBool = Physics.CheckSphere(transform.position,rangoAtaque,layerMask);
       //si la esfera es igual a verdadero 
       if(radarBool == true)
       {
           //el estado actual sera el ataque de distancia, el cual almacena el componente animator con la animacion run
           estados.estadoActual =EstadosAI.AtaqueDistancia;
       }
       else
       {
           //en caso de estar fuera de radar regresara a su idle
           estados.estadoActual =EstadosAI.Idle;
       }
    }
   
   
   //Almacena la informacion de giro mediante radar 
   void RdarIzq3D()
   {
       //El bool hace que podamos usar el true y false, en este caso radar ataque es igual a la esfera
      bool radarAtaque = Physics.CheckSphere(radarIzq.position,rangIzq,layerMask);
       //si la esfera es igual a verdadero 
       if(radarAtaque == true)
       {
           //el sprite Renderer sera verdadero
           sprite.flipX=true;
       }

   }
   
   
   //Almacena la informacion de giro mediante radar 
   void RdarDer3D()
   {
      //El bool hace que podamos usar el true y false, en este caso radar ataque es igual a la esfera
      bool radarAtaque = Physics.CheckSphere(radarDer.position,rangDer,layerMask);
       //si la esfera es igual a verdadero 
       if(radarAtaque == true)
       {
           //el sprite Renderer sera falso y girara 
           sprite.flipX=false;
       }
   }

   

}

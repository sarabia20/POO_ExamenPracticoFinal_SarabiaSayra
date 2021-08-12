using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: En este codigo hereda la información de base control
mantener mayor orden 
*/


public class PlayerControl : BaseControl
{
    
    
    // Trae y carga los componentes del personaje, esta acomodado asi para tener mayor orden
    void Update()
    {
        controlPersonaje();
        Salto();
        Agacharse();
        Deslisarse();
    }



    //
    protected override void controlPersonaje()
    {
        //Indicamos el movimiento con get axis indicando que se puede mover con w,s,d o las flechas
        float horizontal = Input.GetAxis("Horizontal");
        direction = new Vector3(horizontal,0,0);
        directionForward=DirectionForward(direction.x);

        base.controlPersonaje();

        
        
        //En esta parte del codigo indica el cambio de dirección del personaje


        //Si el movimiento de get axis es mayor a 0 
        if(horizontal < 0)
        {
           spr.flipX = true;
        }
        
        //Si el movimiento de get axis es menor a 0 
        if(horizontal > 0)
        {
           spr.flipX = false;
        }
        
    }

}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos 
Descripción de los que hace el script: Registrar el movimiento, acciones y mecanicas del player
*/


public class BaseControl : MonoBehaviour
{

    /*Protected sirve para heredar y hace el poliformismo
    ya sea en 2D o 3D*/ 
    protected Vector3 direction=Vector3.zero;

    protected bool directionForward;


    //Almacenan datos de int para modificar las velocidades de acciones 
    [SerializeField]
    private float velocidadMovimiento;
    
    [SerializeField]
    private float velocidadSlide;

    [SerializeField]
    private float velocidadSalto;

    [SerializeField]
    protected SpriteRenderer spr;
    
    [SerializeField]
    protected Rigidbody salto;



    /*Guarda información del componente Animator para así mandar a
    llamar las animaciones almacenadas en ellas*/
    Animator animPlayer;

  

    /*Activa de manera más rapida las animaciones contenidas en
    Animator*/
    void Awake()
    {
        animPlayer=GetComponent<Animator>();
    }
       

    /*Se hereda de manera segura, protegido 
    y privado */
    protected  virtual void controlPersonaje()
    {
      //Acciones
    
     //direction*=Time.deltaTime*velocidadMovimiento;
     this.transform.Translate(direction.normalized*velocidadMovimiento*Time.deltaTime);    
    
     //animPlayer.SetFloat("Speed", direction.x);
     //animPlayer.SetFloat("Speed2", direction.x);
     animPlayer.SetBool("run",directionForward);

    }


    //Almacena informacion  salto
    protected void Salto()
    {
        //si presiona la tecla arriba
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            //detona la animacion saltar
            salto.AddForce(Vector2.up*velocidadSalto, ForceMode.Impulse);
            animPlayer.SetTrigger("jump");
        }
    }

    //Almacena informacion agachar
    protected void Agacharse()
    {
        //si presiona flecha abajo
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {  
            //detona la animacion agachar
            animPlayer.SetTrigger("agachar");
        }
    }
    
    //Almacena informacion deslisar
    protected void Deslisarse()
    {
        //si presiona barra espaciadora
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //this.transform.Translate(Vector2.left *velocidadSlide, ForceMode2D.Force);    
            //detona la animacion deslisar
            Input.GetKeyDown(KeyCode.Space);
            animPlayer.SetTrigger("slide");
        }
    }



    //Retorna la información de movimiento en formato variable 
    protected bool DirectionForward(float d)
    {
        bool directionForward = d != 0 ? true:false;
        return directionForward;
    }
    
  


}
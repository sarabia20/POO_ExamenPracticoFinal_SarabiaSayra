using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nombre del desarrollador: Sarabia Cruz Sayra Alondra
//Asignatura: Programacion Orientada a objetos
//Descripcion del usos de este codigo:
/*
Este script se utilizara para generar el segumiento de la camara del personaje
*/

public class CamaraFollow : MonoBehaviour
{
    
    public Transform target;//es una referencia al componente trasnform de un objeto
    public Vector3 puntoInicial;//es una variable donde se va almacenar la cámara
    
    
    void Update()
    {
        //es para delimitar hasta que punto puede extender el seguimineto de la cámara en su eje x y
        transform.position = new Vector3(Mathf.Clamp(target.position.x, -0.06f, 14f), Mathf.Clamp(target.position.y, 0.45f, 2f), transform.position.z);
        
    }
}

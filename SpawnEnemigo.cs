using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Sarabia Cruz Sayra Alondra
Asignatura: Programación Orientada a Objetos
Descripción de los que hace el script: Registrar información del daño a player. 
*/

/*
El siguiente coido lo extraje de uin tutorial del YouTube. el canal se llama JuaniDev
en el cual explica como hacer que un solo tipo de enemigo se spawme por todo el mapa en diferentes
partes del mapa. Lo replique para sacar a los tres diferentes enemigos
*/

public class SpawnEnemigo : MonoBehaviour
{
    //Transform alamcenara diferentes datos en la variable SpawnPoint
    public Transform[] SpawnPoint; 

    //Declare varaibles que alamcenarian a los 3 enemigos 
    [SerializeField]
    public GameObject enemigos;
    public GameObject enemigos1;
    public GameObject enemigos2;

    
    // Start is called before the first frame update
    void Start()
    {
        //Invocar y repetir el proceso de void spawmear en un rango de diferentes variables 
        InvokeRepeating("spawmear",1,8);
        InvokeRepeating("spawmear1",4,12);
        InvokeRepeating("spawmear2",7,20);
   
    }

    //Este void indica en los lugares que se spawmean al igual que la pocision y rotacion
    //lo repeti 3 veces para los 3 diferente enemigos
    //no supe amcodar los arrays aqui 
     void spawmear()
    {
        int i = (Random.Range(0,2));
        Instantiate(enemigos, SpawnPoint[i].position,transform.rotation);
    }
     void spawmear1()
    {
        int i = (Random.Range(0,2));
        Instantiate(enemigos1, SpawnPoint[i].position,transform.rotation);
    }
     void spawmear2()
    {
        int i = (Random.Range(0,2));
        Instantiate(enemigos2, SpawnPoint[i].position,transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class enemycontroller : MonoBehaviour{

    public float Speed = 3.14f;
    public float Fov = 10f;
    public int  Vida = 100;
    public int Dano = 5;
    public Transform PlayerPosition;

    private void Awake(){
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Start(){
        


    }

    
    public void Update(){
        if (Vector2.Distance(transform.position, PlayerPosition.position) <Fov){
            Vector2 direction = (PlayerPosition.position - transform.position).normalized;
            transform.position += (Vector3)direction * Speed * Time.deltaTime;


        }   
    }



}

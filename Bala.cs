using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Bala : MonoBehaviour {
     public PlayerController player;
     public GameObject balaSpawn;

     [SerializeField]
     private float velocidade;
     private Vector2 direcao;
     private float timeDestroy;



     private Rigidbody2D rb;
     // Use this for initialization
     void Start () {
        timeDestroy = 2.0f;

        Destroy(gameObject, timeDestroy);

     } 

     
    // Update is called once per frame
    void FixedUpdate () {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.right * velocidade * Time.deltaTime);


        
    }
}

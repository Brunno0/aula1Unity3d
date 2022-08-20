using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour{
    [SerializeField] // tornar publica var private
     private Vector3 offset; // 
    [Range (0,1)]
     public float suavidade = 0.2f; // forcar float
     public Transform personagem;


    // tem uma taxa de frames constante
    void FixedUpdate() {
       transform.position = Vector3.Lerp(trasnform.position, jogador.position+offset, suavidade);
        //transform
   }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
}

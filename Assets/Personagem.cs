using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    public float velocidade, impulso; // 

    private Rigidbody rb;
    private bool frente, direita, esquerda, tras, pular; // valores 

    // Start is called before the first frame update
    // void Start(){

    // }
    // essa função é chamada antes de todos os updates do game
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    void Update()
    {
        checarInputs();
    }
    // é chamada a uma taxa constante, menor que o update. 
    private void FixedUpdate()
    {
        movimentar();

    }

    void checarInputs()
    {

        if (Input.GetKey(KeyCode.W)) frente = true;
        if (Input.GetKey(KeyCode.D)) direita = true;
        if (Input.GetKey(KeyCode.A)) esquerda = true;
        if (Input.GetKey(KeyCode.S)) tras = true;
        if (Input.GetKey(KeyCode.Space)) pular = true;

    }

    void movimentar()
    {

        if (frente)
        {
            rb.AddForce(Vector3.forward * velocidade);
            frente = false;

        }

        if (direita)
        {
            rb.AddForce(Vector3.right * velocidade);
            direita = false;

        }
        if (esquerda)
        {
            rb.AddForce(Vector3.left * velocidade);
            esquerda = false;

        }
        if (tras)
        {
            rb.AddForce(Vector3.back * velocidade);
            tras = false;
        }
        if (pular)
        {
            rb.velocity = new Vector3(rb.velocity.x, impulso, rb.velocity.z);
            rb.AddForce(Vector3.up * velocidade);
            pular = false;
        }



    }


}

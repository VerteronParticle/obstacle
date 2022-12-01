using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    [SerializeField] public float m_Thrust = 50f;
    [SerializeField] float yValue = 0;    
    [SerializeField] float moveSpeed = 15f;
    
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        m_Rigidbody.AddForce(movement * m_Thrust);

    //     if (Input.GetAxis("Horizontal") == 1){
    //         m_Rigidbody.AddForce(m_Thrust, 0, 0);
    //     } else if (Input.GetAxis("Horizontal") == -1){
    //         m_Rigidbody.AddForce(-m_Thrust, 0, 0);
    //     } else if (Input.GetAxis("Vertical") == 1){
    //         m_Rigidbody.AddForce(0, 0, m_Thrust);
    //     } else if (Input.GetAxis("Vertical") == -1){
    //         m_Rigidbody.AddForce(0, 0, -m_Thrust);
    //     }
        
    }

    void Update()
    {
     //   MovePlayer();
    }


    void PrintInstruction() {
        Debug.Log("Welcome to the end of the world.");
        Debug.Log("I've been waiting for you.");
        Debug.Log("It's so nice to finally see you, after all these years.");
    }

    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,yValue,zValue);
    }
}

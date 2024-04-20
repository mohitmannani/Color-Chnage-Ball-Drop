using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    public Transform respawnPoint;
    
    public MeshRenderer meshRenderer;

    private randomcolor colorScript;

    private Rigidbody rb;
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        colorScript = GetComponent<randomcolor>();
        gameObject.SetActive(false);
    }

   

  
    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("drop"))
        {
            Debug.Log("Ball hit the drop object.");
            
            gameObject.transform.position = respawnPoint.position;
            colorScript.changecolor();
            gameObject.SetActive(false);
        }
    }
}
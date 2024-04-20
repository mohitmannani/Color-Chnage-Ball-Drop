using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 6.0F;
    public float minZ = -23f;
    public float maxZ = 2.7f;
    public float movementDistance = 5f;
    private float direction = 1f;
    public GameObject ballPrefab;

    void Start()
    {

    }

    void Update()
    {
    //    Debug.Log("Current Z position: " + transform.position.z);
        if (transform.position.z < minZ || transform.position.z > maxZ)
        {
            direction *= -1f;
        }
        transform.position += direction * speed * Time.deltaTime * Vector3.forward;

        
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ballPrefab.SetActive(true);
            }
        


    }
}
  




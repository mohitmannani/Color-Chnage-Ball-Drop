using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomcolor : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public GameObject scoreText;

    public int score;

    void Start()
    {
        changecolor();
    }

  public void changecolor()
    {
        meshRenderer.material.color = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("box"))
        {
            MeshRenderer myobject = other.gameObject.GetComponent<MeshRenderer>();
            if (myobject != null)
            {
                myobject.material.color = meshRenderer.material.color;

                score++;
                Debug.Log(score);
                scoreText.GetComponent<Text>().text = "Score : "+ score;
            }
        }
    }
}

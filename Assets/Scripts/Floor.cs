using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{

    public int score = 0;
    public bool gameRunning = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("FallBall"))
        {
            Destroy(collision.gameObject);
            score++;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            gameRunning = false;
        }
    }
}

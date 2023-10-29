using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody playerRigidBody;
    private GameObject focalPoint;
    private GameController gameController;

    public float speed = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.gameRunning)
        {
            float forwardInput = Input.GetAxis("Vertical");
            playerRigidBody.AddForce(forwardInput * speed * focalPoint.transform.forward * Time.deltaTime);
        }
    }
}

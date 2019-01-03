using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float playerSpeed;
    private Rigidbody2D playerRigidbody;

    private void Start()
    {
        playerRigidbody = gameObject.GetComponent<Rigidbody2D>(); 

    }


    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            playerRigidbody.velocity = playerSpeed * Vector2.up;



        }


    }


}

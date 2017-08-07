using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float fPlayerSpeed = 5F;
    [SerializeField]
    private float fPlayerJumpVelocity = 150F;

    private Vector3 v3Move;
    private Rigidbody rbPlayer;


    void Start () {
        rbPlayer = GetComponent<Rigidbody>();
    
    }
	
	void FixedUpdate () {
	    v3Move.x = Input.GetAxisRaw("Horizontal");
	    v3Move.y = 0;
	    v3Move.z = Input.GetAxisRaw("Vertical");
	    v3Move = transform.TransformDirection(v3Move);
	    v3Move.Normalize();

	    rbPlayer.velocity = new Vector3(v3Move.x * fPlayerSpeed, rbPlayer.velocity.y, v3Move.z * fPlayerSpeed);  
    }

    void Update()
    { 
        if (Input.GetButtonDown("Jump"))
        {
            rbPlayer.velocity += Vector3.up * Time.deltaTime * fPlayerJumpVelocity;
        }
        if (Input.GetButtonDown("Inventory"))
        {
        }
    }

}

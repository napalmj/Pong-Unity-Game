using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float speedBall = 8f;
    Rigidbody rigidbody;
    Vector3 velocityBall;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.down * speedBall; //initializes direction of ball
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.velocity = rigidbody.velocity.normalized * speedBall; //keeps ball at specific speed
        velocityBall = rigidbody.velocity;
    }
    //collision detection
    private void OnCollisionEnter(Collision collision)
    {
        rigidbody.velocity = Vector3.Reflect(velocityBall, collision.contacts[0].normal); //reflects off surface
    }
}

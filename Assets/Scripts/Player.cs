using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rigidbodyComponent;
    bool leftKeyDown;
    bool rightKeyDown;
    float xInput;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
/*        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftKeyDown = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightKeyDown = true;
        }*/
    }
    private void FixedUpdate()
    {
        rigidbodyComponent.MovePosition(new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 5)).x, -4.7f, 0));
/*        if (leftKeyDown)
        {
            rigidbodyComponent.AddForce(Vector3.left * 6, ForceMode.VelocityChange);
            leftKeyDown = false;
        }
        if (rightKeyDown)
        {
            rigidbodyComponent.AddForce(Vector3.right * 6, ForceMode.VelocityChange);
            rightKeyDown = false;
        }*/
    }
}

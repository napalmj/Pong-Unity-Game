using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : MonoBehaviour
{
    public Transform ballPosition;
    float opponentStep;
    float speed = 3.0f;
    const float ballY = 4.7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        opponentStep = speed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, ballPosition.position, opponentStep);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(ballPosition.position.x, ballY, 0.0f), opponentStep);
    }
}

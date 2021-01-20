using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WallBottom : MonoBehaviour
{
    public GameObject ball;
    public Text oppScore;
    int score = 0;
    int flag = 1;

    private void Start()
    {
        oppScore.text = "Opponent Score: " + score;
    }
    private void Update()
    {
        if(score >= 10)
        {
            SceneManager.LoadScene(0);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit Bot");
        score++;
        oppScore.text = "Opponent Score: " + score;
        ballReset();
    }
    
    void ballReset()
    {
        if(flag == score)
        {
            ball.transform.position = new Vector3(0, 0, 0);
            flag++;
        }
    }
}

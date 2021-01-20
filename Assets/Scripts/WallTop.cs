using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WallTop : MonoBehaviour
{
    public GameObject ball;
    public Text plaScore;
    int score = 0;
    int flag = 1;
    private void Start()
    {
        plaScore.text = "Player Score: " + score;
    }
    private void Update()
    {
        if (score >= 10)
        {
            SceneManager.LoadScene(0);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit Bot");
        score++;
        plaScore.text = "Player Score: " + score;
        ballReset();
    }

    void ballReset()
    {
        if (flag == score)
        {
            ball.transform.position = new Vector3(0, 0, 0);
            flag++;
        }
    }
}


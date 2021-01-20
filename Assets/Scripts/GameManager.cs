using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int spaceCount = 0;
    int playCount = 0;
    int oppScore = 0;
    int plaScore = 0;

    public Text opponentScoreText;
    public Text playerScoreText;
    public Text instructionText;

    public GameObject buttonPlay;
    public GameObject panelInstruction;

    public GameObject wallTop;
    public GameObject wallBot;
    public GameObject ballPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(ballPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        checkInput();
        //scoreSetter();
    }

    //checks for input to see instruction text
    void checkInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceCount++;
            panelInstruction.SetActive(true);
            Time.timeScale = 0;
            if (spaceCount >= 2)
            {
                panelInstruction.SetActive(false);
                spaceCount = 0;
                Time.timeScale = 1;
            }
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == wallTop)
        {
            Debug.Log("Top Wall Hit");
        }
        if (collision.gameObject == wallBot)
        {
            Debug.Log("Bot Wall Hit");
        }
    }

/*    void scoreSetter() //sets game score
    {
        opponentScoreText.text = "Opponent Score: " + oppScore;
        playerScoreText.text = "Player Score: " + plaScore;
    }*/
}

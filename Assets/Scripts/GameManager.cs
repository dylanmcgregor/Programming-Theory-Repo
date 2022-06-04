using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public Button startButton;
    public GameObject homeScreen;
    public GameObject[] balls;
    public float boundary = 10.0f;

    public bool isGameActive = false;
    public bool isGameOver = false;

    private float spawnTime = 0;
    private float timeDelay = 3;


    private int score;
    public int Score
    {
        get { return score; }
        set
        {
            if (value > 0)
            {
                score = value;
            }
        }
    }

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {

        if (isGameActive)
        {
            scoreText.text = "Score: " + score;
            if (Time.time > spawnTime)
            {
                SpawnBall();
                spawnTime = Time.time + timeDelay;
            }
        }

        if(isGameOver)
        {
            scoreText.text = "Game Over :(";
        }


    }

    void StartGame()
    {
        score = 0;
        isGameOver = false;
        homeScreen.SetActive(false);
        isGameActive = true;
    }

    public void GameOver()
    {
        isGameOver = true;
        isGameActive = false;
        homeScreen.SetActive(true);
    }

    void SpawnBall()
    {
        GameObject randomBall = balls[Random.Range(0, balls.Length)];
        Vector3 randomPosition = new Vector3(Random.Range(-boundary, boundary), 8, 0);
        Instantiate(randomBall, randomPosition, randomBall.transform.rotation);
    }
}

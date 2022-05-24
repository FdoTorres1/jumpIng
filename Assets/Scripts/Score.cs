using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text HIScoreText;
    int score;
    Text scoreText;
    float timer;
    float maxTime;
    AudioSource distanceSound;

    void Start()
    {
        HIScoreText.text = PlayerPrefs
            .GetInt("highscore", 0)
            .ToString("0000");
        score = 0;
        scoreText = GetComponent<Text>();
        maxTime = 0.1f;
        distanceSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            score++;
            scoreText.text = score.ToString("0000");
            timer = 0;

            if (score % 100 == 0)
            {
                distanceSound.Play();
                Time.timeScale += 0.1f;
            }
        }

        if (Time.timeScale == 0)
        {
            if (score > PlayerPrefs.GetInt("highscore", 0))
            {
                PlayerPrefs.SetInt("highscore", score);
                HIScoreText.text = PlayerPrefs
                    .GetInt("highscore", 0)
                    .ToString("0000");
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GOPanel;
    AudioSource loseSound;

    void Start()
    {
        Time.timeScale = 1;
        loseSound = GetComponent<AudioSource>();
    }

    public void GameOver()
    {
        loseSound.Play();
        Time.timeScale = 0;
        GOPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

}

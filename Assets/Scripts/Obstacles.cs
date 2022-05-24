using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    float maxTime;
    float timer;
    public GameObject meones_1;
    public GameObject luksic;
    int chooseObstacle;

    void Start()
    {
        maxTime = 1.5f;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            GenerateObstacle();
            timer = 0;
        }
    }

    void GenerateObstacle()
    {
        chooseObstacle = Random.Range(1, 3);
        if (chooseObstacle == 1)
        {
            GameObject newObstacle = Instantiate(meones_1);
        }
        else { GameObject newObstacle = Instantiate(luksic); }
    }
}

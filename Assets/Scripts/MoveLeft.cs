using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    public float end;
    public float start;
    public float horizontalChange;
    public float verticalChange;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalChange = transform.position.x - speed * Time.deltaTime;
        verticalChange = transform.position.y;
        transform.position = new Vector2(horizontalChange, verticalChange);
        if (transform.position.x <= end)
        {
            if (gameObject.tag == "obstacle")
            {
                Destroy(gameObject);
            }
            else
            {
                transform.position = new Vector2(start, transform.position.y);
            }
        }
    }
}

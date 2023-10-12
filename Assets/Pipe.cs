using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;
    public float startX;
    public float endX;
    // Update is called once per frame

    void Start()
    {
        startX = Camera.main.ViewportToWorldPoint(new Vector3(0, 0)).x - 1;    
        endX = Camera.main.ViewportToWorldPoint(new Vector3(1, 1)).x + 1;
    }
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < startX)
        {
            var height = Random.Range(-1f, 4f);
            transform.position = new Vector3(endX, height);
        }
    }

}

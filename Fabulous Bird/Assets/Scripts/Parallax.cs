using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public float speed;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x <= -8.3f)
        {
            transform.position = new Vector3(6.8f,transform.position.y, transform.position.z);
        }
    }
}

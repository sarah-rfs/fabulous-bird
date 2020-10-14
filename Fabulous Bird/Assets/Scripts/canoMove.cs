using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canoMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
 void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x <= -4.8f)
        {
            transform.position = new Vector3(4.6f,transform.position.y, transform.position.z);
        }
    }
}
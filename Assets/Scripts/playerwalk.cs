using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerwalk : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w")) // moves NE
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s")) //moves SW
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d")) //moves SE
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a")) //moves NW
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;

    }
}

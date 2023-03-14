using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveup : MonoBehaviour
{
    Rigidbody rb;
    float speed = 0;
    bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (move == true)
        {
            rb.AddForce(transform.up * speed);
        }
        
    }

    public void up()
    {
        move = true;
        speed = 10f;
    }
    public void down()
    {
        move = true;
        speed = -10f;
    }
}

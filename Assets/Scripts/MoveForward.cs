using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 300.0f;
    private Rigidbody rb;
    int range = 30;
    private Transform direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.Find("Direction").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.AddForce(direction.position* speed * Time.deltaTime, ForceMode.Impulse);
       
        OutofRange();
    }

    private void OutofRange()
    {
        if (transform.position.x>range||transform.position.x<-range)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > range || transform.position.z < -range)
        {
            Destroy(gameObject);
        }
    }
}

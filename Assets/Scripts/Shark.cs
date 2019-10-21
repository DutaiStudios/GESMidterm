using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{

    public float thrust;
    public Rigidbody rb;
    public Transform target;
    bool hasTarget = false;


    public int random;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(target);
        rb.AddForce(transform.forward * thrust);
    }

  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    private float speed = .02f;
    public GameObject shark;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed);
    }

    private void OnCollisionExit(Collision collision)
    {
        Instantiate(shark, spawn);
    }
}

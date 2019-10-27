using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raft : MonoBehaviour
{

    bool destroyed = false;
    float speed = .02f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyed == true)
        {
            transform.Translate(Vector3.down * speed);
        }
        if (transform.position.y <= -50)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "shark")
        {
            destroyed = true;
            Destroy(collision.gameObject);
        }
    }
}

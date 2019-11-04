using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterUpDown : MonoBehaviour
{

    public GameObject shark;
    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollision(Collider other)
    {
        Instantiate(shark, spawn);
    }

}

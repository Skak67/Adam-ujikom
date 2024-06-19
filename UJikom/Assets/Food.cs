using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float life = 10;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, life);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision) 
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}

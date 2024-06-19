using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float life = 3;
    // Start is called before the first frame update
    void Awake()
    {
        Destroy(gameObject, life);
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision) 
    {
        // if (collision.collider.CompareTag("Animal")){
        //     Destroy(collision.gameobject);
        // }
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
    // private void OnTriggerEnter(Collider other) {
    //     if(other.compare)
    // }
}

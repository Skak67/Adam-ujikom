using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    public Transform BantengSpawner;
    public GameObject BantengPrefab;
    public float BantengSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
        void OnCollisionEnter(Collision collision) 
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
    
}

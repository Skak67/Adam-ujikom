using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public Transform foodSpawnerPoint;
    public GameObject FoodPrefab;
    public float FoodSpeed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            var food = Instantiate(FoodPrefab, foodSpawnerPoint.position, foodSpawnerPoint.rotation);
            food.GetComponent<Rigidbody>().velocity = foodSpawnerPoint.forward * FoodSpeed;
        }
    }
}

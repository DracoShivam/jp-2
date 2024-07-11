using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    public float upperBound = 33.6f;
    public float lowerBound = -14.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!!");
        }
    }
}

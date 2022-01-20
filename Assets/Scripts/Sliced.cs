using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliced : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // transform.Rotate(0, -90, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -6.0f){
            Destroy(gameObject);
        }
    }
}

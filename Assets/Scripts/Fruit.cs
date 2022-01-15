using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject Sliced;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Knife"){
            Destroy(gameObject);
            GameObject appleLeft = Instantiate(Sliced, transform.position + new Vector3 (-0.2f, 0, 0), Quaternion.identity);
            appleLeft.transform.Rotate(0, -70, 0);
            GameObject appleRight = Instantiate(Sliced, transform.position + new Vector3 (0.2f, 0, 0), Quaternion.identity);
            appleRight.transform.Rotate(0, 70, 0);
        }
    }
}

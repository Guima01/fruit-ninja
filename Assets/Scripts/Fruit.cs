using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject Sliced;
    public float jumpHeight = 5.0f;
    public bool applyForce = true;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        var rand = new System.Random();
        num = rand.Next(-7, 7);
        transform.position = new Vector3(num,-6.0f,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0.2f && applyForce){
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, jumpHeight), ForceMode2D.Force); 
        }
        else {
            applyForce = false;
        }
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

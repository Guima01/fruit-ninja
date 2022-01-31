using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject Sliced;
    public float jumpHeight = 5.0f;
    public bool applyForce = true;
    public float thrust = 500.0f;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        var rand = new System.Random();
        num = rand.Next(-7, 7);
        transform.position = new Vector3(num, -6.0f,0);
    }

    // Update is called once per frame
    void Update()
    {
        float degrees = 50;
        Vector3 to = new Vector3(degrees,degrees,degrees);
        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
        if (transform.position.y < 0.2f && applyForce){
            GetComponent<Rigidbody2D>().AddForce(Time.timeScale * thrust  * transform.up * 0.1f); 
        }
        else if(applyForce == true){
            applyForce = false;
        }
        if(applyForce == false && transform.position.y < -6.0f){
            Destroy(gameObject);
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

     void Awake () {
        QualitySettings.vSyncCount = 0;  // VSync must be disabled
        Application.targetFrameRate = 60;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
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
        else if(applyForce == true){
            applyForce = false;
        }
        if(applyForce == false && transform.position.y < -6.0f){
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Knife"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public GameObject [] prefabs;
    private float timer = 0.0f;
    int num;
    int x;
    System.Random rand;
    // Start is called before the first frame update
    void Start()
    {
        rand = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        num = rand.Next(0, 4);
        x = rand.Next(-7,7);
        if(recalculateValue()){
            Instantiate(prefabs[num], new Vector3(x,-6.0f,0), Quaternion.identity);
        }

    }

    public bool recalculateValue()
    {
        timer += Time.deltaTime;
        if(timer > 1.5f){
            timer = 0;
            return true;
        }
        return false;
    }
}

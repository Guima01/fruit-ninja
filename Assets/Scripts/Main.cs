using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public GameObject [] prefabs;
    private float timer = 0.0f;
    int num;
    int x;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var rand = new System.Random();
        num = rand.Next(0, 3);
        x = rand.Next(-7,7);
        if(recalculateValue()){
            Debug.Log(num);
            Instantiate(prefabs[num], new Vector3(x,-6.0f,0), Quaternion.identity);
        }

    }

    public bool recalculateValue()
    {
        timer += Time.deltaTime;
        if(timer > 2.0f){
            timer = 0;
            return true;
        }
        return false;
    }
}

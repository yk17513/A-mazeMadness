using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class React : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int life = 0;

    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.tag == "Bullet")
        {
            if (life < 10)
                life++;
            else gameObject.transform.localScale = new Vector3(0, 0, 0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        /*
        int step = 0;
        if (step == 0)
            step = 1;
        else step = 0;
        gameObject.transform.position = new Vector3(0, 0, step);*/
    }
}

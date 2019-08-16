using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class React : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController villan;
    public float accelerationTime = 2f;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float timeLeft;

    int life = 0;


    void Start()
    {
        villan = GetComponent<CharacterController>();
    }

    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.tag == "Bullet")
        {
            if (life < 10)
                life++;
            else gameObject.SetActive(false);
        }
    }
  
    // Update is called once per frame


    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
        {
            movement = new Vector3(Random.Range(-1f, 1f),0f, Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }
        villan.Move(movement);

    }

}

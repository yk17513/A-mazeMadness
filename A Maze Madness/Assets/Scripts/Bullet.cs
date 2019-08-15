using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet: MonoBehaviour
{
    public float time = 0.02f;
    public Vector3 direction;
    public float speed = 100;

    private ConstantForce force;

    // Start is called before the first frame update
    void Start()
    {
        force = GetComponent<ConstantForce>();
    }

    // Update is called once per frame
    void Update()
    {
        force.force = direction * speed;

        if (time > 0)
            time -= Time.deltaTime;
        else Destroy(gameObject);
    }
}

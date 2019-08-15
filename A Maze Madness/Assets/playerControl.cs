using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    CharacterController character;
    public Bullet B;
    public float speed = 1;

    void Shooting(Vector2 Direction)
    {
        Bullet B1 = Instantiate(B, transform);
        B1.transform.parent = null;
        B1.direction = Direction;
        B1.transform.position = transform.position;
    }



    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float movespeed = speed * Time.deltaTime * 10;
        character.Move(new Vector3(movespeed * Input.GetAxis("Horizontal"), 0, movespeed * Input.GetAxis("Vertical")));
        if (Input.GetKeyDown(KeyCode.S))
            Shooting(Vector2.down);
        if (Input.GetKeyDown(KeyCode.W))
            Shooting(Vector2.up);
        if (Input.GetKeyDown(KeyCode.D))
            Shooting(Vector2.right);
        if (Input.GetKeyDown(KeyCode.A))
            Shooting(Vector2.left);

    }
}

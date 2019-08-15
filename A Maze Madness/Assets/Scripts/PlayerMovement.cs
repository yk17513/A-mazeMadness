using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController character;

    public float speed = 1;


    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float movespeed = speed * Time.deltaTime * 5;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            character.Move(new Vector3(movespeed, 0, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            character.Move(new Vector3(-movespeed, 0, 0));
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            character.Move(new Vector3(0, movespeed, 0));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            character.Move(new Vector3(0, -movespeed, 0));
        }


    }
}

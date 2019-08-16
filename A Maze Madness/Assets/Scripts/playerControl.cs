using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerControl : MonoBehaviour
{
    CharacterController character;
    public Bullet B;
    public float speed = 1;

    private bool died = false;

    void Shooting(Vector3 Direction)
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
        if (died) return;
        float movespeed = speed * Time.deltaTime * 10;
        if (Input.GetAxis("Horizontal") == -1)
              gameObject.transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
        else gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        character.Move(new Vector3(movespeed * Input.GetAxis("Horizontal"), 0, movespeed * Input.GetAxis("Vertical")));



        if (Input.GetKeyDown(KeyCode.S))
            Shooting(Vector3.back);
        if (Input.GetKeyDown(KeyCode.W))
            Shooting(Vector3.forward);
        if (Input.GetKeyDown(KeyCode.D))
            Shooting(Vector3.right);
        if (Input.GetKeyDown(KeyCode.A))
            Shooting(Vector3.left);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Kill")
        {
            Debug.Log("test");
            died = true;
            SceneManager.LoadScene("LoadScene_Death");

        }

    }


}

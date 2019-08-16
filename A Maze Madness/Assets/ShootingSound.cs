using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSound : MonoBehaviour
{
    public AudioClip shootingclip;

    AudioSource shootingSource;

    // Start is called before the first frame update
    void Start()
    {
        shootingSource = gameObject.AddComponent<AudioSource>();

    }
    // This function plays shooting sound. 
    public void PlayShootingSound()
    {
        shootingSource.PlayOneShot(shootingclip);

            }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlayShootingSound();
        }
    }

}

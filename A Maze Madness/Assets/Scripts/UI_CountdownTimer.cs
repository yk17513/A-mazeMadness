using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//codeline 4 required for using the UI

public class UI_CountdownTimer : MonoBehaviour
{
    //These private variables have to be visisble in the inspector, which we can then use. the float doesn't have to be public.
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    //Create three variables by themselves. these control whether the timer continues or restarts later.
    private float timer;
    private bool canCount = true;
    private bool doOnce = false;

    //What we need, is that the timer has no value in the beginning, but the inspector helps us set one. so we need to specify here that we want to set a standard time in the inspector
    private void Start()
    {
        timer = mainTimer;
    }

    private void Update()
    {
        //if the timer is below a certain value, we want to countdown. moreover, the timer is a float value, but the text element is a streng. so we are converting the timer which is a float, to a string
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("f");
        }

        //when the timer is zero, which is at the start, when it is zero and is false at the start, then we are not counting down anymore. and then sets the timer to zero. these booleans control that we just do this once, even in an update function
        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Restart_OtherGroup : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Exit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Unity 1");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    public GameObject next;
    bool active;
    private void Start()
    {
        // MusicManager.Instance.PlayMusic(GameResources.Instance.mainMenuMusic, 0f, 2f);

    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("TamanRuh");
    }

    public void OpenAndClose()
    {
        if (active == false)
        {
            next.SetActive(true);
            active = true;
        }
        else
        {
            next.SetActive(false);
            active = false;
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}

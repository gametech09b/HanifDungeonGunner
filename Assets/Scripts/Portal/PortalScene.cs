using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PortalScene : MonoBehaviour
{
    public bool isTrigger;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && isTrigger)
        {
            Debug.Log("Done");

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTrigger = true;
            SceneManager.LoadScene("MainGameScene");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTrigger = false;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnter : MonoBehaviour
{
    public int sceneToLoad;
    public bool playerIn = false;
    private void Update()
    {
        if (playerIn)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.LogError("dgdsfagadsf");
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            playerIn = true;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            playerIn = false;
        }
    }
}


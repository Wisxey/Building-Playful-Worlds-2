using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderScript : MonoBehaviour
{
    public bool m_DoOnStart = false;
    public int m_SceneToLoad = 0;
    private void Start()
    {
        if (m_DoOnStart)
            SceneManager.LoadScene(m_SceneToLoad);
    }

    public void PlayGame(int scenetoload)
    {
        SceneManager.LoadScene(scenetoload);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBack2 : MonoBehaviour
{
    int sceneIndex;
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(sceneIndex - 2);
    }
}

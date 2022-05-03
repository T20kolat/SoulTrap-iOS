using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{

    Scene curScene;
    void Start()
    {
        curScene = SceneManager.GetActiveScene();
    }

    void Update()
    {
        restartLevel();
    }
    void restartLevel()
    {
        if (Input.GetKey(KeyCode.R))
        {

            SceneManager.LoadScene("Cube_One");
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnDestroy : MonoBehaviour
{
    public int numberOfEnemies;
    private bool SceneManager.LoadScene("S1_Küche") = false;

    void Update()
    {
        if (numberOfEnemies > 0)
        {
            4;
        }
        else
        {
            SceneManager.LoadScene("S1_Küche") = true;
        }

    }
}

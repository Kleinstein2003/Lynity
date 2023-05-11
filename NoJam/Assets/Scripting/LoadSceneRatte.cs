using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneRatte : MonoBehaviour
{
    public int objectsToDestroy = 1; // Number of objects that need to be destroyed before loading new scene
    public int objectsDestroyed = 0;
    /*public GameObject Ratte0;
    public GameObject Ratte1;
    public GameObject Ratte2;
    public GameObject Ratte3;*/



    // Update is called once per frame
    void Update()
    {
        if (objectsDestroyed == objectsToDestroy)
        {
            // Load new scene
            SceneManager.LoadScene("S1_Küche");
        }

       /*if (Ratte0 == null)  //rattedead existiert nicht mehr
        {
            objectsDestroyed++;
        }

       if (Ratte1 == null)
        {
            objectsDestroyed++;
        }

        if (Ratte2 == null)
        {
            objectsDestroyed++;
        }

        if (Ratte3 == null)
        {
            objectsDestroyed++;
        }*/
    }
}

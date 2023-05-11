using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3_Smash : MonoBehaviour
{
    public GameObject RatteDead;
    public int objectsToDestroy = 4; // Number of objects that need to be destroyed before loading new scene
    private int objectsDestroyed = 0;

    void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(RatteDead, transform.position, Quaternion.identity);
    }

    void Start()
    {
        // Initialize objectsDestroyed to 0
        objectsDestroyed = 0;
    }

    void Update()
    {
        // Check if the number of objects destroyed is equal to the objectsToDestroy variable
        if (objectsDestroyed == objectsToDestroy)
        {
            // Load new scene
            SceneManager.LoadScene("S1_Küche");
        }
    }

    // Called when a game object is destroyed
    void OnDestroy()
    {
        // Increment the number of objects destroyed
        objectsDestroyed++;
    }
}

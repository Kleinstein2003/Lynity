using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3_Smash : MonoBehaviour
{
    public GameObject RatteDead;

    void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(RatteDead, transform.position, Quaternion.identity); 
    }

}

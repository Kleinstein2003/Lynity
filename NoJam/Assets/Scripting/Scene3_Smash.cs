using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3_Smash : MonoBehaviour
{
    public GameObject Franzose2;

    void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(Franzose2, transform.position, Quaternion.identity);
    }
}

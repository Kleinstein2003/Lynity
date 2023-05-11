using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3_3Hund : MonoBehaviour
{
    public GameObject HundTod;

    void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(HundTod, transform.position, Quaternion.identity);
    }
}

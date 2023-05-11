using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3_1smash : MonoBehaviour
{
    public GameObject SpiegelDead;

    void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(SpiegelDead, transform.position, Quaternion.identity);
    }
}

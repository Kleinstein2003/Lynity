using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene3_2Franz : MonoBehaviour
{
    public GameObject FranzoseDeadFinal;

    void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(FranzoseDeadFinal, transform.position, Quaternion.identity);
    }
}

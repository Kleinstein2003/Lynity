using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene3_4Huhn : MonoBehaviour
{
    public GameObject HuhnTod;

    void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(HuhnTod, transform.position, Quaternion.identity);
    }
}

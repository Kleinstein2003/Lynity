using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene3_5Kiefer : MonoBehaviour
{
    public GameObject KieferKaputt;

    void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(KieferKaputt, transform.position, Quaternion.identity);
    }
}

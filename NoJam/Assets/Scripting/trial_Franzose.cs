using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class trial_Franzose : MonoBehaviour
{
    void Update()
    {
        if(transform.childCount<1)
        {
            SceneManager.LoadScene("S1.2_Frenchtoast");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMesser2 : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

            source.PlayOneShot(clip);



        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3_1smash : MonoBehaviour
{
    public GameObject SpiegelDead;
    public AudioSource audioSource;
    public AudioClip AudioClip;

    void OnMouseDown()
    {
        audioSource.PlayOneShot(AudioClip);
        Destroy(gameObject);
        Instantiate(SpiegelDead, transform.position, Quaternion.identity);
    }
}

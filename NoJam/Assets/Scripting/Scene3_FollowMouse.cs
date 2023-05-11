using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3_FollowMouse : MonoBehaviour
{
   
    void Awake()
    {
        Cursor.visible = true;
    }


    void Update()
    {
        Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mouseCursorPos;
    }
}

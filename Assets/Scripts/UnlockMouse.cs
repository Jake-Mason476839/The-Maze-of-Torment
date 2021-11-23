using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockMouse : MonoBehaviour
{
    void Start()
    {
       Cursor.lockState = CursorLockMode.None;
       Cursor.visible = true;
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {   
            Application.Quit();
        }
    }
    
}

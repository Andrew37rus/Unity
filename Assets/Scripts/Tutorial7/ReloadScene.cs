using UnityEngine;
using System.Collections;

public class ReloadScene : MonoBehaviour
{
    public int Scene = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel(Scene);
        }
    }
}
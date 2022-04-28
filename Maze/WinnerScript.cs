using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerScript : MonoBehaviour
{
    void OnCollisionEnter (Collision collision)
    {
        {
            SceneManager.LoadScene(1);
        }
    }
}

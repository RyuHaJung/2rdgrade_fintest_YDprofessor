using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tostart : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("01.StartScene");
    }
}


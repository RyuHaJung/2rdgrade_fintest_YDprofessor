using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGame : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("Text_001_Scene");
    }
}

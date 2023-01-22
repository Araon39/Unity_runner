using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reloder : MonoBehaviour
{
    public void Reload()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}

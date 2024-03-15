using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void OnLevel1Click()
    {
        SceneManager.LoadScene("Level 1 Scene");
    }
}

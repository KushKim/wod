using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Stage2Button : MonoBehaviour
{
    public void startButtonClick()
    {
        SceneManager.LoadScene(2);
    }
}

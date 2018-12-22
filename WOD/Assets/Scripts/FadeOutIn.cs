using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOutIn : MonoBehaviour
{

    [SerializeField]
    Image fadeImage;

    [SerializeField]
    string sceneName;

    bool isPlaying = false;

    float time = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    IEnumerator PlayFadeAnim()
    {
        isPlaying = true;

        Color color = fadeImage.color;
        while(color.a < 1f)
        {
            time += Time.deltaTime / 3;

            color.a = Mathf.Lerp(0f, 1f, time);

            fadeImage.color = color;
            yield return null;
        }
        SceneManager.LoadScene(sceneName);
        isPlaying = false;
    }

    public void StartFadeAnim()
    {
        if (isPlaying)
            return;
        fadeImage.gameObject.SetActive(true);
        StartCoroutine("PlayFadeAnim");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowChoice : MonoBehaviour
{

    [SerializeField]
    GameObject ChoiceImage;

    public void Show()
    {
        ChoiceImage.SetActive(true);
    }

    public void DisShow()
    {
        ChoiceImage.SetActive(false);
    }
}

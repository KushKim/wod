using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnowlegeUp : MonoBehaviour
{
    public CharacteristicStatus orgMe;
    public int literatureBox = 0;
    public int mathematicBox = 0;

    public void knowlegeLiteraturUp(int literUp)
    {
        literatureBox = literatureBox + literUp;
    }

    public void knowlegeMathUp(int MathUp)
    {
        mathematicBox = mathematicBox + MathUp;
    }
}

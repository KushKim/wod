using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    public CharacteristicStatus orgMe;
    public int healthBox = 100;

    public void healthUpClick(int healthUp)
    {
        healthBox = healthBox + healthUp;
    }
    
}

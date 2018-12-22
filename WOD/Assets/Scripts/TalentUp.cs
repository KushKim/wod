using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalentUp : MonoBehaviour
{
    public CharacteristicStatus orgMe;
    public int artBox = 0;
    public int musicBox = 0;

    public void talentArtUp(int artUp)
    {
        artBox = artBox + artUp;
    }

    public void talentMusicUp(int musicUp)
    {
        musicBox = musicBox + musicUp;
    }
}

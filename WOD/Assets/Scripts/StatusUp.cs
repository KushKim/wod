using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusUp : MonoBehaviour
{
    public CharacteristicStatus orgMe;
    public int healthBox = 100;
    public int artBox = 0;
    public int musicBox = 0;
    public int literatureBox = 0;
    public int mathematicBox = 0;

    private void Start()
    {
        healthBox = PlayerManager.getInstance().Health;
        artBox = PlayerManager.getInstance().Art;
        musicBox = PlayerManager.getInstance().Music;
        literatureBox = PlayerManager.getInstance().Literature;
        mathematicBox = PlayerManager.getInstance().Mathematic;
    }

    
    
    public void talentArtUp(int artUp)
    {
        artBox = artBox + artUp;
        chanceMinus();
    }

    public void talentMusicUp(int musicUp)
    {
        musicBox = musicBox + musicUp;
        chanceMinus();
    }

    public void knowlegeLiteraturUp(int literUp)
    {
        literatureBox = literatureBox + literUp;
        chanceMinus();
    }

    public void knowlegeMathUp(int MathUp)
    {
        mathematicBox = mathematicBox + MathUp;
        chanceMinus();
    }

    public void healthUpClick(int healthUp)
    {
        healthBox = healthBox + healthUp;
        chanceMinus();

        PlayerManager.getInstance().Health = healthBox;
        Debug.Log(healthBox);
    }

    public void Move()
    {
        PlayerManager.getInstance().Animator = 1;
    }
    
    void chanceMinus()
    {
        PlayerManager.getInstance().ChoiceChance = PlayerManager.getInstance().ChoiceChance - 1;
    }
}

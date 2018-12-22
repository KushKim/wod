using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacteristicStatus : MonoBehaviour
{

    /*public enum knowledgeKind
    {
        literature,
        mathematic
    }

    public enum talentKind
    {
        art,
        music,
        exercise
    }*/

    public StatusUp orgMeHealth;
    public StatusUp orgMeTalentArt;
    public StatusUp orgMeTalentMusic;
    public StatusUp orgMeKnowlegeLiter;
    public StatusUp orgMeKnowlegeMath;

    public int health;
    public int literature;
    public int mathematic;
    public int art;
    public int music;
    public int exercise;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        health = 100;
        literature = 0;
        mathematic = 0;
        art = 0;
        music = 0;
        Debug.Log(health);
    }

    void Update()
    {
        statusUpdate();
    }

    void statusUpdate()
    {
        health = orgMeHealth.healthBox;
        literature = orgMeKnowlegeLiter.literatureBox;
        mathematic = orgMeKnowlegeMath.mathematicBox;
        art = orgMeTalentArt.artBox;
        music = orgMeTalentMusic.musicBox;
    }

}

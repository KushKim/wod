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

    public HealthUp orgMeHealth;
    public TalentUp orgMeTalentArt;
    public TalentUp orgMeTalentMusic;
    public KnowlegeUp orgMeKnowlegeLiter;
    public KnowlegeUp orgMeKnowlegeMath;

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
        exercise = 0;
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

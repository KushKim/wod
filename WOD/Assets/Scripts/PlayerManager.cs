using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Section
{
    naturalSciences,
    liberalArts
};

public class PlayerManager
{
    int talent;
    int health;
    int[] knowledge;
    [SerializeField]
    Sprite image;

    private static PlayerManager instance = null;
    private PlayerManager()
    {
        talent = 0;
        health = 0;
        knowledge = new int[2];
        knowledge[(int)Section.naturalSciences] = 0;
        knowledge[(int)Section.liberalArts] = 0;
    }

    public static PlayerManager getInstance()
    {
        if (instance == null)
            instance = new PlayerManager();
        return instance;
    }

    public int Talent
    {
        get { return talent; }
        set { talent = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public void setKnowledge(int index,int val)
    {
        knowledge[index] = val;
    }

    public int getKnowledge(int index)
    {
        return knowledge[index];
    }
}

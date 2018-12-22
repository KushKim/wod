using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Section
{
    naturalSciences,
    liberalArts,
    music,
    art
};


public class PlayerManager
{
    int[] talent;
    int health;
    int[] knowledge;

    private static PlayerManager instance = null;
    private PlayerManager()
    {
        health = 0;   
        knowledge = new int[2];
        knowledge[(int)Section.naturalSciences] = 0;
        knowledge[(int)Section.liberalArts] = 0;
        talent = new int[2];
        talent[(int)Section.art] = 0;
        talent[(int)Section.music] = 0;
    }

    public static PlayerManager getInstance()
    {
        if (instance == null)
            instance = new PlayerManager();
        return instance;
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

    public int getTalent(int index)
    {
        return talent[index];
    }

    public void setTalent(int index, int val)
    {
        talent[index] = val;
    }
}

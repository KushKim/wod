using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager
{
    int health;
    int literature;
    int mathematic;
    int art;
    int music;
    int animator;
    int chance;

    private static PlayerManager instance = null;

    private PlayerManager()
    {
        health = 100;
        literature = 0;
        mathematic = 0;
        art = 0;
        music = 0;
        animator = 0;
        chance = 2;
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

    public int Literature
    {
        get { return literature; }
        set { literature = value; }
    }

    public int Mathematic
    {
        get { return mathematic; }
        set { mathematic = value; }
    }

    public int Art
    {
        get { return art; }
        set { art = value; }
    }

    public int Music
    {
        get { return music; }
        set { music = value; }
    }

    public int Animator
    {
        get { return animator; }
        set { animator = value; }
    }

    public int ChoiceChance
    {
        get { return chance; }
        set { chance = value; }
    }
}
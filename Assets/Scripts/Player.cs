using UnityEngine;
using System;

[System.Serializable]

public class Player

{
    private int _paints;
    private float _health;
    private Vector3 _pos;
    private int _level;

    public Player()
    {

    }

    public Player(int paints, float health, Vector3 pos,int level)
    {
        _paints = paints;
        _health = health;
        _pos = pos;
        _level = level;
    }

    public int Paints
    {
        get
        {
            return _paints;
        }
        set
        {
            _paints = value;
        }
    }

    public int Level
    {
        get
        {
            return _level;
        }
        set
        {
            _level = value;
        }
    }

    public float Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }

    public Vector3 Pos
    {
        get
        {
            return _pos;
        }
        set
        {
            _pos = value;
        }
    }

}
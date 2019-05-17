using UnityEngine;
using System;

[System.Serializable]

public class Player

{
    private int _paints;
    private int _health;
    private float _xPos;
    private float _yPos;

    public Player()
    {

    }

    public Player(int paints, int health, float xPos, float yPos)
    {
        _paints = paints;
        _health = health;
        _xPos = xPos;
        _yPos = yPos;
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

    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _paints = value;
        }
    }

    public float XPos
    {
        get
        {
            return _xPos;
        }
        set
        {
            _xPos = value;
        }
    }

    public float YPos
    {
        get
        {
            return _yPos;
        }
        set
        {
            _yPos = value;
        }
    }
}
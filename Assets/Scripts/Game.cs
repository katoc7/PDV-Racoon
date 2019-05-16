using System.Collections;
using UnityEngine;
[System.Serializable]

public class Game
{
    public static Game current;
    public Character racoon;

    public Game()
    {
        racoon = new Character();
    }
}

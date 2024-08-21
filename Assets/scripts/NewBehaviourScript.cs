using UnityEngine;


public class NewBehaviourScript : ScriptableObject
{
    public Vector2 cextor;
    public Levels level;
}


public enum Levels {
    LevelOne = 0,
    LevelTwo = 1,
    LevelThree = 2
}
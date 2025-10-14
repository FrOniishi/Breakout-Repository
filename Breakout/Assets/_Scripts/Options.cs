using UnityEngine;

[CreateAssetMenu(fileName = "Options", menuName = "ScriptableObjects/Options", order = 1)]

public class Options : PersistentScore
{
    public float ballVelocity = 20f;
    public difficulty LevelDifficulty = difficulty.easy;

    public enum difficulty
    {
        easy,
        medium,
        hard
    }
    
    public void SetVelocity(float newVelocity)
    {
        ballVelocity = newVelocity;
    }

    public void SetDifficulty(int newDifficulty)
    {
        LevelDifficulty = (difficulty)newDifficulty;
    }
}

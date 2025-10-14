using UnityEngine;
using static Options;

[CreateAssetMenu(fileName = "Options", menuName = "ScriptableObjects/Options", order = 1)]

public class Options : PersistentScore
{
    public float ballVelocity = 1f;
    public difficulty LevelDifficulty;

    [Header("Velocidades base por dificultad")]
    public float ballVelocityEasy = 2f;
    public float ballVelocityMedium = 5f;
    public float ballVelocityHard = 10f;
    
    [Header("Resistencia de los diferentes bloques")]
    public int blockResistanceEasy = 1;
    public int blockResistanceMedium = 2;
    public int blockResistanceHard = 3;
    public int woodResistanceEasy = 2;
    public int woodResistanceMedium = 3;
    public int woodResistanceHard = 4;
    public int stoneResistanceEasy = 3;
    public int stoneResistanceMedium = 4;
    public int stoneResistanceHard = 5;

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

    public float GetFinalVelocity()
    {
        float baseVelocity = LevelDifficulty switch
        {
            difficulty.easy => ballVelocityEasy,
            difficulty.medium => ballVelocityMedium,
            difficulty.hard => ballVelocityHard,
            _ => ballVelocityMedium
        };

        return baseVelocity * ballVelocity;
    }

    public void SetDifficulty(int newDifficulty)
    {
        LevelDifficulty = (difficulty)newDifficulty;
    }

    public int GetBlockResistance()
    {
        return LevelDifficulty switch
        {
            difficulty.easy => blockResistanceEasy,
            difficulty.medium => blockResistanceMedium,
            difficulty.hard => blockResistanceHard,
            _ => blockResistanceMedium
        };
    }

    public int GetWoodResistance()
    {
        return LevelDifficulty switch
        {
            difficulty.easy => woodResistanceEasy,
            difficulty.medium => woodResistanceMedium,
            difficulty.hard => woodResistanceHard,
            _ => woodResistanceMedium
        };
    }

    public int GetStoneResistance()
    {
        return LevelDifficulty switch
        {
            difficulty.easy => stoneResistanceEasy,
            difficulty.medium => stoneResistanceMedium,
            difficulty.hard => stoneResistanceHard,
            _ => stoneResistanceMedium
        };
    }

}

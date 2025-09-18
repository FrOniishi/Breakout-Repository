using UnityEngine;

public class Wood_Block : Blocks
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistance = 3;
    }

    public override void BounceBall()
    {
        base.BounceBall();
    }
}

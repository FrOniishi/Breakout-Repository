using UnityEngine;

public class Glass_Block : Blocks
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistance = 1;
    }

    public override void BounceBall()
    {
        base.BounceBall();
    }
}

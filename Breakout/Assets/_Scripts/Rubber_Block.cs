using UnityEngine;

public class Rubber_Block : Blocks
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistance = 4;
    }

    public override void BounceBall()
    {
       base.BounceBall();
    }
}

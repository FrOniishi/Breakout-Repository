using UnityEngine;

public class Stone_Block : Blocks
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistance = 5;
    }

    public override void BounceBall(Collision collision)
    {
        base.BounceBall(collision);
    }   
}

using UnityEngine;

public class Stone_Block : Blocks
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistance = options.GetStoneResistance();
    }

    void Update()
    {
        if (resistance <= 0)
        {
            ScoreUp.Invoke();
            Destroy(this.gameObject);
        }
    }

    public override void BounceBall(Collision collision)
    {
        base.BounceBall(collision);
    }   
}

using UnityEngine;

public class Blocks : MonoBehaviour
{
    public int resistance = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resistance <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public virtual void BounceBall()
    {

    }
}

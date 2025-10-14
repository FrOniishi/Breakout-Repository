using System;
using UnityEngine;
using UnityEngine.Events;

public class Blocks : MonoBehaviour
{
    public int resistance;
    public Options options;

    public UnityEvent ScoreUp;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            BounceBall(collision);
        }
    }

    public virtual void BounceBall(Collision collision)
    {
        Vector3 direction = collision.contacts[0].point - transform.position;
        direction = direction.normalized;
        collision.rigidbody.linearVelocity = collision.gameObject.GetComponent<Ball>().options.GetFinalVelocity() * direction;
        resistance--;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistance = options.GetBlockResistance();
    }

    // Update is called once per frame
    void Update()
    {
        if (resistance <= 0)
        {
            ScoreUp.Invoke();
            Destroy(this.gameObject);
        }
    }

    public virtual void BounceBall()
    {

    }
}

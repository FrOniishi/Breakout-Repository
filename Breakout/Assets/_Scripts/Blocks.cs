using System;
using UnityEngine;
using UnityEngine.Events;

public class Blocks : MonoBehaviour
{
    public int resistance = 1;

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
        collision.rigidbody.linearVelocity = collision.gameObject.GetComponent<Ball>().launchForce * direction;
        resistance--;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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

using UnityEngine;

public class Ball : MonoBehaviour
{
    bool isLaunched = false;
    [SerializeField] public float launchForce = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 startPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        startPos.y += 3;
        this.transform.position = startPos;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)|| Input.GetButton("Submit"))
        {
            if (!isLaunched)
            {
                isLaunched = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().linearVelocity = launchForce * Vector3.up;
            }
        }
    }
}

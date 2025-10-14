using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    bool isLaunched = false;
    [SerializeField] public float launchForce = 20f;
    Vector3 lastPosition = Vector3.zero;
    Vector3 direction = Vector3.zero;
    Rigidbody rb;
    private Border_Control border;
    public UnityEvent ballDestroy;

    private void Awake()
    {
        border = GetComponent<Border_Control>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 startPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        startPos.y += 3;
        this.transform.position = startPos;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (border.bottomBorder)
        {
            ballDestroy.Invoke();
            Destroy(this.gameObject);
        }

        if (border.topBorder)
        {
            direction = transform.position - lastPosition;
            Debug.Log("La bola toco el borde superior");
            direction.y *= -1;
            direction.Normalize();
            rb.linearVelocity = launchForce * direction;
            border.topBorder = false;
            border.enabled = false;
            Invoke("EnableBorder", 0.2f);
        }

        if (border.rightBorder)
        {
            direction = transform.position - lastPosition;
            Debug.Log("La bola toco el borde derecho");
            direction.x *= -1;
            direction.Normalize();
            rb.linearVelocity = launchForce * direction;
            border.rightBorder = false;
            border.enabled = false;
            Invoke("EnableBorder", 0.2f);
        }

        if (border.leftBorder)
        {
            direction = transform.position - lastPosition;
            Debug.Log("La bola toco el borde izquierdo");
            direction.x *= -1;
            direction.Normalize();
            rb.linearVelocity = launchForce * direction;
            border.leftBorder = false;
            border.enabled = false;
            Invoke("EnableBorder", 0.2f);
        }

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

    private void EnableBorder()
    {
        border.enabled = true;
    }

    private void FixedUpdate()
    {
        lastPosition = transform.position;
    }

    private void LateUpdate()
    {
        if(direction != Vector3.zero)
        {
            direction = Vector3.zero;
        }
    }
}

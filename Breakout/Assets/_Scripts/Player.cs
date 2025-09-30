using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public int limitX = 24;
    [SerializeField] public float speed = 40f;

    Vector3 MousePos2D;
    Vector3 MousePos3D;

    Transform trans;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trans = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //MousePos2D = Input.mousePosition;
        //MousePos2D.z = -Camera.main.transform.position.z;
        //MousePos3D = Camera.main.ScreenToWorldPoint(MousePos2D);

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    this.transform.Translate(Vector3.down * speed * Time.deltaTime);        
        //}

        //if(Input.GetKey(KeyCode.LeftArrow))
        //{
        //    this.transform.Translate(Vector3.up * speed * Time.deltaTime);
        //}

        transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * speed * Time.deltaTime);

        Vector3 pos = transform.position;
        //pos.x = MousePos3D.x;
        if (pos.x < -limitX)
        {
            pos.x = -limitX;
        }
        else if (pos.x > limitX)
        {
            pos.x = limitX;
        }
        
        transform.position = pos;
    }
}

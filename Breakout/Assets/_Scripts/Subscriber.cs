using UnityEngine;

public class Subscriber : MonoBehaviour
{

    Events subscribe;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        subscribe = GetComponent<Events>();
        subscribe.OnSpacePressed += MessageListener;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MessageListener(object sender, System.EventArgs e)
    {
        Debug.Log("Space key was pressed!");
        subscribe.OnSpacePressed -= MessageListener;
    }
}

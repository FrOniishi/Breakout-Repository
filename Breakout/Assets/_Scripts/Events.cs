    using UnityEngine;
    using System;
    using UnityEngine.Events;

public class Events : MonoBehaviour
{
    public event EventHandler OnSpacePressed;
    public UnityEvent MyUnityEvent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnSpacePressed += Subscribe;
        MyUnityEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Submit"))
        {
            OnSpacePressed?.Invoke(this, EventArgs.Empty);
        }
    }

    public void Subscribe(object sender, EventArgs e)
    {
        Debug.Log("Space key was pressed!");
    }

    public void MyUnityEventListener()
    {
        Debug.Log("My Unity Event was invoked!");
    }
}

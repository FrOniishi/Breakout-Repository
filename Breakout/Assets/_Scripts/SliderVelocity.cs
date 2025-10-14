using System;
using UnityEngine;
using UnityEngine.UI;

public class SliderVelocity : MonoBehaviour
{
    public Options options;
    Slider Slider;

    public void Start()
    {
        Slider = this.GetComponent<Slider>();
        Slider.onValueChanged.AddListener(delegate { ChangerController(); });
    }

    public void ChangerController()
    {
        options.SetVelocity(Slider.value);
    }
}

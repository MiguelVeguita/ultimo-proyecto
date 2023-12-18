using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sonscrip : MonoBehaviour
{
    public Slider slider;
    public float slidervalue;
    

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenaudio", 0.5f);
        AudioListener.volume = slider.value;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sliderrr(float valor)
    {
        slidervalue = valor;
        PlayerPrefs.SetFloat("volumenaudio", slidervalue);
        AudioListener.volume = slider.value;




    }
}

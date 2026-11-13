using UnityEngine;
using UnityEngine.UI;

public class PitchControl : MonoBehaviour
{
    public Slider bgmSlider;
    public AudioSource bgm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bgmSlider.minValue = -3;
        bgmSlider.maxValue = 3;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePitch()
    {
        bgm.pitch = bgmSlider.value;
    }

        
}

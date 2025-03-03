using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    [SerializeField] Slider soundSlider;
    [SerializeField] AudioMixer masterMixer;

    private void Start()
    {
        setVolume(PlayerPrefs.GetFloat("SavedMasterVolume", 100));
    }

    public void setVolume(float _value)
    {
        if(_value < 1)
        {
            _value = 0.001f;
        }

        RefreshSlider(_value);
        PlayerPrefs.SetFloat("SavedMasterVolume", _value);
        masterMixer.SetFloat("MasterVolume", Mathf.Log10(_value / 100) * 20f);
    }

    public void SetVolumeFromSlider()
    {
        setVolume(soundSlider.value);
    }

    public void RefreshSlider(float _value)
    {
        soundSlider.value = _value;
    }
}
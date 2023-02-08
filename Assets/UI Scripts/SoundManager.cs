using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicValue"))
        {
            PlayerPrefs.SetFloat("musicValue",1);
            load();
        }
        else
        {
            load();
        }
    }
    public void changeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    public void load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume",volumeSlider.value);
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundBar : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Slider volumeSlider;


    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else 
        { 
            Load();
        }
    }

    // Update is called once per frame
    public void ChangeVolume()
    {

        AudioListener.volume = volumeSlider.value;
        Save();

    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    { 
      PlayerPrefs.SetFloat("musicVolume",volumeSlider.value);
    }

}
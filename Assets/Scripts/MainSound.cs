using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSound : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private AudioSource sourceSong;
    [SerializeField] private AudioSource ButtonClick;
    public static MainSound instance;
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (instance!=null)
        {
            Destroy(this);
        }
        
    }
    

    // Update is called once per frame
    void Update()
    {
        sourceSong.volume = PlayerPrefs.GetFloat("musicVolume");
    }

    public void buttonSound()
    {
        ButtonClick.Play();
    }

    
}

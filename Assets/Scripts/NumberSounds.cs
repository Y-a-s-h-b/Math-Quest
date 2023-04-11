using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberSounds : MonoBehaviour
{
    [SerializeField] private AudioSource ButtonClick01;
    [SerializeField] private AudioSource ButtonClick02;
    public static NumberSounds Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void ButtonClickSound1()
    {
        ButtonClick01.Play();
    }

    public void ButtonClickSound2()
    {
        ButtonClick02.Play();
    }
}

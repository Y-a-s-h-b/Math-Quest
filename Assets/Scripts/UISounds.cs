using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISounds : MonoBehaviour
{
    [SerializeField] private AudioSource ButtonClick;
    // Start is called before the first frame update
    public void buttonSound()
    {
        ButtonClick.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private Animator anim;
    public GameObject end;
    private Movement bookPickAnimation;

    // Start is called before the first frame update
    void Start()
    {
        bookPickAnimation = GetComponent<Movement>();
        anim = GetComponent<Animator>();
    }
}

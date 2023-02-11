using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private Animator anim;
    public GameObject end;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("destroy");
            end.SetActive(true);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

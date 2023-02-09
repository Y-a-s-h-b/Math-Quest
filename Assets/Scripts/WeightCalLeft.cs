using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightCalLeft : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public float massMultiplier;
    private char symb;
    private int weight2;
    private Rigidbody2D rb;
    private int k = 20;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = 1f;
    }

    private void Update()
    {

        //this.transform.position = posiGameObj.transform.position;

    }

    public void changeWeight()
    {
        symb = slot1.GetComponent<SymbolIdentifier>().Symbol;
        weight2 = slot2.GetComponent<WeightIdentifierLvl10>().weight;
        Debug.Log("Weigh1");        
        Debug.Log(weight2);
        int knew = 0;
        if (weight2>0 && weight2<10 && symb!='k')
        {
            if (symb == 'x')
            {
                knew = 4 * weight2;

            }
            else if (symb == '-')
            {
                knew = 4 - weight2;
            }
            else if (symb == '+')
            {
                knew = 4 + weight2;
            }
            else
            {
                knew = 0;
            }
        }
        
        
        


        rb.mass = ((knew) * massMultiplier) + 1;
        rb.simulated = false;
        rb.simulated = true;
    }
}

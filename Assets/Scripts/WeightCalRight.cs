using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WeightCalRight : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public float massMultiplier;
    private char symb;
    private int weight1;
    private int weight2;
    private Rigidbody2D rb;
    private int k = 20;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = 1f;
    }


    public void changeWeight()
    {       
        
        weight1 = slot1.GetComponent<WeightIdentifierLvl10R>().weight;
        weight2 = slot2.GetComponent<WeightIdentifierLvl10R>().weight;
        symb = slot3.GetComponent<SymbolIdentifier>().Symbol;
        Debug.Log("Weigh1");
        
        Debug.Log(symb);

        int knew = 0;
        if ((weight2 > 0 && weight2 < 10) && (weight1 > 0 && weight1 < 10) && symb !='k')
        {
            if (symb == 'x')
            {
                knew = weight1 + (weight2 * 3);

            }
            else if (symb == '-')
            {
                knew = weight1 + (weight2 - 3);
            }
            else if (symb == '+')
            {
                knew = weight1 + (weight2 + 3);
            }
            else
            {
                knew = 0;
                symb = 'k';
            }
        }
        else
        {
            knew = 0;
        } 
        

        


        rb.mass = ((knew) * massMultiplier) + 1;
        rb.simulated = false;
        rb.simulated = true;
    }
}

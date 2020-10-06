using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour {

    private Level2 Level2;
    private Variables Variables;
    public int Condition;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Variables = GameObject.FindGameObjectWithTag("UI").GetComponent<Variables>();
        Level2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Level2>();

        if (Level2.Block == 2)
        {
            if (Variables.order == 0)
            {
                Condition = 1;
            }
            if (Variables.order == 1)
            {
                Condition = 2;
            }
        }
        /*    if (Variables.order == 2)
            {
                Condition = 3;
            }
        }
        if (Level2.Block == 3)
        {
            if (Variables.order == 0)
            {
                Condition = 2;
            }
            if (Variables.order == 1)
            {
                Condition = 3;
            }
            if (Variables.order == 2)
            {
                Condition = 1;
            }
        }
        if (Level2.Block == 4)
        {
            if (Variables.order == 0)
            {
                Condition = 3;
            }
            if (Variables.order == 1)
            {
                Condition = 1;
            }
            if (Variables.order == 2)
            {
                Condition = 2;
            }
        }*/
    }
}

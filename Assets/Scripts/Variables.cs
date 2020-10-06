using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class Variables : MonoBehaviour { //This script holds the variables the other scripts use. 

   
    //These inputs reference their respective input fields in the option menu.
    public Dropdown HandDominance;// this comes out as a binary. 0 = right 1 = left
    public Dropdown ConditionOrder;
    public Dropdown Expermentnum;
    public InputField Participant;
    public InputField ArmLength;
    public InputField Shoulderheight;
    public InputField Eyeheight;

    // These are what the other scripts reference.
    public int participant;
    public float arm;
    public float shoulder;
    public int order;
    public int hand;
    public float eye;
    public int Experiment;

    public string folder = "C:\\Users\\tyler\\Desktop\\Data\\";    
	
	// Update is called once per frame
	void Update ()
    {
        participant = System.Convert.ToInt32(Participant.text);// These are to convert the input into usable data. 
        hand = HandDominance.value;
        order = ConditionOrder.value;
        Experiment = Expermentnum.value;
        arm = System.Convert.ToSingle(ArmLength.text);
        shoulder = System.Convert.ToSingle(Shoulderheight.text);
        eye = System.Convert.ToSingle(Eyeheight.text);
    }
}





    

  
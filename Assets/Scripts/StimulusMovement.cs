using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StimulusMovement : MonoBehaviour {
    public float speed;
    public float Distance;
    public float StartingHeight;
    private Variables Variables;
    Vector3 StimulusReach;
    // Use this for initialization

    void Awake()
    {
        Variables = GameObject.FindGameObjectWithTag("UI").GetComponent<Variables>(); //This pulls the variables from the variables script. It's a handy way to call variables from objects without manualy telling unity where to look for the corisponding script every time a new scene loads. 
    }

    void Start ()
    {
        if (Variables.Experiment == 2 || Variables.Experiment == 3) { gameObject.SetActive(false); } //This removes the bar in experiments 2 and 3.
         
       StimulusReach = transform.position;
        StimulusReach.y = StartingHeight;
        StimulusReach.z = (Variables.arm * Distance);
        transform.position = StimulusReach;
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        float verticalInput = Input.GetAxis("Oculus_CrossPlatform_PrimaryThumbstickVertical");
        
        transform.Translate(new Vector3(0, verticalInput, 0) * speed * Time.deltaTime);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleHands : MonoBehaviour {
    private Variables var;
    private ResponseTime ResponseTime;
	// Use this for initialization
	void Start () {
    transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        var = GameObject.FindGameObjectWithTag("UI").GetComponent<Variables>();

        if (var.order == 1) 
            transform.GetChild(0).gameObject.SetActive(true);
        else 
            transform.GetChild(0).gameObject.SetActive(false);


    }
}

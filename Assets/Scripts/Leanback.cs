using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Leanback : MonoBehaviour {
    public OVRCameraRig OVRCameraRig;

    public float positionX;
    public float positionY;
    public float positionZ;
    Vector3 position;
    private ResponseTime ResponseTime;
    private Variables Variables;
    private Level2 Level2;
    public float clock;
    public int frame = 0;
    public int Error = 1;
    public bool lean;
    public double forward = 0.01; 
    // Use this for initialization
    void Start () {
        Variables = GameObject.FindGameObjectWithTag("UI").GetComponent<Variables>();
        lean = false;
        transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void FixedUpdate(){

        position = transform.position; positionX = position.x; positionY = position.y; positionZ = position.z;
        ResponseTime = GameObject.FindGameObjectWithTag("ResponseTime").GetComponent<ResponseTime>();
        Level2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Level2>();
        frame = Time.frameCount;
        clock += Time.deltaTime * 1;

        if (positionZ >= forward)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            if (!lean)
            {
                StreamWriter sw = File.AppendText(Variables.folder + "Error_Count_Participant" + Variables.participant + ".csv");
                sw.WriteLine(Error + "," + Level2.Trial + "," + ResponseTime.Trial + "," + frame + "," + ResponseTime.levelTimer + "," + clock);
                sw.Close();
                lean = true;
                Error++;
            }
        }
        else
        {
            lean = false;
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}

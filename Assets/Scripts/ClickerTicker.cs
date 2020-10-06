using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ClickerTicker : MonoBehaviour {

    private ResponseTime ResponseTime;
    private Variables Variables;
    private Level2 Level2;
    public float clock;
    public int frame = 0;
    public int Error = 1;
    //public int ErrorCount = 0;

    
    
    void Start ()
    {
        //Variables = GameObject.FindGameObjectWithTag("UI").GetComponent<Variables>();
        //StreamWriter sw = File.AppendText(Variables.folder + "Error_Count_Participant" + Variables.participant + ".csv"); //Edit this to change where the file is writen.
        //sw.WriteLine("Error" + "," + "Trial" + "," + "Scene" + "," + "Frame" + "," + "SceneClock" + "," + "Clock");//Names the headers
        //sw.Close();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //ResponseTime = GameObject.FindGameObjectWithTag("ResponseTime").GetComponent<ResponseTime>();
        //Level2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Level2>();
        //frame = Time.frameCount;
        //clock += Time.deltaTime * 1;

        //if (Input.GetKeyDown(KeyCode.Z))
        //{
        //    //ErrorCount = ErrorCount + Error;
        //    StreamWriter sw = File.AppendText(Variables.folder + "Error_Count_Participant" + Variables.participant + ".csv");
        //    sw.WriteLine(Error + "," + Level2.Trial + "," + ResponseTime.Trial + "," + frame + "," + ResponseTime.levelTimer + "," + clock);
        //    sw.Close();
        //}
        if (Input.GetKeyDown(KeyCode.R) || OVRInput.GetDown(OVRInput.Button.Two))
        {
            UnityEngine.XR.InputTracking.Recenter();
        }
    }
}

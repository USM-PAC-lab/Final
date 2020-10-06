using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class BarData : MonoBehaviour {

    private Level2 Level2;
    private Variables Variables;
    private StimulusMovement StimulusMovement;
    public float ReactionTime;
    public float positionZ;
    public float positionY;
    Vector3 position;

    // Use this for initialization
    void Start () {
        Level2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Level2>();
        StimulusMovement = GameObject.FindGameObjectWithTag("BAR").GetComponent<StimulusMovement>();
        Variables = GameObject.FindGameObjectWithTag("UI").GetComponent<Variables>();
        if (System.IO.File.Exists((Variables.folder + "BarPositionData" + Variables.participant + ".csv")))
        {
            //do nothing
        }
        else
        {
            StreamWriter sw = File.AppendText(Variables.folder + "BarPositionData" + Variables.participant + ".csv");
            sw.WriteLine("PositionY" + "," + "PositionZ" + "," + "Block" + "," + "Trial" + "," + "ReactionTime" + "," + "Scene" + "," + "Starting Height" + "," + " Distance");
            sw.Close();
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        position = transform.position;  positionY = position.y; positionZ = position.z;
        if (Level2.WaitTimer > 2.0f) { ReactionTime += Time.deltaTime; }
        if (Level2.KeysEnabled == true)
        {
            if (OVRInput.GetDown(OVRInput.Button.One) || (OVRInput.GetDown(OVRInput.Button.Three)))
            {
                StreamWriter sw = File.AppendText(Variables.folder + "BarPositionData" + Variables.participant + ".csv");
                sw.WriteLine(positionY + "," + positionZ + "," + Level2.Block + "," + Level2.Trial + "," + ReactionTime + "," + currentScene.name + "," + StimulusMovement.StartingHeight + "," + StimulusMovement.Distance);
                sw.Close();
            }
        }
    }
   
}


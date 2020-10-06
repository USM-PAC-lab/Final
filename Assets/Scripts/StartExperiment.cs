using UnityEngine;
using UnityEngine.SceneManagement;

public class StartExperiment : MonoBehaviour
{

    private ShowPanels showPanels;
    public int order;
    void Awake()
    {
        showPanels = GetComponent<ShowPanels>();   
    }


    // Update is called once per frame
    void Update()
    {
        
        showPanels = GameObject.FindGameObjectWithTag("UI").GetComponent<ShowPanels>();

        
        
            if (Input.GetKey(KeyCode.LeftControl) & (Input.GetKey(KeyCode.R))) // Change this if you want to start the experiment some other way

            { 
                SceneManager.LoadScene("Begin 1");
                showPanels.HideMenu();
            }

    
    }
}
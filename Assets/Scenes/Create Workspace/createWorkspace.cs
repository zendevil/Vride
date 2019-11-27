using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;
public class createWorkspace : MonoBehaviour
{
    string workspaceName;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void getWorkspaceName()
    {
	workspaceName = GameObject.Find("Workspace Name").GetComponent<TMP_InputField>().text;
       
    }

    public void createNewWorkspace()
    {
	Debug.Log("Creating Workspace Named " + workspaceName);
	SceneManager.LoadScene("Workspace");
    }
	
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

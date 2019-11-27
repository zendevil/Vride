using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class welcome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	// Debug.Log("Create Workspace Clicked");
    }

    public void CreateWorkspaceDialog()
    {
	Debug.Log("Create Workspace Clicked");
	SceneManager.LoadScene("Create Workspace Dialog");
    }

    public void joinWorkspaceDialog()
    {
	Debug.Log("Join Workspace Clicked");
	SceneManager.LoadScene("Join Workspace Dialog");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

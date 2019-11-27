using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class token : MonoBehaviour
{
    string workspaceToken;
    // Start is called before the first frame update
    void Start()
    {
	workspaceToken = System.Guid.NewGuid().ToString();
	GetComponent<TextMeshProUGUI>().text = "Workspace Token:\n " + workspaceToken;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

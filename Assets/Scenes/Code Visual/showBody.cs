// Prikshet Sharma, 2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

using TMPro;
using System.Net.Http;
using System.Net.Http.Headers;
public class showBody : MonoBehaviour
{
    private static readonly HttpClient client = new HttpClient();
    // returns code's json structure
    public Button showCodeButton;
    private static async Task get_code() {
    	
	var stringTask = client.GetStringAsync("https://localhost:5000");
	//var stringTask = client.GetStringAsync("https://github.com/zendevil/camera-pipeline");
	try {
	var msg = await stringTask;
	Debug.Log(msg);
	}
	catch (HttpRequestException e) {
	    Debug.Log(e.Message);
	}

    }
    
    // Start is called before the first frame update
    void Start()
    {
	
	//Debug.Log("start");	
	//get_code().Wait();
	//Debug.Log("Waited");
	showCodeButton = GameObject.Find("Show Code").GetComponent<Button>();
	showCodeButton.onClick.AddListener(() => toggleDisplayBody());
        
    }

    public TMP_Text bodyText;
    bool displayed = false;
    void toggleDisplayBody() {
	Debug.Log ("Button Clicked");
	bodyText = GameObject.Find("Body Text").GetComponent<TMP_Text>();
	string body = "int a = 3;\n int b = 4;\n std::cout<<\"a + b\"<<std::endl;";
	if (displayed) {
	    bodyText.text = "";
	    displayed = false;
	} else {
	    bodyText.text = body;
	    displayed = true;
	}
	Debug.Log ("Enabled");
    }
    
    
}

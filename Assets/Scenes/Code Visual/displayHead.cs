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
public class displayHead : MonoBehaviour
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

	string heading = "main()";
	string body = "int a = 3;\n int b = 4;\n std::cout<<\"a + b\"<<std::endl;";
       	
	GameObject.Find("Head").GetComponent<TMP_Text>().text = "<color=#000000>" + heading + "</color>";
	
    }    
    
}

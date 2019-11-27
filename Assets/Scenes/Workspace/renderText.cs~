using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class renderText : MonoBehaviour
{

    List<string> text = new List<string>();
    string currentLine = "";
    KeyCode lastKey;
    float lastEventTime;
    int cursorPosition = 0;
    // Start is called before the first frame update
    void Start()
    {
	Debug.Log("start");
    }

    string addAtPosition(string currentLine, string newChar, int cursorPosition) {
	string newCurrentLine = currentLine.Substring(0, cursorPosition) + newChar ;
	Debug.Log("cursorPosition: " + cursorPosition);
	Debug.Log("currentLine.Length: " + currentLine.Length);
	if (cursorPosition < currentLine.Length) {
	    newCurrentLine += currentLine.Substring(cursorPosition, currentLine.Length - cursorPosition);
	}
	return newCurrentLine;
    }
    void OnGUI()
    {
	
	Event e = Event.current;
	
	if (e.type == EventType.KeyDown && e.keyCode != KeyCode.None)
	{
	    
	    switch(e.keyCode) {
		case KeyCode.Return:
		    Debug.Log("Return");
		    text.Add(currentLine);
		    currentLine = "";
		    cursorPosition = -1; // -1 to offset the increment after the switch statement
 		    break;
		case KeyCode.Backspace:
		    Debug.Log("Backspace");
		    string newCurrentLine = currentLine.Substring(0, cursorPosition - 1);
		    if (cursorPosition < currentLine.Length) {
			newCurrentLine += currentLine.Substring(cursorPosition, currentLine.Length - cursorPosition);
		    }
		    currentLine = newCurrentLine;
		    cursorPosition -= 2;
		    break;
		case KeyCode.Space:
		    Debug.Log("Space");
		    currentLine = addAtPosition(currentLine, " ", cursorPosition); 
		    break;
		case KeyCode.Alpha0:
		    Debug.Log("0");
		    currentLine = e.shift ? addAtPosition(currentLine, ")", cursorPosition) : addAtPosition(currentLine, "0", cursorPosition);
		    break;
		case KeyCode.Alpha1:
		    Debug.Log("1");
		    currentLine = e.shift ? addAtPosition(currentLine, "!", cursorPosition) : addAtPosition(currentLine, "1", cursorPosition);
		    break;
		case KeyCode.Alpha2:
		    Debug.Log("2");
		    currentLine = e.shift ? addAtPosition(currentLine, "@", cursorPosition) : addAtPosition(currentLine, "2", cursorPosition);
		    break;
		case KeyCode.Alpha3:
		    Debug.Log("3");
		    currentLine = e.shift ? addAtPosition(currentLine, "#", cursorPosition) : addAtPosition(currentLine, "3", cursorPosition);
		    break;
		case KeyCode.Alpha4:
		    Debug.Log("4");
		    currentLine = e.shift ? addAtPosition(currentLine, "$", cursorPosition) : addAtPosition(currentLine, "4", cursorPosition);
		    break;
		case KeyCode.Alpha5:
		    Debug.Log("5");
		    currentLine = e.shift ? addAtPosition(currentLine, "%", cursorPosition) : addAtPosition(currentLine, "5", cursorPosition);
		    break;
		case KeyCode.Alpha6:
		    Debug.Log("6");
		    currentLine = e.shift ? addAtPosition(currentLine, "^", cursorPosition) : addAtPosition(currentLine, "6", cursorPosition);
		    break;
		case KeyCode.Alpha7:
		    Debug.Log("7");
		    currentLine = e.shift ? addAtPosition(currentLine, "&", cursorPosition) : addAtPosition(currentLine, "7", cursorPosition);
		    break;
		case KeyCode.Alpha8:
		    Debug.Log("8");
		    currentLine = e.shift ? addAtPosition(currentLine, "*", cursorPosition) : addAtPosition(currentLine, "8", cursorPosition);
		    break;
		    
		case KeyCode.Alpha9:
		    Debug.Log("9");
		    currentLine = e.shift ? addAtPosition(currentLine, "(", cursorPosition) : addAtPosition(currentLine, "9", cursorPosition);
		    break;
		case KeyCode.LeftBracket:
		    Debug.Log("{");
		    currentLine = e.shift ? addAtPosition(currentLine, "{", cursorPosition) : addAtPosition(currentLine, "[", cursorPosition);
		    break;

		case KeyCode.RightBracket:
		    Debug.Log("}");
		    currentLine = e.shift ? addAtPosition(currentLine, "}", cursorPosition) : addAtPosition(currentLine, "]", cursorPosition);
		    break;

		case KeyCode.Comma:
		    Debug.Log(",");
		    currentLine = e.shift ? addAtPosition(currentLine, "<", cursorPosition) : addAtPosition(currentLine, ",", cursorPosition);
		    break;

		case KeyCode.Semicolon:
		    Debug.Log(";");
		    currentLine = e.shift ? addAtPosition(currentLine, ":", cursorPosition) : addAtPosition(currentLine, ";", cursorPosition);
		    break;

		case KeyCode.Slash:
		    Debug.Log("/");
		    currentLine = e.shift ? addAtPosition(currentLine, "?", cursorPosition) : addAtPosition(currentLine, "/", cursorPosition);
		    break;

		case KeyCode.Backslash:
		    Debug.Log(";");
		    currentLine = e.shift ? addAtPosition(currentLine, "|", cursorPosition) : addAtPosition(currentLine, "\\", cursorPosition);
		    break;

		case KeyCode.BackQuote:
		    Debug.Log("`");
		    currentLine = e.shift ? addAtPosition(currentLine, "~", cursorPosition) : addAtPosition(currentLine, "`", cursorPosition);
		    break;
		    
		case KeyCode.Minus:
		    Debug.Log("-");
		    currentLine = e.shift ? addAtPosition(currentLine, "_", cursorPosition) : addAtPosition(currentLine, "-", cursorPosition);
		    break;

		case KeyCode.Equals:
		    Debug.Log("=");
		    currentLine = e.shift ? addAtPosition(currentLine, "+", cursorPosition) : addAtPosition(currentLine, "=", cursorPosition);
		    break;
		    
		case KeyCode.Period:
		    Debug.Log(".");
		    currentLine = e.shift ? addAtPosition(currentLine, ">", cursorPosition) : addAtPosition(currentLine, ".", cursorPosition);
		    break;

		case KeyCode.LeftArrow:
		    Debug.Log("LeftArrow");
		    if (cursorPosition > 0) {
			cursorPosition -= 2;
		    }
		    break;
		    
		case KeyCode.RightArrow:
		    Debug.Log("LeftArrow");
		    // offset the increase in cursor position if at the end of the buffer
		    if (cursorPosition == currentLine.Length) {
			cursorPosition--; 
		    }
		    break;

		case KeyCode.UpArrow:
		    
		    
		default: // alphabet	        
		    if (e.capsLock || e.shift) {
			Debug.Log("Detected key code: " + e.keyCode.ToString());
			currentLine = addAtPosition(currentLine, e.keyCode.ToString(), cursorPosition);
		    } else {
			Debug.Log("Detected key code: " + e.keyCode.ToString().ToLower());
			currentLine = addAtPosition(currentLine, e.keyCode.ToString().ToLower(), cursorPosition);
		    }
		    break;
	    }
	    string renderText = "";
	    foreach(string line in text) {
		renderText += line + "\n";
	    }
	    renderText += currentLine;
	    GameObject.Find("Text Editor").GetComponent<Text>().text = "<color=#000000>" + renderText + "</color>";
	    // /Assets/Scenes/Workspace/
	    System.IO.File.WriteAllText(@"./Assets/Scenes/Workspace/code.txt", renderText);
	    Debug.Log("Written");
	    cursorPosition++;
	}
    }
    
    // Update is called once per frame
    // void Update()
    // {
        
    // }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XunFeiTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private string showResult = "";
	public Text shurukuang;

	/*
	public void OnGUI ()
	{
		if (GUILayout.Button ("startRecognizer", GUILayout.Height (100))) {  
			AndroidJavaClass jc = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");  
			AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject> ("currentActivity"); 
			jo.Call ("startSpeechListener");  
		}  

		GUILayout.TextArea (showResult, GUILayout.Width (200));  

	}
	*/
	public void Kaishi ()
	{
		AndroidJavaClass jc = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");  
		AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject> ("currentActivity"); 
		jo.Call ("startSpeechListener");  
	}

	public void Result (string recognizerResult)
	{  
		showResult += recognizerResult;
		showResult += '\n';
		shurukuang.text = showResult;  
	}
}

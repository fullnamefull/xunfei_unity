using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Xuhaitao : MonoBehaviour {
	public InputField shurukuang;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnGUI ()
	{
		AndroidJavaClass jc = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");  
		AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject> ("currentActivity"); 
		jo.Call ("startSpeechListener");  
	}

	public void Result (string recognizerResult)
	{  
		shurukuang.text = recognizerResult;  
	}
}

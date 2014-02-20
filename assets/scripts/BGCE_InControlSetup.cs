using UnityEngine;
using System.Collections.Generic;
using InControl;

public class BGCE_InControlSetup : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		InputManager.Setup();
	}
	
	// Update is called once per frame
	void Update () 
	{
		InputManager.Update();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public enum State {Start, Ready, Captured, inProcess, Identified, Settings};

	public State currentState;

	// Use this for initialization
	void Start () 
	{
		// Que up demo  
        currentState = State.Start;	
	}
	
	// Update is called once per frame
	void Update () {
		if (currentState == State.Start)
		{
			//Debug.Log("Start mode");
			return;
		}
		if (currentState == State.Ready)
		{
			//Debug.Log("Ready mode");
			return;
		}
		if (currentState == State.Captured)
		{
			//Debug.Log("Capture mode");
			return;
		}
		if (currentState == State.inProcess)
		{
			//Debug.Log("inProcess mode");
			return;
		}
		if (currentState == State.Identified)
		{
			//Debug.Log("Identified mode");
			return;
		}
		if (currentState == State.Settings)
		{
			//Debug.Log("Settings mode");
			return;
		}
		else if (currentState == null)
		{

			Debug.LogWarning("No State found");
		}
	}
}

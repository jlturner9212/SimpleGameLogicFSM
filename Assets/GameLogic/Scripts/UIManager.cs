using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameLogic;

public class UIManager : MonoBehaviour
{
    EnumFSM mGameManager;

    Button mButton0;
    Button mButton1;
    Button mButton2;
    Button mButton3;
    Button mButton4;

    void Start () {

        mGameManager = GameObject.Find("GameManager").GetComponent<EnumFSM>();

        // Get Buttons
        mButton0 = GameObject.Find("Button (0)").GetComponent<Button>();
        mButton1 = GameObject.Find("Button (1)").GetComponent<Button>();
        mButton2 = GameObject.Find("Button (2)").GetComponent<Button>();
        mButton3 = GameObject.Find("Button (3)").GetComponent<Button>();
        mButton4 = GameObject.Find("Button (4)").GetComponent<Button>();

        // Load Buttons
        mButton0.onClick.AddListener(State1);
        mButton1.onClick.AddListener(State2);
        mButton2.onClick.AddListener(State3);
        mButton3.onClick.AddListener(State4);
        mButton4.onClick.AddListener(State5);
    }
	
	void Update () {
		
	}

    public void State1()
    {
        Debug.Log("State1 pressed");
        mGameManager.currentState = EnumFSM.State.Start;
    }
    public void State2()
    {
        Debug.Log("State2 pressed");
        mGameManager.currentState = EnumFSM.State.Ready;
    }
    public void State3()
    {
        Debug.Log("State3 pressed");
        mGameManager.currentState = EnumFSM.State.Captured;
    }
    public void State4()
    {
        Debug.Log("State4 pressed");
        mGameManager.currentState = EnumFSM.State.Identified;
    }
    public void State5()
    {
        Debug.Log("State5 pressed");
        mGameManager.currentState = EnumFSM.State.Settings;
    }
}

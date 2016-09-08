using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterInput : MonoBehaviour {

	Button[] commands;

	void Start () 
	{
		commands = GetComponentsInChildren<Button>();
	}

	void Update () 
	{
		if(Input.GetButtonDown("Up"))
		{
			// start up ability functionality
			commands[0].onClick.Invoke();
		}
	}
}

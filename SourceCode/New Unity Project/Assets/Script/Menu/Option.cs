using UnityEngine;
using System.Collections;

public class Option : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	public void SwitchSceneOption()
	{
		Application.LoadLevel ("Option");
	}
	public void SwitchSceneMenu()
	{
		Application.LoadLevel ("Menu");
	}

	// Update is called once per frame
	void Update () {
	
	}
}

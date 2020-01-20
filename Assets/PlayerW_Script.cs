using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;

public class PlayerW_Script : MonoBehaviour {

	public int playerWins = 0;
	public Text winText;
	//shows that player winds
	// Use this for initialization
	void Start () {
		winText.text = "0";
	}

	void Update()
	{
		winText.GetComponent<Text>().text = playerWins.ToString();
	}
}

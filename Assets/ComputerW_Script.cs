using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;

public class ComputerW_Script : MonoBehaviour {

	public int opponentWins = 0;
	public Text winText;
	//shows that computer wins
	// Use this for initialization
	void Start()
	{
		winText.text = "0";
	}

	void Update()
	{
		winText.GetComponent<Text>().text = opponentWins.ToString();
	}
}

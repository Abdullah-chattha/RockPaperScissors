using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;

public class Rock_OptionScript : MonoBehaviour {
	//objects
	public GameObject playerP;
	public GameObject playerWins;
	public GameObject playerO;
	public GameObject opponentWins;
	//methods
	public void Rock_Choose()
	{
		int rNum = Random.Range(0, 3);// chooses between 3 random options 
		playerP.GetComponent<Pick_Script>().matElement = 0;
		playerO.GetComponent<Computer_Script>().matElement = rNum;
		//decides who winds round 
		if (rNum == 2 && playerWins.GetComponent<PlayerW_Script>().playerWins < 10)
		{
			playerWins.GetComponent<PlayerW_Script>().playerWins++;// adds points 
		} else if (rNum == 1 && opponentWins.GetComponent<ComputerW_Script>().opponentWins < 10)
		{
			opponentWins.GetComponent<ComputerW_Script>().opponentWins++;// adds points 
		} else if (playerWins.GetComponent<PlayerW_Script>().playerWins == 9)
		{
			SceneManager.LoadScene ("YouWin"); //checks who wins
		} else if (opponentWins.GetComponent<ComputerW_Script>().opponentWins == 9)
		{
			SceneManager.LoadScene ("YouLose"); //checks who wins
		}
	}
}

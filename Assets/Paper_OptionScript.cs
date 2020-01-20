using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;

public class Paper_OptionScript : MonoBehaviour {
	//objcst
	public GameObject playerP;
	public GameObject playerWins;
	public GameObject playerO;
	public GameObject opponentWins;

	//methods
	public void Paper_Choose()
	{
		int rNum = Random.Range(0, 3);//random selection 
		playerO.GetComponent<Computer_Script>().matElement = rNum;
		playerP.GetComponent<Pick_Script>().matElement = 1;

		if (rNum == 0 && playerWins.GetComponent<PlayerW_Script>().playerWins < 10)
		{
			playerWins.GetComponent<PlayerW_Script>().playerWins++;//adds points
		} else if (rNum == 2 && opponentWins.GetComponent<ComputerW_Script>().opponentWins < 10)
		{
			opponentWins.GetComponent<ComputerW_Script>().opponentWins++;//adss points
		} else if (playerWins.GetComponent<PlayerW_Script>().playerWins == 9)
		{
			SceneManager.LoadScene ("YouWin");
		} else if (opponentWins.GetComponent<ComputerW_Script>().opponentWins == 9)
		{
			SceneManager.LoadScene ("YouLose");
		}
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class changeBest : MonoBehaviour {

	public Text best;
	static public int bestScore;
	static public bool showGameOver = false;
	static public bool showNewRecord = false;

	// Use this for initialization
	void Start () {
	
	}
	
	static public void checkScore()
	{
		if(changescore.scoreInt > bestScore)
		{
			showNewRecord = true;
			if(PublicGamemode.gameMode == "practice")
			{
				PlayerPrefs.SetInt("practiceBest", changescore.scoreInt);
				
			}
			
			if(PublicGamemode.gameMode == "easy")
			{
				PlayerPrefs.SetInt("easyBest", changescore.scoreInt);
			}
			
			if(PublicGamemode.gameMode == "medium")
			{
				PlayerPrefs.SetInt("mediumBest", changescore.scoreInt);
			}
			
			if(PublicGamemode.gameMode == "hard")
			{
				PlayerPrefs.SetInt("hardBest", changescore.scoreInt);
			}
			
			if(PublicGamemode.gameMode == "insane")
			{
				PlayerPrefs.SetInt("insaneBest", changescore.scoreInt);
			}
		}
		else
		{
			showGameOver = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(PublicGamemode.gameMode == "practice")
		{
			best.text = "";
		}
		
		if(PublicGamemode.gameMode == "easy")
		{
			bestScore = PlayerPrefs.GetInt("easyBest", 0);
			best.text = "BEST: " + bestScore.ToString();
		}
		
		if(PublicGamemode.gameMode == "medium")
		{
			bestScore = PlayerPrefs.GetInt("mediumBest", 0);
			best.text = "BEST: " + bestScore.ToString();
		}
		
		if(PublicGamemode.gameMode == "hard")
		{
			bestScore = PlayerPrefs.GetInt("hardBest", 0);
			best.text = "BEST: " + bestScore.ToString();
		}
		
		if(PublicGamemode.gameMode == "insane")
		{
			bestScore = PlayerPrefs.GetInt("insaneBest", 0);
			best.text = "BEST: " + bestScore.ToString();
		}
		
	}
}

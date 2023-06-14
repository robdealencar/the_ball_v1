using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class changescore : MonoBehaviour {
	
	public move playerMoney;
	static Text score;
	static public int scoreInt;
	
	// Use this for initialization
	void Awake () {
		score = GetComponent<Text>();
		
		playerMoney = GetComponent<move>();
		
//		print(playerMoney.money);
	}
	
	void Start () {
		scoreInt = 0;
	}
	
	static public void addScore(int amount)
	{
		scoreInt += amount;
	}
	
	static public int theScore()
	{
		return scoreInt;
	}
	
	
	// Update is called once per frame
	void Update () {
		score.text = "score: " + scoreInt;
	}
}

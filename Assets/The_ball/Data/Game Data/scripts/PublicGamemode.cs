using UnityEngine;
using System.Collections;

public class PublicGamemode : MonoBehaviour {

	static public string gameMode;
	static public float averageSpawn;
	
	public static float averagePractice;
	public static float averageEasy;
	public static float averageMedium;
	public static float averageHard;
	public static float averageInsane;
	
	static public bool canPlayMusic;
	static public bool canPlaySound;

	public AudioClip sndSelect;
	public AudioClip sndGame;
	
	public void playSelect()
	{
		if (PublicGamemode.canPlaySound)
		{
			GetComponent<AudioSource>().PlayOneShot(sndSelect,1);
		}
	}
	public void playGame()
	{
		if (PublicGamemode.canPlaySound)
		{
			GetComponent<AudioSource>().PlayOneShot(sndGame,1);
		}
	}
	

	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad(gameObject);
		
	}
	
	// Update is called once per frame
	void Update () {
//		print (PublicGamemode.gameMode);
		if(gameMode == "practice")
		{
			averageSpawn = averagePractice;
		}
		
		if(gameMode == "easy")
		{
			averageSpawn = averageEasy;
		}
		
		if(gameMode == "medium")
		{
			averageSpawn = averageMedium;
		}
		
		if(gameMode == "hard")
		{
			averageSpawn = averageHard;
		}
		
		if(gameMode == "insane")
		{
			averageSpawn = averageInsane;
		} 
		
//-------------------------------------------		
		
		
	}
}



























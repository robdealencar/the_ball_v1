using UnityEngine;
using System.Collections;

public class load : MonoBehaviour {

	public AudioClip sndSelection;
	public AudioClip sndGame;
	
	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void playSelection()
	{
		GetComponent<AudioSource>().PlayOneShot(sndSelection,1f);
	}
	
	public void playGame()
	{
		GetComponent<AudioSource>().PlayOneShot(sndGame,1f);
	}
	
	public void loadLevel(string level)
	{
		Application.LoadLevel("Game");
		PublicGamemode.gameMode = level.ToString();
//		print (level);
//		print(PublicGamemode.gameMode);
	}
}

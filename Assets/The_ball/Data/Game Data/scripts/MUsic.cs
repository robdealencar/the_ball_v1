using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MUsic : MonoBehaviour {
	public Toggle music;
	static public bool playMusic;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (music.isOn == true)
		{
			playMusic = false;
		}
		else if (music.isOn == false)
		{
			playMusic = true;
		}
	}
}

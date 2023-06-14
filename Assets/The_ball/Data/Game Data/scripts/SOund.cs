using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SOund : MonoBehaviour {

	public Toggle sound;
	static public bool playSound;

	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if (sound.isOn == true)
		{
			PublicGamemode.canPlaySound = false;
		}
		else if (sound.isOn == false)
		{
			PublicGamemode.canPlaySound = true;
		}
	}
}

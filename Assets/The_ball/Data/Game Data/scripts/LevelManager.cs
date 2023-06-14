using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name) {
		Debug.Log("New Level Load: " + name);
		Application.LoadLevel(name);
	}
	
	public void Quit(string name) {
		Debug.Log("" + name + " Requested");
		Application.Quit();
	}
}

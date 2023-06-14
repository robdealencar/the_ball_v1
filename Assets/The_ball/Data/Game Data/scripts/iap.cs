using UnityEngine;
using System.Collections;

public class iap : MonoBehaviour {

	public static bool proEnabled = true;

	// Use this for initialization
	void Start () {
		//PlayerPrefs.GetString("hasPro", "false");
	}
	
	// Update is called once per frame
	void Update () {
		proEnabled = true;	
	}
}

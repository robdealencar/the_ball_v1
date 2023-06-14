using UnityEngine;
using System.Collections;

public class player_change : MonoBehaviour {


	
	// Use this for initialization
	void Start () {
		if(_GameEditor._player == null)
		{}
		else
		{
			GetComponent<SpriteRenderer>().sprite = _GameEditor._player;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

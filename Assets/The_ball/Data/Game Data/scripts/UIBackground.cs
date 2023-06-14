using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIBackground : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(_GameEditor._titleBackGround == null)
		{}
		else
		{
			GetComponent<SpriteRenderer>().sprite = _GameEditor._titleBackGround;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

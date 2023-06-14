using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class editor_instructions : MonoBehaviour {

	public Text txt;
	// Use this for initialization
	void Start () {
		txt = GetComponent<Text>();
		txt.text = _GameEditor._gameInstructions;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

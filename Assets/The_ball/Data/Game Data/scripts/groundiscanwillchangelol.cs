using UnityEngine;
using System.Collections;

public class groundiscanwillchangelol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(_GameEditor._ground == null)
		{}
		else
		{
			GetComponent<SpriteRenderer>().sprite = _GameEditor._ground;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

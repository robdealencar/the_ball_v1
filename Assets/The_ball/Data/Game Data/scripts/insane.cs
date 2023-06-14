using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class insane : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(iap.proEnabled == true)
		{
			text.color = Color.black;
//			print (iap.proEnabled);
		}
		else if(iap.proEnabled == false)
		{
			text.color = Color.gray;
			print (iap.proEnabled);
		}
	}
}

using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class practiceBack : MonoBehaviour {

	public RectTransform rect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(PublicGamemode.gameMode == "practice")
		{
			rect.localScale = new Vector3( 1.184142f, 1.184142f,1.184142f);
			move.godMode = true;
		}
		else
		{
			rect.localScale = new Vector3( 0, 0,0);
			move.godMode = false;
		}
	}
}

using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public RectTransform go;
	
	// Use this for initialization
	void Start () {
		
	}
	
	IEnumerator GUIon()
	{
		
		
		for(float i = 0; i<=1; i += Time.deltaTime)
		{
			
			go.localScale = new Vector3( 1*i, 1,1);
			yield return null;
		}
		yield return null;
	}
	// Update is called once per frame
	void Update () {
		if(changeBest.showGameOver)
		{
			StartCoroutine("GUIon");
			changeBest.showGameOver = false;
		}
	}
}

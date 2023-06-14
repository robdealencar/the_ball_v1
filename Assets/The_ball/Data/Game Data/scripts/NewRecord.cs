using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NewRecord : MonoBehaviour {

	public RectTransform nr;

	// Use this for initialization
	void Start () {
	
	}
	
	IEnumerator GUIon()
	{
		
		
		for(float i = 0; i<=1; i += Time.deltaTime)
		{
			
			nr.localScale = new Vector3( 1*i, 1,1);
			yield return null;
		}
		yield return null;
	}
	// Update is called once per frame
	void Update () {
		if(changeBest.showNewRecord)
		{
			StartCoroutine("GUIon");
			changeBest.showNewRecord = false;
		}
	}
	
	
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class _newTransition : MonoBehaviour {
	public RectTransform rectTransform;
	float waitTime = .25f;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	IEnumerator removeI()
	{
		
		for(float i = waitTime; i>=0; i -= Time.deltaTime)
		{
			
			rectTransform.localScale = new Vector3( 1*i/waitTime, 1,1);
			yield return null;
		}
		rectTransform.localScale = new Vector3( 0, 1,1);
	}
	
	IEnumerator bringI()
	{
		yield return new WaitForSeconds(waitTime);
		for(float i = 0; i<=waitTime; i += Time.deltaTime)
		{
			
			rectTransform.localScale = new Vector3( 1*i/waitTime, 1,1);
			yield return null;
		}
		rectTransform.localScale = new Vector3( 1, 1,1);
	}
	
	public void remove()
	{
		//rectTransform.localScale = new Vector3(0,0,0);
		StartCoroutine("removeI");
		
	}
	
	public void bringBack()
	{
		//rectTransform.localScale = new Vector3(1,1,1);
		StartCoroutine("bringI");
	}
}






















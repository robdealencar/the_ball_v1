using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TurnDifOn : MonoBehaviour {

	public Text tt;
	public Button bb;
	public Image ii;
	

	// Use this for initialization
	void Start () {
		tt.CrossFadeAlpha(0,0,false);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public IEnumerator turnUp()
	{
		yield return new WaitForSeconds(.55f);
		ii.enabled = true;
		bb.enabled = true;
		tt.enabled = true;
		tt.CrossFadeAlpha(1,.5f, false);
		yield return null;
	}
	
	public void turnOff()
	{
		print("off");
		ii.enabled = false;
		bb.enabled = false;
		//tt.enabled = false;
		tt.CrossFadeAlpha(0,.5f, false);
	}
	
	public void turnOn()
	{
		
		StartCoroutine("turnUp");
	}
}

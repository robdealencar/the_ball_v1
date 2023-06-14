using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class guiFade : MonoBehaviour {

	public Image i;
	public Button b;
	public Text t;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void fadeOut()
	{
		b.enabled = false;
		i.enabled = false;
		t.CrossFadeAlpha(0,.5f, false);
	}
	
	public void fadeInt()
	{
		b.enabled = true;
		i.enabled = true;
		t.CrossFadeAlpha(1,.5f, false);
	}
	
}

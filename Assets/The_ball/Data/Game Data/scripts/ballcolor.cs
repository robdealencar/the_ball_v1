using UnityEngine;
using System.Collections;

public class ballcolor : MonoBehaviour {

	public string thecolor;
	
	// Use this for initialization
	void Start () {
	
		if(thecolor == "red")
		{
			if(_GameEditor._enemyBall == null)
			{}
			else
			{
				GetComponent<SpriteRenderer>().sprite = _GameEditor._enemyBall;
			}
		}
		else if(thecolor == "orange")
		{
			if(_GameEditor.__10pointBall == null)
			{}
			else
			{
				GetComponent<SpriteRenderer>().sprite = _GameEditor.__10pointBall;
			}
		}
		else if(thecolor == "green")
		{
			if(_GameEditor.__25pointBall == null)
			{}
			else
			{
				GetComponent<SpriteRenderer>().sprite = _GameEditor.__25pointBall;
			}
		}
		else if(thecolor == "blue")
		{
			if(_GameEditor._shieldBall == null)
			{}
			else
			{
				GetComponent<SpriteRenderer>().sprite = _GameEditor._shieldBall;
			}
		}
		else if(thecolor == "nuke")
		{
			if(_GameEditor._nukeBall == null)
			{}
			else
			{
				GetComponent<SpriteRenderer>().sprite = _GameEditor._nukeBall;
			}
		}
		else if(thecolor == "yellow")
		{
			if(_GameEditor.__5pointBall == null)
			{}
			else
			{
				GetComponent<SpriteRenderer>().sprite = _GameEditor.__5pointBall;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

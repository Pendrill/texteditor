using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tapptext : MonoBehaviour {
	public Text mytext;

	int numbertap;


	// Use this for initialization
	void Start () {
		numbertap = 0;
		
	
	}
	
	// Update is called once per frame
	void Update () {
		mytext.text = "be tappin "+numbertap;
		if (Input.GetKeyDown (KeyCode.Space)) {
			numbertap++;
			
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			numbertap+=1000;

		}
	
	}
}

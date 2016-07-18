using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class endhint : MonoBehaviour {
	Collider2D box;
	public bool zoom;
	public GameObject player;
	Collider2D playerbox;
	public Text UItext;
	public string hint;

	// Use this for initialization
	void Start () {
		box = GetComponent<Collider2D> ();
		playerbox = player.GetComponent<Collider2D> ();


	}

	// Update is called once per frame
	void Update () {
		if (playerbox.IsTouching (box)) {
			UItext.text = " ";
		}


	}
	void OnTriggerEnter(Collider2D other){
		UItext.text = hint;

	}
	void OnTriggerExit(Collider2D other){
		UItext.text = " ";

	}
}

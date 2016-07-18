using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class hints : MonoBehaviour {
	Collider2D box;
	public GameObject dest;
	public bool killblock;
	public bool zoom;
	public GameObject player;
	Collider2D playerbox;
	public Text UItext;
	public string hint;


	public string changetext;


	// Use this for initialization
	void Start () {
		box = GetComponent<Collider2D> ();
		playerbox = player.GetComponent<Collider2D> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		if (playerbox.IsTouching (box)) {
			UItext.text = hint;
			if (killblock = true) {
				Destroy (dest);
			}
		}

		
	}

}

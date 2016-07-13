using UnityEngine;
using System.Collections;

public class movetheplayer : MonoBehaviour {
	SpriteRenderer player;

	// Use this for initialization
	void Start () {
		player = GetComponent<SpriteRenderer>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)){
			transform.position+=Vector3.left;
		}
		if(Input.GetKey(KeyCode.D)){
			transform.position+=Vector3.right;
		}
		if(Input.GetKey(KeyCode.W)){
			transform.position+=Vector3.up;
		}
		if(Input.GetKey(KeyCode.S)){
			transform.position+=Vector3.down;
		}
	}
}

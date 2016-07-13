using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HelloWorld : MonoBehaviour {
	public Text mytextobject;

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello World");
		mytextobject.text = "vanakam";
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Hello Worlds");
	}
}

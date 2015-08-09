using UnityEngine;
using System.Collections;

public class Movetext : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate.y*s;
		transform.Translate(0, 0.01f*speed, 0);
	}
}

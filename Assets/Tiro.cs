using UnityEngine;
using System.Collections;

public class Tiro : MonoBehaviour {

	public Rigidbody RBTiro;	
	public float v;

	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, v * Time.deltaTime);
		Destroy (gameObject,2);
	}
}

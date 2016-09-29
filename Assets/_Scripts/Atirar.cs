using UnityEngine;
using System.Collections;

public class Atirar : MonoBehaviour {
	public GameObject bala;
	public Transform posicaoBala;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.T))
			Instantiate (bala, posicaoBala.position, posicaoBala.rotation );
	}
}

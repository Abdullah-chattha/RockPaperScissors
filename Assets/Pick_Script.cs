using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//
//used to change pick of player
//

public class Pick_Script : MonoBehaviour {

	public Material[] material;
	Renderer ren;
	public int matElement = 1;

	//methods
	// Use this for updating
	void Start () {
		ren = GetComponent<Renderer>();
		ren.enabled = true;
		ren.sharedMaterial = material[matElement];
	}
	//used to change frames
	// Update is called once per frame
	void Update()
	{
		ren.sharedMaterial = material[matElement];
	}
}

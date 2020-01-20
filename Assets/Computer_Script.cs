using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//
//used to change pick of computer
//
public class Computer_Script : MonoBehaviour {

	public Material[] material;
	Renderer render;
	public int matElement = 1;
	//methods
	// Use this for updating
	void Start()
	{
		render = GetComponent<Renderer>();
		render.enabled = true;
		render.sharedMaterial = material[matElement];
	}

	// Update is called once per frame
	void Update()
	{
		render.sharedMaterial = material[matElement];
	}
}

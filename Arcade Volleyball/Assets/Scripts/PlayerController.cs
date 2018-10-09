
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This code will be used to control the behavior of the player objects, based on the tags used to denote them.
// Several values will be called upon to give them different inputs and outputs.  
public class PlayerController : MonoBehaviour {
	
	// Basic Storage Values
	public float speed = 3;
	private Rigidbody2D rb;
	private int count;
	public int countMax = 5;
	
	// Stores the UI Values that determine the text
	public Text countText;
	public Text winText; 

	public bool WinState = false;
	
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		count = 0;
		setCountText();
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		rb.AddForce(movement * speed);
		
	}
	
	// This code will be used to make the player's jump
	
	// These are two void methods for managing the Text output for the UI
	void setCountText()
	{
		countText.text = count.ToString();		
		
		if (countMax - count <= 5)
		{
			countText.color = new Color(0, 0, 55f);
		}
		if (count >= countMax)
		{
			winText.text = name + " wins! /n Press Space to Play Again";
			WinState = true;
		}
		
	}	
}

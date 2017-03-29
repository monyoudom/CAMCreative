using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.Text.RegularExpressions;

public class Signup : MonoBehaviour {
	public GameObject email;
	public GameObject username;
	public GameObject password;
	public GameObject comfirepassword;
	private string Email;
	private string Username;
	private string Password;
	private string Comfirepassword;
	private string form;
	private bool Emailvalid =false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Email = email.GetComponent<InputField>().text;
		Username = username.GetComponent<InputField>().text;
		Password = password.GetComponent<InputField>().text;
		Comfirepassword = comfirepassword.GetComponent<InputField>().text;
		Debug.Log(Email);

		  
		
	}
}

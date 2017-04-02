using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Homepage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void GoNextScene ()
	{
		SceneManager.LoadScene ("TestMission");
	}
	public void GoBackScene ()
	{
		SceneManager.LoadScene ("Homepage");
	}
}

﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Facebook.Unity;
using UnityEngine.SceneManagement;

public class FBscript : MonoBehaviour {
	 void Awake()
    {
        FB.Init (SetInit, OnHideUnity);
    }

    void SetInit()
    {

        if (FB.IsLoggedIn) {
            Debug.Log ("FB is logged in");
        } else {
            Debug.Log ("FB is not logged in");
        }

       

    }

    void OnHideUnity(bool isGameShown)
    {

        if (!isGameShown) {
            Time.timeScale = 0;
        } else {
            Time.timeScale = 1;
        }

    }

    public void FBlogin()
    {

        List<string> permissions = new List<string> ();
        permissions.Add ("public_profile");

        FB.LogInWithReadPermissions (permissions, AuthCallBack);
    }

    void AuthCallBack(IResult result)
    {

        if (result.Error != null) {
            Debug.Log (result.Error);
        } else {
            if (FB.IsLoggedIn) {
               SceneManager.LoadScene ("Homepage");
            } else {
                Debug.Log ("FB is not logged in");
            }

            
        }

    }

	
}

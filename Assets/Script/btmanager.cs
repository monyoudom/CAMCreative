using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class btmanager : MonoBehaviour {
	public void newGamebt(string newGamel1){
		SceneManager.LoadScene (newGamel1);
	}
		

}

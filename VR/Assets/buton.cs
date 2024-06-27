using UnityEngine;
using System.Collections;

public class buton : MonoBehaviour {

	// Use this for initialization
	public void click(int s){
		UnityEngine.SceneManagement.SceneManager.LoadScene (s);
	
	}

}

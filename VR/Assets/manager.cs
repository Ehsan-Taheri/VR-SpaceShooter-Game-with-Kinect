using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class manager : MonoBehaviour {
	bool inpipe;
	bool hrzpipe;
	bool firs,last;
	GameObject pip,objectt;
	// Use this for initialization
	void Start () {
		objectt=GameObject.Find ("Object");
	}

	// Update is called once per frame
	void Update () {
		if (pip != null) {
			if (inpipe)
				this.transform.position = new Vector3 (pip.transform.position.x, transform.position.y, pip.transform.position.z);
			else if (hrzpipe)  
				
				this.transform.position = new Vector3 (transform.position.x, pip.transform.position.y, pip.transform.position.z);
			 		
		}
		if (last) {
			inpipe = false;
			hrzpipe = false;
			Destroy (pip);
			pip = null;
			this.GetComponent<Renderer> ().material.color = Color.blue;
			last = false;
		}
		if (objectt.transform.childCount == 0) {
			print ("WIIIIIIIIIIN");
			SceneManager.LoadScene (0);
		}
			if (Input.GetKeyDown (KeyCode.R))
			SceneManager.LoadScene (0);
	}
	 
	void OnTriggerEnter(Collider c){

		if (c.tag == "Finish") {
			this.GetComponent<Renderer> ().material.color = Color.green;

			pip = c.gameObject;
			inpipe = true;
			 
		 }
		else if (c.tag == "r") {
			this.GetComponent<Renderer> ().material.color = Color.green;

			pip = c.gameObject;
	 

		}
		else	if (c.tag == "hrz") {
		
			this.GetComponent<Renderer> ().material.color = Color.green;
		 
			pip = c.gameObject;
			hrzpipe = true;
			 
		}
		else	if (c.tag == "first") {
			firs = true;
			print ("varedshod");
		}
		else	if (c.tag == "last" && firs) {
			last = true;

			print ("kharej shod");
		}
	}
	 
}

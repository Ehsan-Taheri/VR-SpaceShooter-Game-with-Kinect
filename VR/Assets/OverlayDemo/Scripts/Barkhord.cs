using UnityEngine;
using System.Collections;

public class Barkhord : MonoBehaviour {
	public	GameObject a;
	bool isup;
	public GameObject Maincam;
	 
	void Start(){
		a.transform.position = new Vector3 (0,0, 5.6f);
	}
	// Use this for initialization
	void  OnTriggerEnter (Collider c) {
		if (c.tag == "Player") {
			a.GetComponent<Animation> ().Play ();	
			isup = true;
			Maincam.	GetComponent<KinectOverlayer> ().enabled = false;
		}
	}

	void Update () {
		if(isup)
			a.transform.Translate (new Vector3 (0, 2.5f * Time.deltaTime, -1*Time.deltaTime));
	}
}

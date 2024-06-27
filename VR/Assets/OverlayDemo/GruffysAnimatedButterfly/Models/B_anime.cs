using UnityEngine;
using System.Collections;

public class B_anime : MonoBehaviour {
	public	GameObject a;
	bool isup;
	// Use this for initialization
	void Start () {
		 


	}
	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			a.GetComponent<Animation> ().Play ();	
			isup = true;
		}
	}
	// Update is called once per frame
	void Update () {
		if(isup)
		a.transform.Translate (new Vector3 (0, 7 * Time.deltaTime, 0));
	}
}

using UnityEngine;
using System.Collections;

public class box : MonoBehaviour {
	bool onehand,twohand,inpalet;

	public GameObject BOX,palet ;
	public GameObject[] b;
	public GameObject place;
	// Use this for initialization
	void Start () {
 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R))
			UnityEngine.SceneManagement.SceneManager.LoadScene (1);
	}

	void OnTriggerEnter(Collider c){
		if (c.tag == "box") {
			
			if (!onehand) {
				onehand = true;
				 
				print ("1hnad");
			} else if (onehand) {
				if (!inpalet&& c.transform.childCount==0) {
					twohand = true;
					this.transform.parent = c.transform;
					print ("2hand");
					 
				}
			}
		}
		if (c.tag == "palet") {
			
			Invoke ("pal", 0.5f); 
			 
	}

	}
	void pal(){
		print ("Palet");
		inpalet = true;
		GetComponent<Rigidbody> ().constraints &= ~RigidbodyConstraints.FreezePositionY;
		GetComponent<box> ().enabled = false;
		this.transform.parent = palet.transform;
		GetComponent<MeshCollider> ().isTrigger = true;
		GetComponent<Rigidbody> ().useGravity = false;
	}
		void OnTriggerExit(Collider c){
			if (c.tag == "box") {
			if (!twohand) {
				print ("1hand_off");
				onehand = false;
			}
			else if ( twohand)
				if (!inpalet){
				twohand = false;
				onehand = false;
				print ("2hand_off");
				transform.position = place.transform.position;
			 	this.transform.parent = BOX.transform;
				GetComponent<MeshCollider> ().isTrigger = false;
			}
                

	}
}
}
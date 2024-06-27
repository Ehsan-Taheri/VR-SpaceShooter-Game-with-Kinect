using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Spawn : MonoBehaviour {
	public	float eachtime = 4f;
	public int firstlevel = 20;
	public int nextlevel=20;
	float next;
	public Text point_txt;
	int Point = 0;
	public	GameObject snow;
	public GameObject obj;

	// Use this for initialization
	void Start(){
		point_txt.text = "Point : 0";

	}
	void Update()
	{
		if (Time.time>next) {
			print("instant");
			next= Time.time+eachtime;
			obj	=Instantiate (snow, new Vector3 (Random.Range (-4.5f, 4.5f), 10, 5), new Quaternion(0,0,0,0)) as  GameObject;
			obj.GetComponent<Rigidbody> ().AddTorque (0, 0, 0.01f);	
			DestroyObject (obj, 8f);
		
		}	 
		 
			
		if (Input.GetKey (KeyCode.R))
			SceneManager.LoadScene (0);


	}
	void OnTriggerEnter(Collider obj){
		if (obj.tag == "Player") {
			GetComponent<AudioSource> ().Play ();
			obj.gameObject.SetActive (false);
			Point += 1;
			point_txt.text ="Point :"+ Point.ToString ();
			if (Point >= nextlevel) {
				firstlevel += nextlevel;
				if (eachtime > 1)
					eachtime--;
			}
				
		}
	}
}
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DropDown_script : MonoBehaviour {
	 
	 
	public void valuechange(GameObject maincam){
		if (this.GetComponent<Dropdown> ().captionText.text == "Left Hand")
			maincam.GetComponent<KinectOverlayer> ().TrackedJoint = KinectWrapper.NuiSkeletonPositionIndex.HandLeft;

		if (this.GetComponent<Dropdown> ().captionText.text == "Right Hand")
			maincam.GetComponent<KinectOverlayer> ().TrackedJoint = KinectWrapper.NuiSkeletonPositionIndex.HandRight;
		
	}

}

using UnityEngine;
using System.Collections;

public class AllMarkerController : MonoBehaviour {

	public GameObject hidden = new GameObject ();	
	public GameObject willBeShown = new GameObject(); 		
	public GameObject willBeHidden = new GameObject();
	public GameObject nextMarkerButton = new GameObject ();
	// Use this for initialization
	void Start () {
		hidden.SetActive (false);
		willBeShown.SetActive (false);
		willBeHidden.SetActive (true);
		nextMarkerButton.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUpAsButton()
	{
		//Debug.Break ();
		//hidden.SetActive (true);
		willBeHidden.SetActive (false);
		willBeShown.SetActive (true);
		nextMarkerButton.SetActive (true);
	}

}


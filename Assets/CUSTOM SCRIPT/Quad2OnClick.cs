using UnityEngine;
using System.Collections;

public class Quad2OnClick: MonoBehaviour {

	public GameObject hidden1;	
	public GameObject hidden2;	
	public GameObject willBeShown; 		
	public GameObject willBeHidden;
	public GameObject nextMarkerButton;
	// Use this for initialization
	void Start () {
		hidden1.SetActive (false);
		hidden2.SetActive (false);
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


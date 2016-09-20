using UnityEngine;
using System.Collections;

public class Quad4OnClick : MonoBehaviour {

	public GameObject hidden;	
	public GameObject willBeShown; 	
	public GameObject willBeShown2; 	
	public GameObject willBeHidden;
	public GameObject nextMarkerButton;
	// Use this for initialization
	void Start () {
		hidden.SetActive (false);
		willBeShown.SetActive (false);
		willBeShown2.SetActive (false);
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
		willBeShown2.SetActive (true);
		nextMarkerButton.SetActive (true);
	}

}


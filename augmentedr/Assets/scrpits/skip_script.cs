using UnityEngine;
using System.Collections;

public class skip_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	  public void skiptolast()
     {
         Application.LoadLevel("markerlist");
     }

	  public void markerclick()
     {
         Application.LoadLevel("");
     }
	 public void markerlessclick()
     {
         Application.LoadLevel("list");
     }
}

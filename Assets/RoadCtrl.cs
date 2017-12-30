using UnityEngine;
using System.Collections;

public class RoadCtrl : MonoBehaviour {

    private Vector2 offset;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        offset.y -= 2f * Time.deltaTime;
        this.GetComponent<Renderer>().material.mainTextureOffset = offset;
        if(offset.y <= -1)
        {
            offset.y = 0;
        }
	}
}

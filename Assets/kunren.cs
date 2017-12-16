using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kunren : MonoBehaviour {

    // Use this for initialization
    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="box")
            GetComponent<TextMesh>().text = "地面が割れていて通れません";
        if (other.gameObject.name == "dentyu")
            GetComponent<TextMesh>().text = "電柱が倒れているので通れません";
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name =="box"|| other.gameObject.name == "dentyu")
            GetComponent<TextMesh>().text = "null";
    }
}

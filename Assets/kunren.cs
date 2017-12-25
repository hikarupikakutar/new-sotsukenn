using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kunren : MonoBehaviour {
    public static bool enter=false;

    // Use this for initialization
    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "box")
        {
            enter = true;
            GetComponent<TextMesh>().text = "地面が割れていて通れません";
        }
        if (other.gameObject.name == "dentyu")
        {
            enter = true;
            GetComponent<TextMesh>().text = "電柱が倒れているので通れません";
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name =="box"|| other.gameObject.name == "dentyu") {
            GetComponent<TextMesh>().text = "null";
            enter = false;
        }
            
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace S3{
	public class coincollect : MonoBehaviour
	{
	    // Start is called before the first frame update
	    void OnTriggerEnter(Collider other){
	    	if(other.gameObject.CompareTag("child")){
	    		this.gameObject.SetActive(false);
	    		//other.gameObject.count=other.gameObject.count+1;
	    		//other.gameObject.SetCountText();
	    	}

	    }
	}
}

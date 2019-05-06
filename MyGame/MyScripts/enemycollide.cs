using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace S3{
	public class enemycollide : MonoBehaviour
	{
	    // Start is called before the first frame update
	    void OnTriggerEnter(Collider other){
	    	if(other.gameObject.CompareTag("castlemain")){
	    		this.gameObject.SetActive(false);
	    		Destroy(this.gameObject);
	    		//other.gameObject.count=other.gameObject.count+1;
	    		//other.gameObject.SetCountText();
	    	}

	    }
	}
}

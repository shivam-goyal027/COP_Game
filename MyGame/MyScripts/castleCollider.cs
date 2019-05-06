using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S3{
public class castleCollider : MonoBehaviour
{
   void OnCollisionEnter(Collision collision)
	    {
	    	GameObject hit = collision.gameObject;
	    	
	    	if(collision.gameObject.tag=="enemies"){
	    		Debug.Log("Collision Detected");
	        	Destroy(collision.gameObject);
	    	}
	    }
	}
}	

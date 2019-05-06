using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

namespace S3{
	public class Bullet : NetworkBehaviour
	{

		// public Health h;
		
		//public PlayerController pc;
		// void Start(){
	 //  		//pc.countb=0;
	 //  		//SetCountText();
	 //  	}

	  	/*void OnTriggerEnter(Collider other){
	    	if(other.gameObject.CompareTag("enemies")){
	    		other.gameObject.SetActive(false);
	    		count=count+1;
	    		SetCountText();
	    	}

	    }*/
	    // Update is called once per frame
	    void OnCollisionEnter(Collision collision)
	    {
	    	GameObject hit = collision.gameObject;
	    	//Health health = hit.GetComponent<Health>();
	    	//if(health!=null){
	    	//	health.TakeDamage(10);
	    	//}
	    	if(hit.CompareTag("enemies")){
		        Destroy(hit);
		        // h.countenemies++;
		         //countb=countb+1;
		        // SetCountText();

		    }
		}
		// void SetCountText(){
	 //    	pc.enemykill1.text="KILLS:"+ pc.countb.ToString();
	 //    	pc.enemykill1.text="KILLS:"+ pc.countb.ToString();
	 //    	pc.enemykill1.text="KILLS:"+ pc.countb.ToString();
	    
	 //    }
	     


	    	}
	    }
	

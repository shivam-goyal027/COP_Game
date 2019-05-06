using System.Collections;
using UnityEngine;

namespace S3{
	public class Bullet : MonoBehaviour
	{

		// public Health h;
		 //public Text enemykills;
		 //public int counts=0;

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
		         // counts++;
		         // SetCountsText();

		    }
		}
	     // void SetCountsText(){
	     // 	enemykills.text="Coins:"+ counts.ToString();
	     // }


	    	}
	    }
	

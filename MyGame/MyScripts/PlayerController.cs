using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

namespace S3{
	public class PlayerController:NetworkBehaviour
	{
		public GameObject bulletPrefab;
		public Transform bulletSpawn;
	  	
	    // Update is called once per frame
	    void Update()
	    {
	    	if(!isLocalPlayer){
	    		return;
	    	}

	  		float x=Input.GetAxis("Horizontal")*Time.deltaTime*150.0f;
	  		float z=Input.GetAxis("Vertical")*Time.deltaTime*10.0f;    

	  		transform.Rotate(0,x,0);
	  		transform.Translate(0,0,z);

	  		if(Input.GetKeyDown(KeyCode.Space)){
	  			Fire();
	  		}
	    }

	    void Fire(){
	    	//create  the bullet from prefab
	    	GameObject bullet = (GameObject)Instantiate(bulletPrefab,bulletSpawn.position,bulletSpawn.rotation);
	    	//velocity of bullet
	    	bullet.GetComponent<Rigidbody>().velocity=bullet.transform.forward*17.0f;
	    	//destroy bullet in 20 sec
	    	Destroy(bullet,20);

	    }
	}
}

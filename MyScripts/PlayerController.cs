using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

namespace S3{
	public class PlayerController:NetworkBehaviour
	{
		public GameObject bulletPrefab;
		public Transform bulletSpawn;
		public Text countText;
		private int count;
	  	
	  	void Start(){
	  		count=0;
	  		SetCountText();
	  	}
	    // Update is called once per frame
	    void Update()
	    {
	    	if(!isLocalPlayer){
	    		return;
	    	}
	    	float v1=0.0f;
	    	if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)){
	    		v1=15.0f;
	    	}
	    	else{ 
	    		if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.RightShift)){
	    			v1=30.0f;
	    		}
	    	}
	  		float x=Input.GetAxis("Horizontal")*Time.deltaTime*150.0f;
	  		float z=Input.GetAxis("Vertical")*Time.deltaTime*v1;    

	  		transform.Rotate(0,x,0);
	  		transform.Translate(0,0,z);

	  		if(Input.GetKeyDown(KeyCode.Space)){
	  			CmdFire();
	  		}
	    }
	    void OnTriggerEnter(Collider other){
	    	if(other.gameObject.CompareTag("Pick Up")){
	    		other.gameObject.SetActive(false);
	    		count=count+1;
	    		SetCountText();
	    	}

	    }
	    void SetCountText(){
	    	countText.text="Coins:"+ count.ToString();
	    }
	    [Command]
	    void CmdFire(){
	    	//create  the bullet from prefab
	    	GameObject bullet = (GameObject)Instantiate(bulletPrefab,bulletSpawn.position,bulletSpawn.rotation);
	    	//velocity of bullet
	    	bullet.GetComponent<Rigidbody>().velocity=bullet.transform.forward*40.0f;
	    	//spawn bullet
	    	NetworkServer.Spawn(bullet);

	    	//destroy bullet in 10 sec
	    	Destroy(bullet,10);

	    }
	}
}

using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

namespace S3{
	public class Health : NetworkBehaviour
	{

		//float maxHealth = 100.0f;
		public float coef = 0.2f; //change later
		[SyncVar]public float currentHealth=100.0f;
		public RectTransform healthbar;
		public EnemySpawner e;
		public int countenemies=5;
	
		void Update(){

			/*if(!isServer){
				return;
			}*/
		    healthbar.sizeDelta = new Vector2(currentHealth*2,healthbar.sizeDelta.y);
			currentHealth -= (((e.numberofEnemies)-countenemies)/e.numberofEnemies)*coef*Time.deltaTime*5;
			if(currentHealth<=0){
	        	currentHealth=100.0f;
	        	/*RpcRespawn();*/
	        	Debug.Log("Dead");
	        	Destroy (GameObject.FindWithTag("child"));
	        }
		}

		/*[ClientRpc]
		void RpcRespawn(){
			if(isLocalPlayer){
				transform.position = Vector3.zero;
			}
		}*/
	}
}
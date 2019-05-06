using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

namespace S3{
	public class CoinSpawner:NetworkBehaviour{
		public GameObject coinPrefab;
		public int numberofCoins;
		private int number;

		public override void OnStartServer(){
			for(int i=0;i<numberofCoins;i++){
				number=0;
				Vector3 spawnPosition=new Vector3(Random.Range(-260.0f,120.0f),8.0f,Random.Range(-90.0f,300.0f));
				while(Physics.OverlapSphere(spawnPosition,0.8f)!=null && number<100){
					spawnPosition=new Vector3(Random.Range(-260.0f,120.0f),8.0f,Random.Range(-90.0f,300.0f));
					number++;
				}
				Quaternion spawnRotation=Quaternion.Euler(0.0f,Random.Range(0.0f,180.0f),0.0f);
				GameObject coin=(GameObject)Instantiate(coinPrefab,spawnPosition,spawnRotation);
				NetworkServer.Spawn(coin);				
			}
		}
	}
}
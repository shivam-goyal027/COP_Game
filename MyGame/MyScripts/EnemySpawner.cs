using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

namespace S3{
	public class EnemySpawner:NetworkBehaviour{
		public GameObject enemyPrefab;
		public int numberofEnemies;

		public override void OnStartServer(){
			for(int i=0;i<numberofEnemies;i++){
				Vector3 spawnPosition=new Vector3(Random.Range(-80.0f,80.0f),0.0f,Random.Range(-80.0f,80.0f));
				Quaternion spawnRotation=Quaternion.Euler(0.0f,Random.Range(0.0f,180.0f),0.0f);
				GameObject enemy=(GameObject)Instantiate(enemyPrefab,spawnPosition,spawnRotation);
				NetworkServer.Spawn(enemy);				
			}
		}
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicContinue : MonoBehaviour
{

	void Awake(){
		GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
		if(objs.Length>1){
			Destroy(gameObject);
		}
		//DontDestryOnLoad(this.gameObject);
	}
}

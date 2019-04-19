using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S3{
	public class Health : MonoBehaviour
	{
		public const int maxHealth = 100;
		public int currentHealth = maxHealth;
	    // Update is called once per frame
	    public void TakeDamage(int number)
	    {
	        currentHealth -= number;
	        if(currentHealth<=0){
	        	currentHealth=0;
	        	Debug.Log("Dead");
	        }
	    }
	}
}
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace S3{
	public class Health : MonoBehaviour
	{
		//float maxHealth = 100.0f;
		public float coef = 0.2f; //change later
		public float currentHealth=100.0f;
		public RectTransform healthbar;
	
		void Update(){
		    healthbar.sizeDelta = new Vector2(currentHealth*2,healthbar.sizeDelta.y);
			currentHealth -= coef*Time.deltaTime*5;
			if(currentHealth<=0){
	        	currentHealth=0.0f;
	        	Debug.Log("Dead");
	        }
		}
	}
}
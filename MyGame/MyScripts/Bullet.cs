using System.Collections;
using UnityEngine;

namespace S3{
	public class Bullet : MonoBehaviour
	{
	    // Update is called once per frame
	    void OnCollisionEnter()
	    {
	        Destroy(gameObject);
	    }
	}
}
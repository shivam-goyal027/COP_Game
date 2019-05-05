using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeControl : MonoBehaviour
{
	private Animator mAnimator;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool walkForward=Input.GetKey(KeyCode.W);
        bool walkBackward=Input.GetKey(KeyCode.S);

        mAnimator.SetBool("walkingForward",walkForward);
        mAnimator.SetBool("walkingBackward",walkBackward);
    }
}

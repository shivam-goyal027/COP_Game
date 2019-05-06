using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace S3{
    public class animatorforchildplayer : MonoBehaviour
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
            bool Run=Input.GetKey(KeyCode.RightShift);

            mAnimator.SetBool("walkingForward",walkForward);
            mAnimator.SetBool("walkingBackward",walkBackward);
            mAnimator.SetBool("Run",Run);

             if(Input.GetKeyDown(KeyCode.J)){
                mAnimator.SetTrigger("jump");
            }
        }
    }
}
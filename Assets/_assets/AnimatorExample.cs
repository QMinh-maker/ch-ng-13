using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorExample : MonoBehaviour
{
    public Animator myAnimator;
    void Start()
    {
        myAnimator.Play("AnimationStateName");
    }
}

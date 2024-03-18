using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelBoxInit : MonoBehaviour
{
    public Animator anim;
    int animLayer = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("playAnimation");
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlaying("Pixel_box_01_Armature"))
        {
            anim.SetTrigger("playAnimation");
        }
    }

    bool isPlaying(string stateName)
    {
        if (anim.GetCurrentAnimatorStateInfo(animLayer).IsName(stateName) &&
                anim.GetCurrentAnimatorStateInfo(animLayer).normalizedTime < 1.0f)
            return true;
        else
            return false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuList : MonoBehaviour
{
    public GameObject menuSlide;
  

    // Update is called once per frame
    public void ShowTittle()
    {
        if (menuSlide != null)
        {
            Animator anim = menuSlide.GetComponent<Animator>();
            if(anim != null)
            {
                bool isOpen = anim.GetBool("TransAbble");
                anim.SetBool("TransAbble", !isOpen);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class backColor : MonoBehaviour
{
    //public Sprite background;

  public void StartIMG()
    {
        Sprite FULLHP = Resources.Load<Sprite>("BLO");
       // background = GetComponent<Sprite>();
        gameObject.GetComponent<Image>().sprite = FULLHP;
    }

    public void StartIMG1()
    {
        Sprite FULLHP = Resources.Load<Sprite>("BLO1");
        // background = GetComponent<Sprite>();
        gameObject.GetComponent<Image>().sprite = FULLHP;
    }

    public void StartIMG2()
    {
        Sprite FULLHP = Resources.Load<Sprite>("BLO2");
        // background = GetComponent<Sprite>();
        gameObject.GetComponent<Image>().sprite = FULLHP;
    }

    public void StartIM3()
    {
        Sprite FULLHP = Resources.Load<Sprite>("BLO3");
        // background = GetComponent<Sprite>();
        gameObject.GetComponent<Image>().sprite = FULLHP;
    }
}

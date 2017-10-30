using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class final : MonoBehaviour
{
  
    public Text myText;
    
    void Start()
    {
        myText = GetComponentInChildren<Text>();
        myText.text = "";
        //yourButtonText = transform.Find("Text").GetComponent<Text>();
    }
    
    public void Enter()
    {
        //yourButtonText.color = red;
        myText.text = "here";
        Debug.Log("Mouse enter");

        //yourButtonText.text = "i am a button!";
    }
    public void Exit()
    {
        //yourButtonText.color = red;
        myText.text = "";
        Debug.Log("Mouse exit");

        //yourButtonText.text = "i am a button!";
    }
}


using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverText : MonoBehaviour {
     
    private GameObject childText = null; //  or make public and drag
    void OnGUI()
    {
        //GUI.Button(new Rect(10, 10, 100, 200), new GUIContent("Click me", "This is the tooltip"));
        //GUI.Label(new Rect(10, 40, 100, 40), GUI.tooltip);
    }
    void Start()
    {
        Text text = GetComponentInChildren<Text>();
        if (text != null)
        {
            childText = text.gameObject;
            childText.SetActive(false);
        }
    }

    public void onClick()
    {
        GUI.Button(new Rect(10, 10, 100, 200), new GUIContent("Click me", "This is the tooltip"));
        GUI.Label(new Rect(10, 40, 100, 40), GUI.tooltip);
        childText.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    { 
        {
            childText.SetActive(false);
        }
    }


}

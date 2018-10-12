using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class ButtonIsDown : MonoBehaviour {
    public GameObject player;
    public PlatformerMovement plyrMv;
    public int inDirection;
    public bool ispressed;

    // Use this for initialization

    private void Update()
    {
        if (ispressed)
        {
            plyrMv.MoveLeftorRight(inDirection);
            Debug.Log("Pressed");
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}

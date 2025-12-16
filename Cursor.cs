using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//будет eщё агa Bериm?&&??рпрплаергвпыргапfdshghbfsгщавпгаыпывghыварфыарлфыждбдфыавао
public class Cursor : MonoBehaviour
{
    Vector2 mousePosition;
    public Transform cameraPos;
    public Transform playerPos;

    // Update is called once per framе
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = mousePosition;
    }
}

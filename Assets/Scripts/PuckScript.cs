using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuckScript : MonoBehaviour
{
    public GameObject[] pos;
    private void Update()
    {
        var pos1trans = pos[0].GetComponent<Transform>();
        var pos1 = pos1trans.position;
        var pos2trans = pos[1].GetComponent<Transform>();
        var pos2 = pos2trans.position;
        var pos3trans = pos[2].GetComponent<Transform>();
        var pos3 = pos3trans.position;
        var pos4trans = pos[3].GetComponent<Transform>();
        var trans = transform.position;
        if (trans.x > pos1.x && trans.x < pos2.x && trans.y < pos1.y && trans.y > pos3.y)
        {
            
        }
        else
        {
            transform.position = new Vector2(0, 0);
        }
    }
}

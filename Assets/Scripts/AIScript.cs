using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AIScript : MonoBehaviour
{
    public GameObject puck;
    public GameObject[] pos;
    public Rigidbody2D rb;
    public float constantSpeed;
    public float behind;
    public GameObject _timer;
    private Transform _pos1Trans;
    private Transform _pos2Trans;
    private Transform _pos3Trans;
    private Transform _pos4Trans;
    private Transform _pos5Trans;
    private Transform _pos6Trans;

    private void Start()
    {
        _pos6Trans = pos[5].GetComponent<Transform>();
        _pos5Trans = pos[4].GetComponent<Transform>();
        _pos4Trans = pos[3].GetComponent<Transform>();
        _pos3Trans = pos[2].GetComponent<Transform>();
        _pos2Trans = pos[1].GetComponent<Transform>();
        _pos1Trans = pos[0].GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        var puckPos = puck.transform.position;
        var offset = new Vector3(-1, 0);
        var puckDirect = (puckPos - transform.position);
        var targetDirect = (puckDirect - offset).normalized;
        var pos1 = _pos1Trans.position;
        var pos2 = _pos2Trans.position;
        var pos3 = _pos3Trans.position;
        var pos4 = _pos4Trans.position;
        var pos5 = _pos5Trans.position;
        var pos6 = _pos6Trans.position;
        var timer = _timer.GetComponent<Timer>();
        if (puckPos.x > pos2.x && puckPos.x < pos3.x && puckPos.y > pos5.y && puckPos.y < pos2.y && timer.gameStart == true)
        {
            rb.velocity = targetDirect * constantSpeed;
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}

using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 mouse;
    public bool isONBoard;
    public GameObject[] pos;
    public GameObject _timer;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var trans = mouse;
        var pos1trans = pos[0].GetComponent<Transform>();
        var pos1 = pos1trans.position;
        var pos2trans = pos[1].GetComponent<Transform>();
        var pos2 = pos2trans.position;
        var pos3trans = pos[2].GetComponent<Transform>();
        var pos3 = pos3trans.position;
        var pos4trans = pos[3].GetComponent<Transform>();
        var pos4 = pos4trans.position;
        var pos5trans = pos[4].GetComponent<Transform>();
        var pos5 = pos5trans.position;
        var pos6trans = pos[5].GetComponent<Transform>();
        var pos6 = pos6trans.position;
        var timer = _timer.GetComponent<Timer>();

        if (trans.x > pos1.x && trans.x < pos2.x && trans.y > pos5.y && trans.y < pos1.y && timer.gameStart == true)
        {
            rb.MovePosition(mouse);
        }
    }
}
    
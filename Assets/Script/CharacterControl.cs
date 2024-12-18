using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float Speed = 1.0f;


    private void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        Vector2 Iti = GetComponent<Rigidbody2D>().velocity;
        if (Input.GetKey(KeyCode.W))
        {
            Iti.y += Speed/2;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Iti.x -= Speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Iti.y -= Speed/2;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Iti.x += Speed;
        }
        GetComponent<Rigidbody2D>().velocity = Iti;
    }
}

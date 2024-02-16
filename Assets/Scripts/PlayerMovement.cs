// holi jajsnjasasja
//La vida es una tombola
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;

    public KeyCode upkey = KeyCode.W;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upkey))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 1P : MonoBehaviour 
{
    public float speed = 8f;
    public float moveable = 5.5f;
    // Start is called before the first frame update
    // void Start()
    // {

    // }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -moveable, moveable), transform.position.y);
    }
}

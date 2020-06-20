using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tama : MonoBehaviour
{
    private Vector3 m_velocity;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += m_velocity;
    }
    public void Init(float angle, float speed)
    {
        var direction = Utils.GetDirection(angle);
        m_velocity = direction * speed;
        var angles = transform.localEulerAngles;
        angles.z = angle - 90;
        transform.localEulerAngles = angles;
        Destroy( gameObject, 2 );
    }
}

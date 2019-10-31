using UnityEngine;

public class P1 : MonoBehaviour
{
    public float m_speed;
    // Start is called before the first frame update
    private void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        var velocity = new Vector3(h, v) * m_speed;
        transform.localPosition += velocity;
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}

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
        transform.localPosition = Utils.ClampPosition( transform.localPosition);
    
        var screenPos = Camera.main.WorldToScreenPoint( transform.position );
        var direction = Input.mousePosition - screenPos;
        var angle = Utils.GetAngle( Vector3.zero,direction );
        var angles = transform.localEulerAngles;
        angles.z = angle - 90;
        transform.localEulerAngles = angles;
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}

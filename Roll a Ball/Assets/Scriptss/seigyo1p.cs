using UnityEngine;

public class seigyo1p : MonoBehaviour
{
    public float speed = 20;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
      var moveHorizontal = Input.GetAxis("Horizontal");
      var moveVertical = Input.GetAxis("Vertical");
      var movememt = new Vector3(moveHorizontal, 0, moveVertical);
      rb.AddForce(movememt * speed);
       
    }
}

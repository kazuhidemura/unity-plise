using UnityEngine;

public class seigyo1p : MonoBehaviour
{
    public int score;
    public float speed = 20;
    private Rigidbody rb;
    private GameObject wa_pu;
    private GameObject wa_pu2;
    private GameObject tree;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
      score = 0;
       
      wa_pu = GameObject.Find("wa-pu");
      wa_pu.SetActive(false);
      wa_pu2 = GameObject.Find("wa-pu2");
      wa_pu2.SetActive(false);

      tree = GameObject.Find("tree");
      for (int i = 0; i < 30; i++)
      {   
        Vector3 pos = tree.transform.position;
        pos.x = Random.Range(100,200);
        pos.y = 0;
        pos.z = Random.Range(-50,50);
        tree.transform.position = pos;
        Instantiate(tree);
      }
    }
    // Update is called once per frame
    void Update()
    {
      var moveHorizontal = Input.GetAxis("Horizontal");
      var moveVertical = Input.GetAxis("Vertical");
      var movememt = new Vector3(moveHorizontal, 0, moveVertical);
      rb.AddForce(movememt * speed);
       
    }

    void OnTriggerEnter(Collider other) 
    {
      if (other.gameObject.CompareTag("aitemu"))
      {
        other.gameObject.SetActive(false);
        score = score + 1;
        if (score == 12) //[ == ]で変数が右の数と同じっだったらになる 
        {
          wa_pu.SetActive(true);
        }
        if (score == 22) //[ == ]で変数が右の数と同じっだったらになる 
        {
          wa_pu2.SetActive(true);
        }
      }
      if (other.gameObject.name == "wa-pu")
      {
        Vector3 pos = transform.position;
        pos.x = 50;
        pos.y = 0.5F;
        pos.z = 0;
        transform.position = pos;
      }
      if (other.gameObject.name == "wa-pu2")
      {
        Vector3 pos = transform.position;
        pos.x = 150;
        pos.y = 0.5F;
        pos.z = 0;
        transform.position = pos;
      }


    }
}

using UnityEngine;

//Debug.Log(ใส่ตัวแปร); คือตัวแสดงผลในหน้าเกม
public class CharactorControl : MonoBehaviour
{
    // ตัวแปร
    public float speed = 2;
    public Rigidbody rb;
    public Vector2 inputControl;


    // Start is called before the first frame update
    void Start() //ทำงานตอนเปิดเกม
    {
        
    }

    // Update is called once per frame
    void Update() //Loop 
    {
        inputControl.x = Input.GetAxis("Horizontal");
        inputControl.y = Input.GetAxis("Vertical");
        //if (Input.GetKey(KeyCode.W)) //ถ้ากด w
        //{
        //    inputControl = Vector2.up;
        //}
        //else if (Input.GetKey(KeyCode.S)) //ถ้ากด s
        //{
        //    inputControl = Vector2.down;
        //}
        //else if (Input.GetKey(KeyCode.A)) //ถ้ากด a
        //{
        //    inputControl = Vector2.left;
        //}
        //else if (Input.GetKey(KeyCode.D)) //ถ้ากด d
        //{
        //    inputControl = Vector2.right;
        //}
        //else //ถ้าไม่กด w
        //{
        //    inputControl = Vector2.zero;
        //}
        rb.velocity = new Vector3(inputControl.x * speed, rb.velocity.y, inputControl.y * speed);
    }
}

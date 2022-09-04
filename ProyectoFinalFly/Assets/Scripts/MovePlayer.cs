using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float rotationAxisX;

        [SerializeField][Range(5f, 50f)] private float speedForward = 5f;
    [SerializeField][Range(5f, 50f)] private float speed = 5f;
    public GameObject cuerpoAvionHijo;
    [SerializeField][Range(10f, 1000f)] private float turnSpeed = 10f;






    // Start is called before the first frame update
    void Start()
    {
        cuerpoAvionHijo = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
        RotatePlayer();

    }



    private void MovementPlayer()
    {
        transform.Translate(Vector3.forward*speedForward*Time.deltaTime);

        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);

    }

    public void RotatePlayer()
    {
        rotationAxisX = Input.GetAxis("Lateral");

        cuerpoAvionHijo.transform.Rotate
           (Vector3.forward * rotationAxisX * -turnSpeed * Time.deltaTime);

       /* if (rotationAxisX == 0)
        {
            cuerpoAvionHijo.transform.rotation = Quaternion.Slerp(cuerpoAvionHijo.transform.rotation, transform.rotation, 0.05f);
        }*/

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float rotationAxisX = 0f;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField][Range(5f, 10f)] private float speed = 5f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
        RotatePlayer();

    }



    private void MovementPlayer()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);

    }

    public void RotatePlayer()
    {


        rotationAxisX -= Input.GetAxis("Mouse X");

        Quaternion newRotation = Quaternion.Euler(0, 0, rotationAxisX);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 10f * Time.deltaTime);
    }
}

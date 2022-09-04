using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField][Range(5f,50f)] private float speed = 10f;
        [SerializeField][Range(5f,10f)] private float moveSpeed =5f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        Vector3 direccion = new Vector3(hor,ver,0);


        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(direccion * moveSpeed * Time.deltaTime);
    }
}

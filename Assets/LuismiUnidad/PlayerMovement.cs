using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Transform tr_;
    private Rigidbody rb_;
    private Vector3 inputDir_;
    public float speed_;


    // Start is called before the first frame update
    void Start()
    {
        tr_ = GetComponent<Transform>();
        rb_ = GetComponent<Rigidbody>();
        inputDir_ = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        inputDir_ = tr_.forward * Input.GetAxis("Vertical");
        inputDir_ += tr_.right * Input.GetAxis("Horizontal");

        Vector3.Normalize(inputDir_);


        tr_.position += inputDir_ * speed_ * Time.deltaTime;
        //tr_.Translate(inputDir_ * speed_ * Time.deltaTime, Space.World);



    }

    void FicedUpdate()
    {


        //rb_.velocity =
        //rb_.AddForce();
    }
}

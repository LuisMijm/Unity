using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Physics_Movement : MonoBehaviour
{

  private Transform tr_;
  private Rigidbody rb_;
  private Vector3 inputDir_;
  public float forceApplied_;
  public float impulse_;
  public float velocityChange_;
  private Vector3 targetVelocity_;

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

      inputDir_.z = Input.GetAxis("Vertical");
      inputDir_.x = Input.GetAxis("Horizontal");

      inputDir_ = Vector3.Normalize(inputDir_);

      if(Input.GetButtonDown("Fire1"))
      {
        rb_.AddForce(Vector3.up * impulseApplied_,ForceMode.Impulse);
      }
    }

    void FixedUpdate()  //Called every 20 ms by default
    {
      // rb_.AddForce(inputDir_ * forceApplied_, ForceMode.Force); //*Time.fixedDeltaTime
      // rb_.AddForce(inputDir_ * forceApplied_, ForceMode.Acceleration);
      // rb_.AddForce(inputDir_ * velocityChange_ * Time.fixedDeltaTime, ForceMode.velocityChange_)
      rb_.velocity = inputDir_ * velocityChange_;
    }
}

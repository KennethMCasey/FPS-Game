using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyController : MonoBehaviour
{
    public float moveSpeed = .05f;
    public float gravity = .05f;

    private CharacterController mController;

    // Start is called before the first frame update
    void Start()
    {
        mController = this.gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 moX = Input.GetAxis("Horizontal") * Vector3.right * moveSpeed;
        Vector3 moZ = Input.GetAxis("Vertical") * Vector3.forward * moveSpeed;

        Vector3 mov = transform.TransformDirection(moX + moZ);

        mController.Move(mov);

    }
}

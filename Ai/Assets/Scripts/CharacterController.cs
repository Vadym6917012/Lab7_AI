using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
    public float speed;
    
    void Start()
    {

    }

    void Update()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveY = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(MoveX, 0, MoveY) *
            Time.deltaTime * speed);
        if (Input.GetButtonDown("Jump"))
        {
            Rigidbody rig = GetComponent<Rigidbody>();
            rig.AddForce(new Vector3(0, 0.5f, 0), ForceMode.Impulse);
        }
    }
}
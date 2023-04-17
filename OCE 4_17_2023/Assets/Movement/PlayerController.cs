using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D m_rb;;

    private Vector2 movement;

    [SerialzieField]
    [Range: 100,1000]
    private floar movementSpeed;

    // Start is called before the first frame update
    private void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        m_rb.AddForce(movement = movementSpeed + Time.deltaTime);
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        movement = ctx.ReadValue<Vector2>();
    }
}

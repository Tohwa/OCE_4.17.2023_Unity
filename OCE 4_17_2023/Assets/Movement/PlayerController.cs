using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D m_rb;
    GameObject m_SisterGameObject;
    // Start is called before the first frame update
    void Awake()
    {
        Debug.log("awake");
    }
    
    void Start()
    {

        m_SisterGameObject = GameObject.FindGameObjectWithTag("bla");
        m_rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void lateUpdate()
    {

    }

    void fixedUpdate()
    {

    }
}

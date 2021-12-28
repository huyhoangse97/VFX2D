using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    Rigidbody2D rigid2D;
    private Params parameters;

    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        parameters = GetComponent<Params>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if ((horizontal + vertical == 0) && (vertical * horizontal == 0)){
            parameters.hasInput = false;
        } else {
            parameters.hasInput = true;
        }
        Vector2 direction = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
        rigid2D.velocity = direction;
    }
}

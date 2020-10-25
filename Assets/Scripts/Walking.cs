using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        Movement();
        {
            float move = Input.GetAxis("Horizontal");
            anim.SetFloat("Speed", move);
        }

    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * 10f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * 15f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.A))
            anim.SetTrigger("LP");
        if (Input.GetKeyDown(KeyCode.S))
            anim.SetTrigger("HP");
        if (Input.GetKeyDown(KeyCode.Z))
            anim.SetTrigger("LK");
        if (Input.GetKeyDown(KeyCode.X))
            anim.SetTrigger("HK");
    }
}

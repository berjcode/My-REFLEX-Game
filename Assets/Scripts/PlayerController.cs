using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerController : MonoBehaviour
{
   
    public float verticalSpeed;
    public float horizontalSpeed;
    private float verticalMovment;
    private float horizontalMovment;

    Rigidbody2D rb;


    public void Start()
    {
        rb =GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        #region MovementCode
        verticalMovment = Input.GetAxis("Vertical");
        horizontalMovment = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalMovment * 50 * horizontalSpeed * Time.deltaTime, verticalMovment * 50 * verticalSpeed * Time.deltaTime);
        #endregion


        #region Horizontal Limit
        if (transform.position.x > 2.5f)
        {
            Vector2 rightLimit = new Vector2(2.5f, transform.position.y);
            transform.position = rightLimit;
        }
        
        if (transform.position.x < -2.5f)
        {
            Vector2 leftLimit = new Vector2(-2.5f, transform.position.y);
            transform.position = leftLimit;
        }



        #endregion

        #region VerticalLimit

        if (transform.position.y > 4f)
        {
            Vector2 yUpLimit = new Vector2(transform.position.x, 4f);
            transform.position = yUpLimit;
        }

        if (transform.position.y < -4f)
        {
            Vector2 yUndertLimit = new Vector2(transform.position.x, -4f);
            transform.position = yUndertLimit;
        }
        #endregion

    }


   





}

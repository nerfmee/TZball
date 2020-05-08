using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class Player : MonoBehaviour

{
    public GameObject MenuPanel;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    public float distance;
    public float forceJump;
    public float forceObjectFollowing;
    [SerializeField] private Menu _menu;
    [SerializeField] private Text _textJumpCount;
    private int _jumpCount;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            _rigidbody2D.AddForce(objPosition * forceObjectFollowing,ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            _menu.ActivateMenu();
        }
    }

   


    private void OnCollisionEnter2D(Collision2D other)
    {
        _jumpCount++;
        _textJumpCount.text = "Jump Count: " + _jumpCount.ToString();
        
        
        var obj = other.gameObject;
      //  _rigidbody2D.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);

        if (obj.GetComponent<PolygonCollider2D>())
        {
            
        }
        else
        {
            _rigidbody2D.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);
        }
        if (obj.tag == "Platform")
        {
            obj.GetComponent<SpriteRenderer>().color =  new Color(Random.value, Random.value, Random.value, 1);
        }
    }
}

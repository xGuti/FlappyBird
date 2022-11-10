using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float _jumpForce;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            _rb.velocity = new Vector2(0, _jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
    }
}

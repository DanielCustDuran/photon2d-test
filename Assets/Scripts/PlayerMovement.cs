using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private SpriteRenderer _sr;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        
        _sr.color = new Color(
            (float)Random.Range(0, 255)/255,
            (float)Random.Range(0, 255)/255,
            (float)Random.Range(0, 255)/255,
            1f
        );
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 inputMovement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position += inputMovement.normalized * Time.deltaTime * 5.0f;

        if (Input.GetKey(KeyCode.Space))
        {
            _rb.AddForce(transform.up * 1.0f, ForceMode2D.Impulse);
        }
    }
}

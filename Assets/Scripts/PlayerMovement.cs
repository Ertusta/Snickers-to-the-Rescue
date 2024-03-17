using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed =2;
    public float JumpForce = 1;
    private Rigidbody2D _rigidbody;

    public Animator _animator;

    SpriteRenderer xnesne;

    float point;

    public  TMPro.TextMeshProUGUI PointText;

    bool isDead=true;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        xnesne = GetComponent<SpriteRenderer>();
        
    }

    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            _animator.SetFloat("State", 2);
            
        }
        

        if(_rigidbody.velocity.y==0&&isDead) 
        {
            if (movement > 0)
            {
                _animator.SetFloat("State", 1);
                
            }
            else if (movement < 0)
            {
                _animator.SetFloat("State", 1);
                
            }
            else
            {
                _animator.SetFloat("State", 0);
            }
        }

        if (movement > 0)
        {
            
            xnesne.flipX = false;
        }
        else if (movement < 0)
        {
            
            xnesne.flipX = true;
        }


        


    }
    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isDead = false;
            _animator.SetFloat("State", 3);
            Invoke("Dead", 3);

        }


        if (collision.gameObject.CompareTag("Collectible"))
        {
            point += 10;
            PointText.text = point.ToString();

        }


    }

    void Dead()
    {
        SceneManager.LoadScene("Mutfak");
    }
}
             

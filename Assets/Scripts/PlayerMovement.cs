using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jump;
    public bool isJumping;
    private float Move;
    [SerializeField] private AudioSource jumpSoundEffect;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            jumpSoundEffect.Play();
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }

        if(transform.position.y < -7.2)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}

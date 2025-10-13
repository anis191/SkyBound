using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce = 5f;
    [SerializeField]
    private GameObject _menu;
    private Rigidbody2D _rigidbody;
    private int _score = 0;

    public int Score
    {
        get
        {
            return _score;
        }
    }

    public bool IsActive
    {
        get
        {
            return gameObject.activeSelf;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // void Start()
    // {
    // 
    // }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.linearVelocityY = _jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        _menu.SetActive(true);
        _score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _score += 1;
    }
}

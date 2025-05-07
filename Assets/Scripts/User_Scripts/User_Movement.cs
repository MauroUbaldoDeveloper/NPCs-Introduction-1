using UnityEngine;

public class User_Movement : MonoBehaviour
{

    private float _Speed;
    private Rigidbody2D _Rdb;

    void Start()
    {
        _Speed = 5;
        _Rdb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movement_Input();
    }

    void Movement_Input()
    {
        if (Input.GetKey(KeyCode.A))
            _Rdb.linearVelocity = -transform.right * _Speed;

        if (Input.GetKey(KeyCode.D))
            _Rdb.linearVelocity = transform.right * _Speed;

        if (Input.GetKeyUp(KeyCode.A))
            Stop_Movementation();

        if (Input.GetKeyUp(KeyCode.D))
            Stop_Movementation();
    }

    public void Stop_Movementation()
    {
        _Rdb.linearVelocity = Vector2.zero;
    }

}

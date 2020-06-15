using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
    private Button jumpBtn;

    private Rigidbody2D myBody;

    private float speed = 3f;

    void Awake()
    {
        jumpBtn = GameObject.Find("Jump").GetComponent<Button>();
        jumpBtn.onClick.AddListener(() => Jump());
        myBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 tempPositonOfPlayer = transform.position;
        tempPositonOfPlayer.x += speed * Time.deltaTime;
        transform.position = tempPositonOfPlayer;
    }

    public void Jump()
    {
        myBody.gravityScale *= -1;
        Vector3 temp = transform.localScale;
        temp.y *= -1;
        transform.localScale = temp;
    }
}

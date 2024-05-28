using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   public float jumpforce = 5.0f;

    private Rigidbody2D PlayerRb;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlayerRb.AddForce(new Vector2(0,1) * jumpforce, ForceMode2D.Impulse);
            Debug.Log("Space bar was pressed");
        }
    }
}

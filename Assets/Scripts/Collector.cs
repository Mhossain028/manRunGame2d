using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private float width = 0f;

    // Start is called before the first frame update
    void Awake()
    {
        width = GameObject.Find("BG").GetComponent<BoxCollider2D>().size.x;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "BG" || target.tag == "Ground")
        {
            Vector3 tempPosition = target.transform.position;
            tempPosition.x += width * 3;
            target.transform.position = tempPosition;
        }

        if (target.tag == "Coin" || target.tag == "knife")
        {
            target.gameObject.SetActive(false);
        }
    }

}

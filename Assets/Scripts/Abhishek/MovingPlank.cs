using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlank : MonoBehaviour
{
    public float MoveSpeed = 4f;
    public Vector3 oldPosition;
    private Vector3 newPosition;
    public float maxDistance = 6f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        oldPosition = transform.position;
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.x = oldPosition.x + (maxDistance * Mathf.Sin(Time.time * MoveSpeed));
        transform.position = new Vector3(newPosition.x, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine("DestroyPlank");
        }
    }

    private IEnumerator DestroyPlank()
    {
        yield return new WaitForSeconds(2f);
        if(gameObject.GetComponent<Rigidbody2D>() == null)
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
        }
        GetComponent<PolygonCollider2D>().enabled = false;
    }
}

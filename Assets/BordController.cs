using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordController : MonoBehaviour
{
    public GameObject Bord;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public ParticleSystem ParticleSys;

    // Start is called before the first frame update
    void Start()
    {
        rb = Bord.GetComponent<Rigidbody2D>();
        sr = Bord.GetComponent<SpriteRenderer>();
        ParticleSys.Play();
        PolygonCollider2D pcBord = Bord.GetComponent<PolygonCollider2D>();
        Debug.Log(Bord.transform.localRotation.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (Bord.transform.localRotation.z > -0.4f)
            Bord.transform.Rotate(Vector3.forward, -0.6f);


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Bord.transform.localRotation.z);
            Bord.transform.Translate(0, 2, 0, Space.World);
            rb.velocity = Vector2.down * 0.2f;
            if (Bord.transform.localRotation.z < 0.5f)
            Bord.transform.Rotate(Vector3.forward, 20);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered");
        sr.flipY = true;
        rb.gravityScale = 0;
        rb.velocity = Vector3.zero;

    }

}

using UnityEngine;

public class Bar : MonoBehaviour
{
    private Rigidbody2D myRigitbody;

    public float barspeed = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigitbody = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 force = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            force = new Vector2(barspeed * -1, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            force = new Vector2(barspeed, 0);
        }

        myRigitbody.MovePosition(myRigitbody.position + force * Time.fixedDeltaTime);
    }
}

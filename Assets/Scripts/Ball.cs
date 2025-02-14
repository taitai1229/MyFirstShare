using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private Rigidbody2D myRigitbody;
    public float speedX = 10;
    public float speedY = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigitbody = this.gameObject.GetComponent<Rigidbody2D>();

        Vector2 force = new Vector2(speedX, speedY);

        myRigitbody.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -4.5f)
        {
            // Debug.Log("GameOver");
            // Time.timeScale = 0;
            SceneManager.LoadScene("GameOverScene");
        }
    }
}

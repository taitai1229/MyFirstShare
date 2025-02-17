using UnityEngine;
using UnityEngine.SceneManagement; // シーン管理のために追加

public class BallController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // ボールの初期方向をランダムに設定
        Vector2 initialDirection = new Vector2(Random.Range(-1f, 1f), 1).normalized;
        rb.linearVelocity = initialDirection * speed; // 修正: linearVelocity → velocity
    }

    void Update()
    {
        // ボールが y = -10 より下に落ちたらゲームオーバーシーンへ
        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class TaisMultiButtonScript : MonoBehaviour
{
    // TaisMultiシーンをロードする
    public void StartTaisMulti()
    {
        SceneManager.LoadScene("TaisMulti");
    }

    // MiyamaGameシーンをロードする
    public void StartMiyamaGame()
    {
        SceneManager.LoadScene("MiyamaGame");
    }

    // Start は最初に1回だけ実行
    void Start()
    {
        
    }

    // Update は毎フレーム実行
    void Update()
    {
        
    }
}

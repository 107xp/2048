using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{

    public Animator _anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
        {
            SceneManager.LoadScene("Game");
        }
    }
}

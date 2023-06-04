using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int score;
    public TMP_Text ScoredText;
    public AudioSource MediaPlayer;
    public AudioClip Scored;
    public AudioClip Explosion;
    public GameObject Spawner;
    public Animator animator;
    public GameObject Panel, Frame;

    private void Awake()
    {
        score = 0;
        if (!PlayerPrefs.HasKey("Score"))
        {
            PlayerPrefs.SetInt("Score", 0);
        }
        animator.SetBool("scores", false);
        Panel.SetActive(false);
        Frame.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            score++;
            animator.SetBool("scores", true);
            Destroy(collision.gameObject);
            MediaPlayer.PlayOneShot(Scored, 1f);
        }
        if (collision.CompareTag("Enemy"))
        {
            Destroy(Spawner);
            Destroy(gameObject);
            MediaPlayer.PlayOneShot(Explosion, 1f);
            Panel.SetActive(true);
            Frame.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        PlayerPrefs.SetInt("Score", score);
        ScoredText.text = score.ToString(); 
        animator.SetBool("scores", false) ;
    }

    
}

using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public AudioClip m_Clip;
    public AudioSource MediaPlayer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        MediaPlayer.PlayOneShot(m_Clip, 1f);
        Destroy(collision.gameObject);
    }
}

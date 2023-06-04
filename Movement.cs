using UnityEngine;

public class Movement : MonoBehaviour
{
    public int k;
    public AudioSource MediaPlayer;
    public AudioClip Moving;

    private void FixedUpdate()
    {
        transform.rotation *= Quaternion.Euler(0, 0, k);
    }

    public void ChangeDirection()
    {
        k *= -1;
        MediaPlayer.PlayOneShot(Moving, 1f);
    }
}

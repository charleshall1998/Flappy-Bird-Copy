using UnityEngine;

public class WingSoundScript : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound()
    {
        audioSource.Play();
    }
}

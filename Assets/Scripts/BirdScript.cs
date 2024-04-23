using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logicScript;
    public bool isAlive = true;
    public AudioSource wingAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive && Input.GetKeyDown(KeyCode.Space) == true)
        {
            wingAudioSource.Play();
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isAlive)
        {
            logicScript.GameOver();
            isAlive = false;
        }
    }

    private void OnBecameInvisible()
    {
        if (isAlive)
        {
            logicScript.GameOver();
            isAlive = false;
        }
    }
}

using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logicScript;
    private int birdLayer = 3;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == birdLayer)
        {
            logicScript.AddScore(1);
        }
    }
}

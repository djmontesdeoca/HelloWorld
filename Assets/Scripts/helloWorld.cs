using UnityEngine;

public class helloWorld : MonoBehaviour
{
    int m_frame = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello world");
    }

    // Update is called once per frame
    void Update()
    {
        m_frame++;
    }
}

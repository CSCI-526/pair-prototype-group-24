using UnityEngine;

public class InputTest : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKey)
            Debug.Log("Some key is pressed!");
    }
}

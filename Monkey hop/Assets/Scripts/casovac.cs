using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class casovac : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(kancelarLoad());
    }

    IEnumerator kancelarLoad()
    {
        yield return new WaitForSeconds(8f);
        SceneManager.LoadScene("Level 1");
    }
}

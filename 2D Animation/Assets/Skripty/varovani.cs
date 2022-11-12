using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class varovani : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(kancelarLoad());
    }

    IEnumerator kancelarLoad()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("Menu");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class odpocet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(kancelarLoad());
    }

    IEnumerator kancelarLoad()
    {
        yield return new WaitForSeconds(106f);
        SceneManager.LoadScene("menu");
    }
}

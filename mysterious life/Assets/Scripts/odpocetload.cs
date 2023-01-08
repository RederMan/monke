using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class odpocetload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(levelLoad());
    }

    IEnumerator levelLoad()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("level");
    }
}

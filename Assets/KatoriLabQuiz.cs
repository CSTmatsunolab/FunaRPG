using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KatoriLabQuiz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataAnnnai.Instance.referer="KatoriLabQuiz";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("KatoriLab");
        }
    }
}

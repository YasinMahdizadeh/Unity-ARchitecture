using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoController : MonoBehaviour
{
    public void moon ()
    {
        SceneManager.LoadScene("2");
    }
    public void floor ()
    {
        SceneManager.LoadScene("3");
    }
    public void back ()
    {
        SceneManager.LoadScene("1");
    }
    
    public void structure ()
    {

    }
}

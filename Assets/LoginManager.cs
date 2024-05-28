using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoginManager : MonoBehaviour
{
    public string Password;
    public InputField input_password;

    // Start is called before the first frame update
    public void Checkpass()
    {
        if (Password == input_password.text)
        {
            Debug.Log(" Access Granted ");

        }
        else
        {
            Debug.Log("Access Denied");
        }


    }
}

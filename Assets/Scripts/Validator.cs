using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Validator : MonoBehaviour
{
    public void Validation()
    {
        Text userName = GameObject.Find("UserNameText").GetComponent<Text>();
        Text userAge = GameObject.Find("UserAgeText").GetComponent<Text>();

        if (userName.text == string.Empty)
        {
            FindInActiveObjectByName("EnterNameText").SetActive(true);
        }
        if (userAge.text == string.Empty)
        {
            FindInActiveObjectByName("EnterAgeText").SetActive(true);
        } 
        else
        {
            try
            {
                int age = int.Parse(userAge.text);
                if (age <= 0)
                {
                    FindInActiveObjectByName("InvalidAgeText").SetActive(true);
                }
            }
            catch
            {
                FindInActiveObjectByName("InvalidAgeText").SetActive(true);
            }
        }
    }

    private GameObject FindInActiveObjectByName(string name)
    {
        Transform[] objects = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i].hideFlags == HideFlags.None)
            {
                if (objects[i].name == name)
                {
                    return objects[i].gameObject;
                }
            }
        }
        return null;
    }
}

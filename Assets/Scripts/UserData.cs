using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "User Data", order = 1)]
public class UserData : ScriptableObject
{
    public string UserName;

    public int UserAge;
}

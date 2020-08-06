using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instence;
    private void Awake()
    {
        instence = this;
    }
}

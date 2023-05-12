using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Game : MonoBehaviour
{
    #region Singleton class: Game

    public static Game Instance;

    private void Awake()
    {
        Instance = this;
        screenWidth = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x;
    }

    #endregion

    [HideInInspector] public float screenWidth;
}

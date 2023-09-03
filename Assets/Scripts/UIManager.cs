using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public PikminManager pikminManager;
    public Text pikminCountText;
    void Start()
    {
        pikminManager.pikminFollow.AddListener((x)=>UpdatePikminNumber(x));
    }
    void UpdatePikminNumber(int num)
    {
       
        pikminCountText.text = num.ToString();
    }

}

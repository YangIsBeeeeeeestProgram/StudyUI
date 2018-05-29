using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUIManager : MonoBehaviour {

    private StartUIManager() { }
    private static StartUIManager instance;
    public static StartUIManager Instance { get { return instance; } }


    [Header("登录界面")]
    public GameObject LoginPanelObj;
    [Header("开始游戏界面")]
    public GameObject PlayPanelObj;
    [Header("注册界面")]
    public GameObject RegisterPanelObj;

    private void Awake()
    {
        instance = this;
    }


    /// <summary>
    /// 显示指定界面
    /// </summary>
    /// <param name="type">界面类型标识</param>
    public void ShowPanel(string type)
    {
        HideAll();
        switch (type)
        {
            case "登录":
                LoginPanelObj.SetActive(true);
                break;
            case "注册":
                RegisterPanelObj.SetActive(true);
                break;
            case "开始":
                PlayPanelObj.SetActive(true);
                break;
            default:
                break;
        }
    }

    private void HideAll()
    {
        LoginPanelObj.SetActive(false);
        RegisterPanelObj.SetActive(false);
        PlayPanelObj.SetActive(false);
    }





}

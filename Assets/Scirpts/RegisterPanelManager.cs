using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RegisterPanelManager : MonoBehaviour {
    [SerializeField]
    InputField usernameInputFiled;
    [SerializeField]
    InputField passwordInputFiled;
    [SerializeField]
    Button regButtton;



    private string urnStr;
    private string pwdStr;
    private void Awake()
    {
        Init();
    }

    //初始化
    private void Init()
    {
        regButtton.onClick.AddListener(OnRegBtnClick);
    }


    /// <summary>
    /// 确认注册按钮事件方法
    /// </summary>
    public void OnRegBtnClick()
    {
        urnStr = usernameInputFiled.text.Trim();
        pwdStr = passwordInputFiled.text.Trim();

        if (urnStr == string.Empty || pwdStr == string.Empty)
        {
            ReminController.Instance.ShowReminding("用户名或密码为空", Color.red);
            return; ;
        }

        User currentUser = new User(urnStr, pwdStr);

        for (int i = 0; i < GameManager.users.Count; i++)
        {
            if (GameManager.users[i].UserName == currentUser.UserName)
            {
                ReminController.Instance.ShowReminding("该用户名已存在", Color.red);
                StartUIManager.Instance.ShowPanel("登录");
                return;
            }
            else
                continue;
        }

        GameManager.users.Add(currentUser);

        print(GameManager.users[0].UserName + GameManager.users[0].Password);
        ReminController.Instance.ShowReminding("恭喜你,注册成功", Color.yellow);
        StartUIManager.Instance.ShowPanel("登录");
    }


   

}

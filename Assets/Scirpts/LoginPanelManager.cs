using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoginPanelManager : MonoBehaviour {

    [SerializeField]
    InputField usernameInputField;

    [SerializeField]
    InputField passwordInputField;

    [SerializeField]
    Button regButtton;
    [SerializeField]
    Button loginButton;


    private void Awake()
    {
        Init();
    }

    //初始化
    private void Init()
    {
        regButtton.onClick.AddListener(OnRegBtnClick);
        loginButton.onClick.AddListener(OnLoginBtnClick);
    }


    /// <summary>
    /// 注册按钮事件方法
    /// </summary>
    public void OnRegBtnClick()
    {
        StartUIManager.Instance.ShowPanel("注册");
    }

    /// <summary>
    /// 登录按钮事件方法
    /// </summary>
    public void OnLoginBtnClick()
    {
        string urnStr = usernameInputField.text;
        string pwdStr = passwordInputField.text;


        if (urnStr == string.Empty || pwdStr == string.Empty)
        {
            ReminController.Instance.ShowReminding("用户名或密码为空", Color.red);
            return;
        }
        User currentUser = new User(urnStr,pwdStr);


        for (int i = 0; i < GameManager.users.Count; i++)
        {
            if (GameManager.users[i].UserName == currentUser.UserName 
                && GameManager.users[i].Password == currentUser.Password)
            {
                ReminController.Instance.ShowReminding("登录成功", Color.yellow);
                StartUIManager.Instance.ShowPanel("开始");
                return;
            }
        }
        ReminController.Instance.ShowReminding("用户名或密码不正确", Color.red);
    }



       




}

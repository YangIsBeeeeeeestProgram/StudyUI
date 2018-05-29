using System.Collections;
using System.Collections.Generic;


public class User  {

    private string userName;
    /// <summary>
    /// 用户名
    /// </summary>
    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }


    private string password;
    /// <summary>
    /// 密码
    /// </summary>
    public string Password
    {
        get { return password; }
        set { password = value; }
    }


    public User(string _username,string _password)
    {
        this.userName = _username;
        this.password = _password;
    }


}

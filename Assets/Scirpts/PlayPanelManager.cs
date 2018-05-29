using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayPanelManager : MonoBehaviour {


    private PlayPanelManager() { }


    /// <summary>
    /// 单例
    /// </summary>
    private static PlayPanelManager instance;
    public static PlayPanelManager Instance { get { return instance; } }
    
    [SerializeField]
    Button startButton;

    private void Awake()
    {
        instance = this;
       
    }


    private void Start()
    {
        startButton.onClick.AddListener(OnStartBtnClick);
    }



    /// <summary>
    /// Play按钮点击事件方法
    /// </summary>
    public void OnStartBtnClick()
    {
        SceneManager.LoadScene(1);
    }



}

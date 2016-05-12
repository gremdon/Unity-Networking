﻿using UnityEngine;
using System;
[Serializable]
public class PlayerManager
{
    public GameObject m_Instance; //assigned from GameManager

    public string m_Name;
    public UIRoot m_UI;
    public Player m_Player;        
    public Camera m_PlayerCamera;
    public Camera m_PlayerUICamera;
    
    // Use this for initialization
    public void Setup()
    {
        m_Instance.name = m_Name;
        m_Player = m_Instance.GetComponent<Player>();
        m_UI = m_Player.UI.GetComponent<UIRoot>();
        m_PlayerCamera = m_Player.Camera.GetComponent<Camera>();
        m_PlayerUICamera = m_Player.UICamera.GetComponent<Camera>();
        m_Player.m_PlayerName = m_Name;
       
        m_Player.Setup();
        m_UI.Setup(m_Player);

        //UICamera is seperate from UI and not a child
        //only way to get screenspace ui working for now
        
    }

    public bool IsReady()
    {
        return m_Player.m_IsReady;
    }







}

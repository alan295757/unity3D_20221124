﻿using UnityEngine;

namespace JAY
{
    /// <summary>
    /// 對話資料
    /// </summary>
    [CreateAssetMenu(menuName = "JAY/Dialogue Data", fileName = "New Dialogue Data")]
    public class NewBehaviourScript : ScriptableObject
    {
        [Header("對話者名稱")]
        public string dialogueName;
        [Header("對話者內容"), TextArea(2, 10)]
        public string[] dialogueContents;
    }
}
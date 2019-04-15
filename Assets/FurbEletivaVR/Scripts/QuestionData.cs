﻿
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "question", menuName = "FurbEletivaVR/New Question")]
public class QuestionData : ScriptableObject
{
    [TextArea()]
    public string Text;
    [Tooltip("Time walking to the question (in seconds)")]
    public float Time = 20;

    [Tooltip("Time to answer this question (in seconds)")]
    public float AnswerTime = 10;

    public List<AnswerData> Answers;
}

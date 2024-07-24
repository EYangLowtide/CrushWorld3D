using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ExplodeCount : MonoBehaviour
{
    public void AddPoint()
    {
        ScoreManager.scoreCount += 1;
    }
}

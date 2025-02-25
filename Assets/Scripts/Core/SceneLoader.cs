﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ES.Core
{
    public class SceneLoader : MonoBehaviour
    {
        public void LoadCurrentLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}

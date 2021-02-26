using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RG_FrameworkMenu
{
    public class UI_HUDGame : UI_MenuBase
    {
        public Text TimerText;
        public int HP;
        public WaveSpawner WaveSpawner;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (WaveSpawner.CurrentWaveSpawned < WaveSpawner.WaveLimit)
            {
                TimerText.text = WaveSpawner.Timer.ToString("F0");
            }
            else
            {
                TimerText.gameObject.SetActive(false);
            }
            
        }

        protected override void OnSetup()
        {
            base.OnSetup();
        }
    }
}


﻿using System;
using UnityEngine;
using UnityEngine.UI;

namespace AssemblyCSharp
{
	public class SoundScript: MonoBehaviour {

		private Music music;
		public Button musicToggleButton;
		public Sprite musicOnSprite;
		public Sprite musicOffSprite;

		void Start () {
			music = GameObject.FindObjectOfType<Music> ();
			UpdateIcon ();
		}

		void Update () {

		}

		public void PauseMusic()
		{
			music.ToggleSound ();
			UpdateIcon (); 
		}

		void UpdateIcon()
		{
			if (PlayerPrefs.GetInt ("Muted", 0) == 0) {
				AudioListener.volume = 1;
				musicToggleButton.GetComponent<Image> ().sprite = musicOnSprite;

			} else
				AudioListener.volume = 0;
		}

	}
}
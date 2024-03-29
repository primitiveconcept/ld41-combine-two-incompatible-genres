﻿namespace FarmingShooter
{
	using UnityEngine;
	public class UIHub : MonoBehaviour
	{
		[SerializeField]
		private UIPlayerHud playerHud;

		[SerializeField]
		private DaySystem daySystem;

		[SerializeField]
		private GameObject startScreen;

		[SerializeField]
		private GameObject endScreen;


		public void Start()
		{
			this.endScreen.gameObject.SetActive(false);
			this.daySystem.gameObject.SetActive(false);
			this.playerHud.gameObject.SetActive(false);
			this.startScreen.SetActive(true);
		}
	}
}

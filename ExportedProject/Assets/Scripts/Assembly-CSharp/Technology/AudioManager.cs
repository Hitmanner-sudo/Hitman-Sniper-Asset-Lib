using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000A49")]
	[Scope]
	public class AudioManager : GameSingleton<AudioManager>
	{
		[Token(Token = "0x40035A2")]
		[FieldOffset(Offset = "0x48")]
		public AudioSource originalAudioSource;

		[Token(Token = "0x40035A3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int NumAudioBuses;

		[Token(Token = "0x40035A4")]
		[FieldOffset(Offset = "0x50")]
		[Decibels]
		public float Volume;

		[Token(Token = "0x40035A5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private AudioBus[] _audioBuses;

		[Token(Token = "0x17000850")]
		public AudioBus[] AudioBuses
		{
			[Token(Token = "0x6004133")]
			[Address(RVA = "0xC085E8", Offset = "0xC085E8", VA = "0xC085E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600412F")]
		[Address(RVA = "0xC09058", Offset = "0xC09058", VA = "0xC09058", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004130")]
		[Address(RVA = "0xC09360", Offset = "0xC09360", VA = "0xC09360", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6004131")]
		[Address(RVA = "0xC09490", Offset = "0xC09490", VA = "0xC09490")]
		private void OnLoadComplete(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x6004132")]
		[Address(RVA = "0xC09684", Offset = "0xC09684", VA = "0xC09684")]
		public AudioSource GetGameManagerAudioSource()
		{
			return null;
		}

		[Token(Token = "0x6004134")]
		[Address(RVA = "0xC0968C", Offset = "0xC0968C", VA = "0xC0968C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004135")]
		[Address(RVA = "0xC09840", Offset = "0xC09840", VA = "0xC09840")]
		public AudioManager()
		{
		}
	}
}

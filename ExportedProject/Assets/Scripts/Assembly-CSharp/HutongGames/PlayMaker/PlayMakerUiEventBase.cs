using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Token(Token = "0x2000E8C")]
	public abstract class PlayMakerUiEventBase : MonoBehaviour
	{
		[Token(Token = "0x4004474")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayMakerFSM> targetFsms;

		[NonSerialized]
		[Token(Token = "0x4004475")]
		[FieldOffset(Offset = "0x20")]
		protected bool initialized;

		[Token(Token = "0x6005A2D")]
		[Address(RVA = "0xB7F144", Offset = "0xB7F144", VA = "0xB7F144")]
		public void AddTargetFsm(PlayMakerFSM fsm)
		{
		}

		[Token(Token = "0x6005A2E")]
		[Address(RVA = "0xB7F1C8", Offset = "0xB7F1C8", VA = "0xB7F1C8")]
		private bool TargetsFsm(PlayMakerFSM fsm)
		{
			return default(bool);
		}

		[Token(Token = "0x6005A2F")]
		[Address(RVA = "0xB7F2B8", Offset = "0xB7F2B8", VA = "0xB7F2B8")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x6005A30")]
		[Address(RVA = "0xB7F2C4", Offset = "0xB7F2C4", VA = "0xB7F2C4")]
		public void PreProcess()
		{
		}

		[Token(Token = "0x6005A31")]
		[Address(RVA = "0xB7F2D0", Offset = "0xB7F2D0", VA = "0xB7F2D0", Slot = "4")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x6005A32")]
		[Address(RVA = "0xB7E61C", Offset = "0xB7E61C", VA = "0xB7E61C")]
		protected void SendEvent(FsmEvent fsmEvent)
		{
		}

		[Token(Token = "0x6005A33")]
		[Address(RVA = "0xB7E6EC", Offset = "0xB7E6EC", VA = "0xB7E6EC")]
		protected PlayMakerUiEventBase()
		{
		}
	}
}

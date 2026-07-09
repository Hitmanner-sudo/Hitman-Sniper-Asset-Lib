using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200100C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0174", Offset = "0x5A0174")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0174", Offset = "0x5A0174")]
	public class LoadLevel : FsmStateAction
	{
		[Token(Token = "0x4004B60")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA240", Offset = "0x5DA240")]
		public FsmString levelName;

		[Token(Token = "0x4004B61")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA28C", Offset = "0x5DA28C")]
		public bool additive;

		[Token(Token = "0x4004B62")]
		[FieldOffset(Offset = "0x59")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA2C4", Offset = "0x5DA2C4")]
		public bool async;

		[Token(Token = "0x4004B63")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA2FC", Offset = "0x5DA2FC")]
		public FsmEvent loadedEvent;

		[Token(Token = "0x4004B64")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA334", Offset = "0x5DA334")]
		public FsmBool dontDestroyOnLoad;

		[Token(Token = "0x4004B65")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA36C", Offset = "0x5DA36C")]
		public FsmEvent failedEvent;

		[Token(Token = "0x4004B66")]
		[FieldOffset(Offset = "0x78")]
		private AsyncOperation asyncOperation;

		[Token(Token = "0x600606A")]
		[Address(RVA = "0x9C9E70", Offset = "0x9C9E70", VA = "0x9C9E70", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600606B")]
		[Address(RVA = "0x9C9EDC", Offset = "0x9C9EDC", VA = "0x9C9EDC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600606C")]
		[Address(RVA = "0x9CA224", Offset = "0x9CA224", VA = "0x9CA224", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600606D")]
		[Address(RVA = "0x9CA280", Offset = "0x9CA280", VA = "0x9CA280")]
		public LoadLevel()
		{
		}
	}
}

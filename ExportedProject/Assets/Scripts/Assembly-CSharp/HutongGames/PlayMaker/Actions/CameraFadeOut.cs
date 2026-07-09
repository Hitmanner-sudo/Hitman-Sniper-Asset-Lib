using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F38")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C0D8", Offset = "0x59C0D8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C0D8", Offset = "0x59C0D8")]
	public class CameraFadeOut : FsmStateAction
	{
		[Token(Token = "0x40047CD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC6E0", Offset = "0x5CC6E0")]
		[RequiredField]
		public FsmColor color;

		[Token(Token = "0x40047CE")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC72C", Offset = "0x5CC72C")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5CC72C", Offset = "0x5CC72C")]
		public FsmFloat time;

		[Token(Token = "0x40047CF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC790", Offset = "0x5CC790")]
		public FsmEvent finishEvent;

		[Token(Token = "0x40047D0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC7C8", Offset = "0x5CC7C8")]
		public bool realTime;

		[Token(Token = "0x40047D1")]
		[FieldOffset(Offset = "0x6C")]
		private float startTime;

		[Token(Token = "0x40047D2")]
		[FieldOffset(Offset = "0x70")]
		private float currentTime;

		[Token(Token = "0x40047D3")]
		[FieldOffset(Offset = "0x74")]
		private Color colorLerp;

		[Token(Token = "0x6005D35")]
		[Address(RVA = "0xAF21B0", Offset = "0xAF21B0", VA = "0xAF21B0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D36")]
		[Address(RVA = "0xAF21F0", Offset = "0xAF21F0", VA = "0xAF21F0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D37")]
		[Address(RVA = "0xAF222C", Offset = "0xAF222C", VA = "0xAF222C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D38")]
		[Address(RVA = "0xAF2368", Offset = "0xAF2368", VA = "0xAF2368", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005D39")]
		[Address(RVA = "0xAF246C", Offset = "0xAF246C", VA = "0xAF246C")]
		public CameraFadeOut()
		{
		}
	}
}

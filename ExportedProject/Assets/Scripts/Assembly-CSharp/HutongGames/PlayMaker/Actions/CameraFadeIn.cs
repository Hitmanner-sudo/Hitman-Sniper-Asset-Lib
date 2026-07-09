using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F37")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C088", Offset = "0x59C088")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C088", Offset = "0x59C088")]
	public class CameraFadeIn : FsmStateAction
	{
		[Token(Token = "0x40047C6")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC5C0", Offset = "0x5CC5C0")]
		public FsmColor color;

		[Token(Token = "0x40047C7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5CC60C", Offset = "0x5CC60C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC60C", Offset = "0x5CC60C")]
		[RequiredField]
		public FsmFloat time;

		[Token(Token = "0x40047C8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC670", Offset = "0x5CC670")]
		public FsmEvent finishEvent;

		[Token(Token = "0x40047C9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC6A8", Offset = "0x5CC6A8")]
		public bool realTime;

		[Token(Token = "0x40047CA")]
		[FieldOffset(Offset = "0x6C")]
		private float startTime;

		[Token(Token = "0x40047CB")]
		[FieldOffset(Offset = "0x70")]
		private float currentTime;

		[Token(Token = "0x40047CC")]
		[FieldOffset(Offset = "0x74")]
		private Color colorLerp;

		[Token(Token = "0x6005D30")]
		[Address(RVA = "0xAF1ED8", Offset = "0xAF1ED8", VA = "0xAF1ED8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D31")]
		[Address(RVA = "0xAF1F18", Offset = "0xAF1F18", VA = "0xAF1F18", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D32")]
		[Address(RVA = "0xAF1F58", Offset = "0xAF1F58", VA = "0xAF1F58", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D33")]
		[Address(RVA = "0xAF20A4", Offset = "0xAF20A4", VA = "0xAF20A4", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005D34")]
		[Address(RVA = "0xAF21A8", Offset = "0xAF21A8", VA = "0xAF21A8")]
		public CameraFadeIn()
		{
		}
	}
}

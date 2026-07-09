using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F90")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DA1C", Offset = "0x59DA1C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DA1C", Offset = "0x59DA1C")]
	public class DrawTexture : FsmStateAction
	{
		[Token(Token = "0x4004988")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2F7C", Offset = "0x5D2F7C")]
		[RequiredField]
		public FsmTexture texture;

		[Token(Token = "0x4004989")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2FC8", Offset = "0x5D2FC8")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5D2FC8", Offset = "0x5D2FC8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D2FC8", Offset = "0x5D2FC8")]
		public FsmRect screenRect;

		[Token(Token = "0x400498A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D303C", Offset = "0x5D303C")]
		public FsmFloat left;

		[Token(Token = "0x400498B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3074", Offset = "0x5D3074")]
		public FsmFloat top;

		[Token(Token = "0x400498C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D30AC", Offset = "0x5D30AC")]
		public FsmFloat width;

		[Token(Token = "0x400498D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D30E4", Offset = "0x5D30E4")]
		public FsmFloat height;

		[Token(Token = "0x400498E")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D311C", Offset = "0x5D311C")]
		public ScaleMode scaleMode;

		[Token(Token = "0x400498F")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3154", Offset = "0x5D3154")]
		public FsmBool alphaBlend;

		[Token(Token = "0x4004990")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D318C", Offset = "0x5D318C")]
		public FsmFloat imageAspect;

		[Token(Token = "0x4004991")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D31C4", Offset = "0x5D31C4")]
		public FsmBool normalized;

		[Token(Token = "0x4004992")]
		[FieldOffset(Offset = "0xA0")]
		private Rect rect;

		[Token(Token = "0x6005EAB")]
		[Address(RVA = "0xC1FCAC", Offset = "0xC1FCAC", VA = "0xC1FCAC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EAC")]
		[Address(RVA = "0xC1FD4C", Offset = "0xC1FD4C", VA = "0xC1FD4C", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EAD")]
		[Address(RVA = "0xC20074", Offset = "0xC20074", VA = "0xC20074")]
		public DrawTexture()
		{
		}
	}
}

using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001044")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A14D0", Offset = "0x5A14D0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A14D0", Offset = "0x5A14D0")]
	public class SetTextureOffset : ComponentAction<Renderer>
	{
		[Token(Token = "0x4004C67")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DEB20", Offset = "0x5DEB20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEB20", Offset = "0x5DEB20")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004C68")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEBB4", Offset = "0x5DEBB4")]
		public FsmInt materialIndex;

		[Token(Token = "0x4004C69")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEBEC", Offset = "0x5DEBEC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DEBEC", Offset = "0x5DEBEC")]
		public FsmString namedTexture;

		[Token(Token = "0x4004C6A")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEC4C", Offset = "0x5DEC4C")]
		public FsmFloat offsetX;

		[Token(Token = "0x4004C6B")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEC98", Offset = "0x5DEC98")]
		[RequiredField]
		public FsmFloat offsetY;

		[Token(Token = "0x4004C6C")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DECE4", Offset = "0x5DECE4")]
		public bool everyFrame;

		[Token(Token = "0x6006170")]
		[Address(RVA = "0x83B9B8", Offset = "0x83B9B8", VA = "0x83B9B8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006171")]
		[Address(RVA = "0x83BA44", Offset = "0x83BA44", VA = "0x83BA44", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006172")]
		[Address(RVA = "0x83BD60", Offset = "0x83BD60", VA = "0x83BD60", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006173")]
		[Address(RVA = "0x83BA80", Offset = "0x83BA80", VA = "0x83BA80")]
		private void DoSetTextureOffset()
		{
		}

		[Token(Token = "0x6006174")]
		[Address(RVA = "0x83BD64", Offset = "0x83BD64", VA = "0x83BD64")]
		public SetTextureOffset()
		{
		}
	}
}

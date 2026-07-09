using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001045")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1520", Offset = "0x5A1520")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1520", Offset = "0x5A1520")]
	public class SetTextureScale : ComponentAction<Renderer>
	{
		[Token(Token = "0x4004C6D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DED1C", Offset = "0x5DED1C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DED1C", Offset = "0x5DED1C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004C6E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEDB0", Offset = "0x5DEDB0")]
		public FsmInt materialIndex;

		[Token(Token = "0x4004C6F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEDE8", Offset = "0x5DEDE8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DEDE8", Offset = "0x5DEDE8")]
		public FsmString namedTexture;

		[Token(Token = "0x4004C70")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEE38", Offset = "0x5DEE38")]
		public FsmFloat scaleX;

		[Token(Token = "0x4004C71")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEE84", Offset = "0x5DEE84")]
		[RequiredField]
		public FsmFloat scaleY;

		[Token(Token = "0x4004C72")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DEED0", Offset = "0x5DEED0")]
		public bool everyFrame;

		[Token(Token = "0x6006175")]
		[Address(RVA = "0x83BDB0", Offset = "0x83BDB0", VA = "0x83BDB0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006176")]
		[Address(RVA = "0x83BE48", Offset = "0x83BE48", VA = "0x83BE48", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006177")]
		[Address(RVA = "0x83C164", Offset = "0x83C164", VA = "0x83C164", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006178")]
		[Address(RVA = "0x83BE84", Offset = "0x83BE84", VA = "0x83BE84")]
		private void DoSetTextureScale()
		{
		}

		[Token(Token = "0x6006179")]
		[Address(RVA = "0x83C168", Offset = "0x83C168", VA = "0x83C168")]
		public SetTextureScale()
		{
		}
	}
}

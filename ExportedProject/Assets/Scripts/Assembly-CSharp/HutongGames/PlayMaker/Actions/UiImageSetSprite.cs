using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200121B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB1E4", Offset = "0x5AB1E4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB1E4", Offset = "0x5AB1E4")]
	public class UiImageSetSprite : ComponentAction<Image>
	{
		[Token(Token = "0x40056A9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6049D8", Offset = "0x6049D8")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6049D8", Offset = "0x6049D8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056AA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604A6C", Offset = "0x604A6C")]
		[RequiredField]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x604A6C", Offset = "0x604A6C")]
		public FsmObject sprite;

		[Token(Token = "0x40056AB")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604B00", Offset = "0x604B00")]
		public FsmBool resetOnExit;

		[Token(Token = "0x40056AC")]
		[FieldOffset(Offset = "0x80")]
		private Image image;

		[Token(Token = "0x40056AD")]
		[FieldOffset(Offset = "0x88")]
		private Sprite originalSprite;

		[Token(Token = "0x6006A24")]
		[Address(RVA = "0xB8E7A0", Offset = "0xB8E7A0", VA = "0xB8E7A0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A25")]
		[Address(RVA = "0xB8E7D0", Offset = "0xB8E7D0", VA = "0xB8E7D0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A26")]
		[Address(RVA = "0xB8E870", Offset = "0xB8E870", VA = "0xB8E870")]
		private void DoSetImageSourceValue()
		{
		}

		[Token(Token = "0x6006A27")]
		[Address(RVA = "0xB8E944", Offset = "0xB8E944", VA = "0xB8E944", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A28")]
		[Address(RVA = "0xB8E9EC", Offset = "0xB8E9EC", VA = "0xB8E9EC")]
		public UiImageSetSprite()
		{
		}
	}
}

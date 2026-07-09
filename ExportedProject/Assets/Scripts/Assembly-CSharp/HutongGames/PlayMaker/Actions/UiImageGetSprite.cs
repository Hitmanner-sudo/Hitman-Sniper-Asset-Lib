using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001218")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB0F4", Offset = "0x5AB0F4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB0F4", Offset = "0x5AB0F4")]
	public class UiImageGetSprite : ComponentAction<Image>
	{
		[Token(Token = "0x400569E")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x604654", Offset = "0x604654")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604654", Offset = "0x604654")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400569F")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6046E8", Offset = "0x6046E8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6046E8", Offset = "0x6046E8")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x6046E8", Offset = "0x6046E8")]
		public FsmObject sprite;

		[Token(Token = "0x40056A0")]
		[FieldOffset(Offset = "0x78")]
		private Image image;

		[Token(Token = "0x6006A16")]
		[Address(RVA = "0xB8E2B0", Offset = "0xB8E2B0", VA = "0xB8E2B0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A17")]
		[Address(RVA = "0xB8E2B8", Offset = "0xB8E2B8", VA = "0xB8E2B8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A18")]
		[Address(RVA = "0xB8E340", Offset = "0xB8E340", VA = "0xB8E340")]
		private void DoSetImageSourceValue()
		{
		}

		[Token(Token = "0x6006A19")]
		[Address(RVA = "0xB8E3D0", Offset = "0xB8E3D0", VA = "0xB8E3D0")]
		public UiImageGetSprite()
		{
		}
	}
}

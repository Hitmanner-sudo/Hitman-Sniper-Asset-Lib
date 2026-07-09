using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001219")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB144", Offset = "0x5AB144")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB144", Offset = "0x5AB144")]
	public class UiImageSetFillAmount : ComponentAction<Image>
	{
		[Token(Token = "0x40056A1")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x604790", Offset = "0x604790")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604790", Offset = "0x604790")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056A2")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x604824", Offset = "0x604824")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604824", Offset = "0x604824")]
		public FsmFloat ImageFillAmount;

		[Token(Token = "0x40056A3")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604888", Offset = "0x604888")]
		public bool everyFrame;

		[Token(Token = "0x40056A4")]
		[FieldOffset(Offset = "0x80")]
		private Image image;

		[Token(Token = "0x6006A1A")]
		[Address(RVA = "0xB8E41C", Offset = "0xB8E41C", VA = "0xB8E41C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A1B")]
		[Address(RVA = "0xB8E450", Offset = "0xB8E450", VA = "0xB8E450", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A1C")]
		[Address(RVA = "0xB8E590", Offset = "0xB8E590", VA = "0xB8E590", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A1D")]
		[Address(RVA = "0xB8E4EC", Offset = "0xB8E4EC", VA = "0xB8E4EC")]
		private void DoSetFillAmount()
		{
		}

		[Token(Token = "0x6006A1E")]
		[Address(RVA = "0xB8E594", Offset = "0xB8E594", VA = "0xB8E594")]
		public UiImageSetFillAmount()
		{
		}
	}
}

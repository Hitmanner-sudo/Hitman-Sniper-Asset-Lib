using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F2F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59BEA8", Offset = "0x59BEA8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59BEA8", Offset = "0x59BEA8")]
	public class PlaySound : FsmStateAction
	{
		[Token(Token = "0x40047B0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBF08", Offset = "0x5CBF08")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40047B1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBF40", Offset = "0x5CBF40")]
		public FsmVector3 position;

		[Token(Token = "0x40047B2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CBF78", Offset = "0x5CBF78")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5CBF78", Offset = "0x5CBF78")]
		[RequiredField]
		[Attribute(Name = "TitleAttribute", RVA = "0x5CBF78", Offset = "0x5CBF78")]
		public FsmObject clip;

		[Token(Token = "0x40047B3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5CC030", Offset = "0x5CC030")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC030", Offset = "0x5CC030")]
		public FsmFloat volume;

		[Token(Token = "0x6005D11")]
		[Address(RVA = "0xB810F4", Offset = "0xB810F4", VA = "0xB810F4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D12")]
		[Address(RVA = "0xB81174", Offset = "0xB81174", VA = "0xB81174", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D13")]
		[Address(RVA = "0xB8119C", Offset = "0xB8119C", VA = "0xB8119C")]
		private void DoPlaySound()
		{
		}

		[Token(Token = "0x6005D14")]
		[Address(RVA = "0xB81378", Offset = "0xB81378", VA = "0xB81378")]
		public PlaySound()
		{
		}
	}
}

using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001069")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1F20", Offset = "0x5A1F20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1F20", Offset = "0x5A1F20")]
	public class GetVertexCount : FsmStateAction
	{
		[Token(Token = "0x4004D05")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E10AC", Offset = "0x5E10AC")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E10AC", Offset = "0x5E10AC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004D06")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1140", Offset = "0x5E1140")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E1140", Offset = "0x5E1140")]
		[RequiredField]
		public FsmInt storeCount;

		[Token(Token = "0x4004D07")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E11A0", Offset = "0x5E11A0")]
		public bool everyFrame;

		[Token(Token = "0x6006206")]
		[Address(RVA = "0xC812B4", Offset = "0xC812B4", VA = "0xC812B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006207")]
		[Address(RVA = "0xC812C0", Offset = "0xC812C0", VA = "0xC812C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006208")]
		[Address(RVA = "0xC81444", Offset = "0xC81444", VA = "0xC81444", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006209")]
		[Address(RVA = "0xC812FC", Offset = "0xC812FC", VA = "0xC812FC")]
		private void DoGetVertexCount()
		{
		}

		[Token(Token = "0x600620A")]
		[Address(RVA = "0xC81448", Offset = "0xC81448", VA = "0xC81448")]
		public GetVertexCount()
		{
		}
	}
}

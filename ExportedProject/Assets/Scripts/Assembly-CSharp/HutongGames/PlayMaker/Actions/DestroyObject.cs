using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FD1")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EF40", Offset = "0x59EF40")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EF40", Offset = "0x59EF40")]
	public class DestroyObject : FsmStateAction
	{
		[Token(Token = "0x4004A71")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6564", Offset = "0x5D6564")]
		[RequiredField]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004A72")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D65B0", Offset = "0x5D65B0")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D65B0", Offset = "0x5D65B0")]
		public FsmFloat delay;

		[Token(Token = "0x4004A73")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6604", Offset = "0x5D6604")]
		public FsmBool detachChildren;

		[Token(Token = "0x6005F7A")]
		[Address(RVA = "0xC13080", Offset = "0xC13080", VA = "0xC13080", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F7B")]
		[Address(RVA = "0xC130B0", Offset = "0xC130B0", VA = "0xC130B0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F7C")]
		[Address(RVA = "0xC13200", Offset = "0xC13200", VA = "0xC13200", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005F7D")]
		[Address(RVA = "0xC13204", Offset = "0xC13204", VA = "0xC13204")]
		public DestroyObject()
		{
		}
	}
}

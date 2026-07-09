using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010D7")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A434C", Offset = "0x5A434C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A434C", Offset = "0x5A434C")]
	public class QuaternionSlerp : QuaternionBaseAction
	{
		[Token(Token = "0x4004F79")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBE4C", Offset = "0x5EBE4C")]
		public FsmQuaternion fromQuaternion;

		[Token(Token = "0x4004F7A")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBE98", Offset = "0x5EBE98")]
		public FsmQuaternion toQuaternion;

		[Token(Token = "0x4004F7B")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBEE4", Offset = "0x5EBEE4")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EBEE4", Offset = "0x5EBEE4")]
		public FsmFloat amount;

		[Token(Token = "0x4004F7C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EBF48", Offset = "0x5EBF48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBF48", Offset = "0x5EBF48")]
		[RequiredField]
		public FsmQuaternion storeResult;

		[Token(Token = "0x600645B")]
		[Address(RVA = "0xB3DB48", Offset = "0xB3DB48", VA = "0xB3DB48", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600645C")]
		[Address(RVA = "0xB3DBF8", Offset = "0xB3DBF8", VA = "0xB3DBF8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600645D")]
		[Address(RVA = "0xB3DCE8", Offset = "0xB3DCE8", VA = "0xB3DCE8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600645E")]
		[Address(RVA = "0xB3DCF8", Offset = "0xB3DCF8", VA = "0xB3DCF8", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x600645F")]
		[Address(RVA = "0xB3DD0C", Offset = "0xB3DD0C", VA = "0xB3DD0C", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006460")]
		[Address(RVA = "0xB3DC34", Offset = "0xB3DC34", VA = "0xB3DC34")]
		private void DoQuatSlerp()
		{
		}

		[Token(Token = "0x6006461")]
		[Address(RVA = "0xB3DD20", Offset = "0xB3DD20", VA = "0xB3DD20")]
		public QuaternionSlerp()
		{
		}
	}
}

using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011AB")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9184", Offset = "0x5A9184")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9184", Offset = "0x5A9184")]
	[Attribute(Name = "HelpUrlAttribute", RVA = "0x5A9184", Offset = "0x5A9184")]
	public class MoveObject : EaseFsmAction
	{
		[Token(Token = "0x400542A")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC874", Offset = "0x5FC874")]
		[RequiredField]
		public FsmOwnerDefault objectToMove;

		[Token(Token = "0x400542B")]
		[FieldOffset(Offset = "0xD0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC8C0", Offset = "0x5FC8C0")]
		public FsmGameObject destination;

		[Token(Token = "0x400542C")]
		[FieldOffset(Offset = "0xD8")]
		private FsmVector3 fromValue;

		[Token(Token = "0x400542D")]
		[FieldOffset(Offset = "0xE0")]
		private FsmVector3 toVector;

		[Token(Token = "0x400542E")]
		[FieldOffset(Offset = "0xE8")]
		private FsmVector3 fromVector;

		[Token(Token = "0x400542F")]
		[FieldOffset(Offset = "0xF0")]
		private bool finishInNextStep;

		[Token(Token = "0x6006806")]
		[Address(RVA = "0xA2FF70", Offset = "0xA2FF70", VA = "0xA2FF70", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006807")]
		[Address(RVA = "0xA2FFA0", Offset = "0xA2FFA0", VA = "0xA2FFA0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006808")]
		[Address(RVA = "0xA30214", Offset = "0xA30214", VA = "0xA30214", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006809")]
		[Address(RVA = "0xA303EC", Offset = "0xA303EC", VA = "0xA303EC")]
		public MoveObject()
		{
		}
	}
}

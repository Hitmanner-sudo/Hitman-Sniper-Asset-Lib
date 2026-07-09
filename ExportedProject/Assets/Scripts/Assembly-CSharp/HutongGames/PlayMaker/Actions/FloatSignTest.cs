using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001023")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0880", Offset = "0x5A0880")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0880", Offset = "0x5A0880")]
	public class FloatSignTest : FsmStateAction
	{
		[Token(Token = "0x4004BBA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DBAF4", Offset = "0x5DBAF4")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBAF4", Offset = "0x5DBAF4")]
		public FsmFloat floatValue;

		[Token(Token = "0x4004BBB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBB54", Offset = "0x5DBB54")]
		public FsmEvent isPositive;

		[Token(Token = "0x4004BBC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBB8C", Offset = "0x5DBB8C")]
		public FsmEvent isNegative;

		[Token(Token = "0x4004BBD")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBBC4", Offset = "0x5DBBC4")]
		public bool everyFrame;

		[Token(Token = "0x60060CF")]
		[Address(RVA = "0x9596A0", Offset = "0x9596A0", VA = "0x9596A0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060D0")]
		[Address(RVA = "0x9596D4", Offset = "0x9596D4", VA = "0x9596D4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060D1")]
		[Address(RVA = "0x959770", Offset = "0x959770", VA = "0x959770", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060D2")]
		[Address(RVA = "0x959710", Offset = "0x959710", VA = "0x959710")]
		private void DoSignTest()
		{
		}

		[Token(Token = "0x60060D3")]
		[Address(RVA = "0x959774", Offset = "0x959774", VA = "0x959774", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x60060D4")]
		[Address(RVA = "0x959848", Offset = "0x959848", VA = "0x959848")]
		public FloatSignTest()
		{
		}
	}
}

using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FF8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FB88", Offset = "0x59FB88")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FB88", Offset = "0x59FB88")]
	public class GetKey : FsmStateAction
	{
		[Token(Token = "0x4004AFB")]
		[FieldOffset(Offset = "0x4C")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8A14", Offset = "0x5D8A14")]
		public KeyCode key;

		[Token(Token = "0x4004AFC")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D8A60", Offset = "0x5D8A60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8A60", Offset = "0x5D8A60")]
		public FsmBool storeResult;

		[Token(Token = "0x4004AFD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8AC0", Offset = "0x5D8AC0")]
		public bool everyFrame;

		[Token(Token = "0x6006019")]
		[Address(RVA = "0x10639F0", Offset = "0x10639F0", VA = "0x10639F0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600601A")]
		[Address(RVA = "0x1063A00", Offset = "0x1063A00", VA = "0x1063A00", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600601B")]
		[Address(RVA = "0x1063A74", Offset = "0x1063A74", VA = "0x1063A74", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600601C")]
		[Address(RVA = "0x1063A3C", Offset = "0x1063A3C", VA = "0x1063A3C")]
		private void DoGetKey()
		{
		}

		[Token(Token = "0x600601D")]
		[Address(RVA = "0x1063A78", Offset = "0x1063A78", VA = "0x1063A78")]
		public GetKey()
		{
		}
	}
}

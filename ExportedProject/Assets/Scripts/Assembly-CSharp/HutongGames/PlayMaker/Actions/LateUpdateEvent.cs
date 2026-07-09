using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200116A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7728", Offset = "0x5A7728")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7728", Offset = "0x5A7728")]
	public class LateUpdateEvent : FsmStateAction
	{
		[Token(Token = "0x40052BA")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7D38", Offset = "0x5F7D38")]
		public FsmEvent sendEvent;

		[Token(Token = "0x60066CA")]
		[Address(RVA = "0x996AEC", Offset = "0x996AEC", VA = "0x996AEC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066CB")]
		[Address(RVA = "0x996AF4", Offset = "0x996AF4", VA = "0x996AF4", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60066CC")]
		[Address(RVA = "0x996B14", Offset = "0x996B14", VA = "0x996B14", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066CD")]
		[Address(RVA = "0x996B18", Offset = "0x996B18", VA = "0x996B18", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60066CE")]
		[Address(RVA = "0x996B50", Offset = "0x996B50", VA = "0x996B50")]
		public LateUpdateEvent()
		{
		}
	}
}

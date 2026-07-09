using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001074")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2260", Offset = "0x5A2260")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2260", Offset = "0x5A2260")]
	public class GetMass : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004D57")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E256C", Offset = "0x5E256C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E256C", Offset = "0x5E256C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004D58")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2600", Offset = "0x5E2600")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2600", Offset = "0x5E2600")]
		public FsmFloat storeResult;

		[Token(Token = "0x6006259")]
		[Address(RVA = "0x1063DD0", Offset = "0x1063DD0", VA = "0x1063DD0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600625A")]
		[Address(RVA = "0x1063DD8", Offset = "0x1063DD8", VA = "0x1063DD8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600625B")]
		[Address(RVA = "0x1063E00", Offset = "0x1063E00", VA = "0x1063E00")]
		private void DoGetMass()
		{
		}

		[Token(Token = "0x600625C")]
		[Address(RVA = "0x1063EA8", Offset = "0x1063EA8", VA = "0x1063EA8")]
		public GetMass()
		{
		}
	}
}

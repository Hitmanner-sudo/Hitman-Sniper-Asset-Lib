using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001013")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A03D0", Offset = "0x5A03D0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A03D0", Offset = "0x5A03D0")]
	public class SetLightRange : ComponentAction<Light>
	{
		[Token(Token = "0x4004B76")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DA884", Offset = "0x5DA884")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA884", Offset = "0x5DA884")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004B77")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA918", Offset = "0x5DA918")]
		public FsmFloat lightRange;

		[Token(Token = "0x4004B78")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA950", Offset = "0x5DA950")]
		public bool everyFrame;

		[Token(Token = "0x6006085")]
		[Address(RVA = "0x103F20C", Offset = "0x103F20C", VA = "0x103F20C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006086")]
		[Address(RVA = "0x103F240", Offset = "0x103F240", VA = "0x103F240", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006087")]
		[Address(RVA = "0x103F33C", Offset = "0x103F33C", VA = "0x103F33C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006088")]
		[Address(RVA = "0x103F27C", Offset = "0x103F27C", VA = "0x103F27C")]
		private void DoSetLightRange()
		{
		}

		[Token(Token = "0x6006089")]
		[Address(RVA = "0x103F340", Offset = "0x103F340", VA = "0x103F340")]
		public SetLightRange()
		{
		}
	}
}

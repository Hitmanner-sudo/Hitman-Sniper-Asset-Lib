using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200108C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2A28", Offset = "0x5A2A28")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2A28", Offset = "0x5A2A28")]
	[Attribute(Name = "SeeAlsoAttribute", RVA = "0x5A2A28", Offset = "0x5A2A28")]
	public class WakeUp : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004DD5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E4B80", Offset = "0x5E4B80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4B80", Offset = "0x5E4B80")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x60062D5")]
		[Address(RVA = "0x97C8C0", Offset = "0x97C8C0", VA = "0x97C8C0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062D6")]
		[Address(RVA = "0x97C8C8", Offset = "0x97C8C8", VA = "0x97C8C8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60062D7")]
		[Address(RVA = "0x97C8F0", Offset = "0x97C8F0", VA = "0x97C8F0")]
		private void DoWakeUp()
		{
		}

		[Token(Token = "0x60062D8")]
		[Address(RVA = "0x97C9A8", Offset = "0x97C9A8", VA = "0x97C9A8")]
		public WakeUp()
		{
		}
	}
}

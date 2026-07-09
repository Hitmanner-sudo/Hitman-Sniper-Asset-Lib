using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200103E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A12F0", Offset = "0x5A12F0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A12F0", Offset = "0x5A12F0")]
	public class SetMaterial : ComponentAction<Renderer>
	{
		[Token(Token = "0x4004C4D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DE318", Offset = "0x5DE318")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE318", Offset = "0x5DE318")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004C4E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE3AC", Offset = "0x5DE3AC")]
		public FsmInt materialIndex;

		[Token(Token = "0x4004C4F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE3E4", Offset = "0x5DE3E4")]
		[RequiredField]
		public FsmMaterial material;

		[Token(Token = "0x6006156")]
		[Address(RVA = "0x103FB08", Offset = "0x103FB08", VA = "0x103FB08", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006157")]
		[Address(RVA = "0x103FB3C", Offset = "0x103FB3C", VA = "0x103FB3C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006158")]
		[Address(RVA = "0x103FB64", Offset = "0x103FB64", VA = "0x103FB64")]
		private void DoSetMaterial()
		{
		}

		[Token(Token = "0x6006159")]
		[Address(RVA = "0x103FD48", Offset = "0x103FD48", VA = "0x103FD48")]
		public SetMaterial()
		{
		}
	}
}

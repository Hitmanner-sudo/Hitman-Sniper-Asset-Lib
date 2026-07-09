using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200108A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2964", Offset = "0x5A2964")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2964", Offset = "0x5A2964")]
	public class UseGravity : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004DD1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4A68", Offset = "0x5E4A68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E4A68", Offset = "0x5E4A68")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004DD2")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4AFC", Offset = "0x5E4AFC")]
		public FsmBool useGravity;

		[Token(Token = "0x60062CC")]
		[Address(RVA = "0xBA2448", Offset = "0xBA2448", VA = "0xBA2448", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062CD")]
		[Address(RVA = "0xBA2478", Offset = "0xBA2478", VA = "0xBA2478", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60062CE")]
		[Address(RVA = "0xBA24A0", Offset = "0xBA24A0", VA = "0xBA24A0")]
		private void DoUseGravity()
		{
		}

		[Token(Token = "0x60062CF")]
		[Address(RVA = "0xBA2564", Offset = "0xBA2564", VA = "0xBA2564")]
		public UseGravity()
		{
		}
	}
}

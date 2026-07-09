using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010AD")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A34E4", Offset = "0x5A34E4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A34E4", Offset = "0x5A34E4")]
	public class SetIsKinematic2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004EE3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E9398", Offset = "0x5E9398")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9398", Offset = "0x5E9398")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004EE4")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E942C", Offset = "0x5E942C")]
		public FsmBool isKinematic;

		[Token(Token = "0x6006385")]
		[Address(RVA = "0x103E8CC", Offset = "0x103E8CC", VA = "0x103E8CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006386")]
		[Address(RVA = "0x103E8FC", Offset = "0x103E8FC", VA = "0x103E8FC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006387")]
		[Address(RVA = "0x103E924", Offset = "0x103E924", VA = "0x103E924")]
		private void DoSetIsKinematic()
		{
		}

		[Token(Token = "0x6006388")]
		[Address(RVA = "0x103E9E8", Offset = "0x103E9E8", VA = "0x103E9E8")]
		public SetIsKinematic2d()
		{
		}
	}
}

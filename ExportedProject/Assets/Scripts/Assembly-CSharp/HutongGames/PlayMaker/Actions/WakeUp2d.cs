using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010B7")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3804", Offset = "0x5A3804")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3804", Offset = "0x5A3804")]
	public class WakeUp2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004F21")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EA43C", Offset = "0x5EA43C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA43C", Offset = "0x5EA43C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x60063C2")]
		[Address(RVA = "0x97C9F4", Offset = "0x97C9F4", VA = "0x97C9F4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063C3")]
		[Address(RVA = "0x97C9FC", Offset = "0x97C9FC", VA = "0x97C9FC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063C4")]
		[Address(RVA = "0x97CA24", Offset = "0x97CA24", VA = "0x97CA24")]
		private void DoWakeUp()
		{
		}

		[Token(Token = "0x60063C5")]
		[Address(RVA = "0x97CAC8", Offset = "0x97CAC8", VA = "0x97CAC8")]
		public WakeUp2d()
		{
		}
	}
}

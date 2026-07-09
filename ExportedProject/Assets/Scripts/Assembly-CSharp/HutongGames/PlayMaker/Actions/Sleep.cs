using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001087")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2874", Offset = "0x5A2874")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2874", Offset = "0x5A2874")]
	public class Sleep : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004DC2")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E4658", Offset = "0x5E4658")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4658", Offset = "0x5E4658")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x60062B2")]
		[Address(RVA = "0x846B5C", Offset = "0x846B5C", VA = "0x846B5C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062B3")]
		[Address(RVA = "0x846B64", Offset = "0x846B64", VA = "0x846B64", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60062B4")]
		[Address(RVA = "0x846B8C", Offset = "0x846B8C", VA = "0x846B8C")]
		private void DoSleep()
		{
		}

		[Token(Token = "0x60062B5")]
		[Address(RVA = "0x846C30", Offset = "0x846C30", VA = "0x846C30")]
		public Sleep()
		{
		}
	}
}

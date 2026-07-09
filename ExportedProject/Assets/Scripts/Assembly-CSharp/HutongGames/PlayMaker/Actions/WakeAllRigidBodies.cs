using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200108B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A29B4", Offset = "0x5A29B4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A29B4", Offset = "0x5A29B4")]
	[Attribute(Name = "SeeAlsoAttribute", RVA = "0x5A29B4", Offset = "0x5A29B4")]
	public class WakeAllRigidBodies : FsmStateAction
	{
		[Token(Token = "0x4004DD3")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4B48", Offset = "0x5E4B48")]
		public bool everyFrame;

		[Token(Token = "0x4004DD4")]
		[FieldOffset(Offset = "0x50")]
		private Rigidbody[] bodies;

		[Token(Token = "0x60062D0")]
		[Address(RVA = "0x97C4E8", Offset = "0x97C4E8", VA = "0x97C4E8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062D1")]
		[Address(RVA = "0x97C4F0", Offset = "0x97C4F0", VA = "0x97C4F0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60062D2")]
		[Address(RVA = "0x97C730", Offset = "0x97C730", VA = "0x97C730", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60062D3")]
		[Address(RVA = "0x97C5F4", Offset = "0x97C5F4", VA = "0x97C5F4")]
		private void DoWakeAll()
		{
		}

		[Token(Token = "0x60062D4")]
		[Address(RVA = "0x97C734", Offset = "0x97C734", VA = "0x97C734")]
		public WakeAllRigidBodies()
		{
		}
	}
}

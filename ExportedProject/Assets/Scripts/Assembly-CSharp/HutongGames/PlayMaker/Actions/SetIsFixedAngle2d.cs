using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010AC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3470", Offset = "0x5A3470")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3470", Offset = "0x5A3470")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x5A3470", Offset = "0x5A3470")]
	public class SetIsFixedAngle2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004EE0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9280", Offset = "0x5E9280")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E9280", Offset = "0x5E9280")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004EE1")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9314", Offset = "0x5E9314")]
		[RequiredField]
		public FsmBool isFixedAngle;

		[Token(Token = "0x4004EE2")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9360", Offset = "0x5E9360")]
		public bool everyFrame;

		[Token(Token = "0x6006380")]
		[Address(RVA = "0x103E5B0", Offset = "0x103E5B0", VA = "0x103E5B0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006381")]
		[Address(RVA = "0x103E5E4", Offset = "0x103E5E4", VA = "0x103E5E4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006382")]
		[Address(RVA = "0x103E714", Offset = "0x103E714", VA = "0x103E714", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006383")]
		[Address(RVA = "0x103E620", Offset = "0x103E620", VA = "0x103E620")]
		private void DoSetIsFixedAngle()
		{
		}

		[Token(Token = "0x6006384")]
		[Address(RVA = "0x103E718", Offset = "0x103E718", VA = "0x103E718")]
		public SetIsFixedAngle2d()
		{
		}
	}
}

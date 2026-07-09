using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F40")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C370", Offset = "0x59C370")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C370", Offset = "0x59C370")]
	public class SetCameraFOV : ComponentAction<Camera>
	{
		[Token(Token = "0x40047F5")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CD004", Offset = "0x5CD004")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD004", Offset = "0x5CD004")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40047F6")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD098", Offset = "0x5CD098")]
		public FsmFloat fieldOfView;

		[Token(Token = "0x40047F7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD0E4", Offset = "0x5CD0E4")]
		public bool everyFrame;

		[Token(Token = "0x6005D58")]
		[Address(RVA = "0x103869C", Offset = "0x103869C", VA = "0x103869C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D59")]
		[Address(RVA = "0x10386D4", Offset = "0x10386D4", VA = "0x10386D4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D5A")]
		[Address(RVA = "0x10387D0", Offset = "0x10387D0", VA = "0x10387D0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D5B")]
		[Address(RVA = "0x1038710", Offset = "0x1038710", VA = "0x1038710")]
		private void DoSetCameraFOV()
		{
		}

		[Token(Token = "0x6005D5C")]
		[Address(RVA = "0x10387D4", Offset = "0x10387D4", VA = "0x10387D4")]
		public SetCameraFOV()
		{
		}
	}
}

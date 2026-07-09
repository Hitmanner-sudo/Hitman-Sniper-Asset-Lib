using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EFE")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AE30", Offset = "0x59AE30")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AE30", Offset = "0x59AE30")]
	public class SetAnimatorPlayBackTime : ComponentAction<Animator>
	{
		[Token(Token = "0x40046F8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C8D68", Offset = "0x5C8D68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8D68", Offset = "0x5C8D68")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046F9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8DFC", Offset = "0x5C8DFC")]
		public FsmFloat playbackTime;

		[Token(Token = "0x40046FA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C8E34", Offset = "0x5C8E34")]
		public bool everyFrame;

		[Token(Token = "0x6005C51")]
		[Address(RVA = "0x1036E18", Offset = "0x1036E18", VA = "0x1036E18", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C52")]
		[Address(RVA = "0x1036E24", Offset = "0x1036E24", VA = "0x1036E24", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C53")]
		[Address(RVA = "0x1036EFC", Offset = "0x1036EFC", VA = "0x1036EFC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005C54")]
		[Address(RVA = "0x1036E60", Offset = "0x1036E60", VA = "0x1036E60")]
		private void DoPlaybackTime()
		{
		}

		[Token(Token = "0x6005C55")]
		[Address(RVA = "0x1036F00", Offset = "0x1036F00", VA = "0x1036F00")]
		public SetAnimatorPlayBackTime()
		{
		}
	}
}

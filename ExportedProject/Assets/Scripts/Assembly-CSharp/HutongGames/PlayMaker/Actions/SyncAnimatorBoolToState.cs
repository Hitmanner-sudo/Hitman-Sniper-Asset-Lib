using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F03")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AFC0", Offset = "0x59AFC0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AFC0", Offset = "0x59AFC0")]
	public class SyncAnimatorBoolToState : ComponentAction<Animator>
	{
		[Token(Token = "0x4004706")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C926C", Offset = "0x5C926C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C926C", Offset = "0x5C926C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004707")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9300", Offset = "0x5C9300")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C9300", Offset = "0x5C9300")]
		public FsmString parameter;

		[Token(Token = "0x4004708")]
		[FieldOffset(Offset = "0x78")]
		private int paramID;

		[Token(Token = "0x17000C21")]
		private Animator animator
		{
			[Token(Token = "0x6005C67")]
			[Address(RVA = "0xB4A0AC", Offset = "0xB4A0AC", VA = "0xB4A0AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005C68")]
		[Address(RVA = "0xB4A0B4", Offset = "0xB4A0B4", VA = "0xB4A0B4", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6005C69")]
		[Address(RVA = "0xB4A0BC", Offset = "0xB4A0BC", VA = "0xB4A0BC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C6A")]
		[Address(RVA = "0xB4A0E4", Offset = "0xB4A0E4", VA = "0xB4A0E4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C6B")]
		[Address(RVA = "0xB4A1A8", Offset = "0xB4A1A8", VA = "0xB4A1A8", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005C6C")]
		[Address(RVA = "0xB4A24C", Offset = "0xB4A24C", VA = "0xB4A24C")]
		public SyncAnimatorBoolToState()
		{
		}
	}
}

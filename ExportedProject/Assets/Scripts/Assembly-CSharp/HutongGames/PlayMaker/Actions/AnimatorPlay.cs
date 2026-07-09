using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EC7")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599DA0", Offset = "0x599DA0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599DA0", Offset = "0x599DA0")]
	public class AnimatorPlay : ComponentAction<Animator>
	{
		[Token(Token = "0x4004601")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C3D2C", Offset = "0x5C3D2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3D2C", Offset = "0x5C3D2C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004602")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3DC0", Offset = "0x5C3DC0")]
		public FsmString stateName;

		[Token(Token = "0x4004603")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3DF8", Offset = "0x5C3DF8")]
		public FsmInt layer;

		[Token(Token = "0x4004604")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3E30", Offset = "0x5C3E30")]
		public FsmFloat normalizedTime;

		[Token(Token = "0x4004605")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3E68", Offset = "0x5C3E68")]
		public bool everyFrame;

		[Token(Token = "0x17000C05")]
		private Animator animator
		{
			[Token(Token = "0x6005B44")]
			[Address(RVA = "0xD477B4", Offset = "0xD477B4", VA = "0xD477B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B45")]
		[Address(RVA = "0xD477BC", Offset = "0xD477BC", VA = "0xD477BC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B46")]
		[Address(RVA = "0xD4786C", Offset = "0xD4786C", VA = "0xD4786C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B47")]
		[Address(RVA = "0xD479C8", Offset = "0xD479C8", VA = "0xD479C8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005B48")]
		[Address(RVA = "0xD478A8", Offset = "0xD478A8", VA = "0xD478A8")]
		private void DoAnimatorPlay()
		{
		}

		[Token(Token = "0x6005B49")]
		[Address(RVA = "0xD479CC", Offset = "0xD479CC", VA = "0xD479CC")]
		public AnimatorPlay()
		{
		}
	}
}

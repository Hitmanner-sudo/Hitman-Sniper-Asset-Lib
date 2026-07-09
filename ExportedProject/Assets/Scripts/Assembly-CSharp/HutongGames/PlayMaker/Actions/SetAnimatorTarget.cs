using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F01")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AF20", Offset = "0x59AF20")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AF20", Offset = "0x59AF20")]
	public class SetAnimatorTarget : ComponentAction<Animator>
	{
		[Token(Token = "0x4004700")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C903C", Offset = "0x5C903C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C903C", Offset = "0x5C903C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004701")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C90D0", Offset = "0x5C90D0")]
		public AvatarTarget avatarTarget;

		[Token(Token = "0x4004702")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9108", Offset = "0x5C9108")]
		public FsmFloat targetNormalizedTime;

		[Token(Token = "0x4004703")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9140", Offset = "0x5C9140")]
		public bool everyFrame;

		[Token(Token = "0x6005C5E")]
		[Address(RVA = "0x1037604", Offset = "0x1037604", VA = "0x1037604", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C5F")]
		[Address(RVA = "0x103761C", Offset = "0x103761C", VA = "0x103761C", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6005C60")]
		[Address(RVA = "0x103763C", Offset = "0x103763C", VA = "0x103763C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C61")]
		[Address(RVA = "0x103771C", Offset = "0x103771C", VA = "0x103771C", Slot = "59")]
		public override void DoAnimatorMove()
		{
		}

		[Token(Token = "0x6005C62")]
		[Address(RVA = "0x1037678", Offset = "0x1037678", VA = "0x1037678")]
		private void SetTarget()
		{
		}

		[Token(Token = "0x6005C63")]
		[Address(RVA = "0x1037720", Offset = "0x1037720", VA = "0x1037720")]
		public SetAnimatorTarget()
		{
		}
	}
}

using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EF3")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AAC0", Offset = "0x59AAC0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AAC0", Offset = "0x59AAC0")]
	public class SetAnimatorBody : ComponentAction<Animator>
	{
		[Token(Token = "0x40046BE")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C7E00", Offset = "0x5C7E00")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7E00", Offset = "0x5C7E00")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046BF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7E94", Offset = "0x5C7E94")]
		public FsmGameObject target;

		[Token(Token = "0x40046C0")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7ECC", Offset = "0x5C7ECC")]
		public FsmVector3 position;

		[Token(Token = "0x40046C1")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7F04", Offset = "0x5C7F04")]
		public FsmQuaternion rotation;

		[Token(Token = "0x40046C2")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7F3C", Offset = "0x5C7F3C")]
		public bool everyFrame;

		[Token(Token = "0x40046C3")]
		[FieldOffset(Offset = "0x90")]
		private GameObject cachedTarget;

		[Token(Token = "0x40046C4")]
		[FieldOffset(Offset = "0x98")]
		private Transform _transform;

		[Token(Token = "0x17000C1B")]
		private Animator animator
		{
			[Token(Token = "0x6005C18")]
			[Address(RVA = "0x1035364", Offset = "0x1035364", VA = "0x1035364")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005C19")]
		[Address(RVA = "0x103536C", Offset = "0x103536C", VA = "0x103536C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C1A")]
		[Address(RVA = "0x103541C", Offset = "0x103541C", VA = "0x103541C", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6005C1B")]
		[Address(RVA = "0x103543C", Offset = "0x103543C", VA = "0x103543C", Slot = "60")]
		public override void DoAnimatorIK(int layerIndex)
		{
		}

		[Token(Token = "0x6005C1C")]
		[Address(RVA = "0x1035478", Offset = "0x1035478", VA = "0x1035478")]
		private void DoSetBody()
		{
		}

		[Token(Token = "0x6005C1D")]
		[Address(RVA = "0x1035760", Offset = "0x1035760", VA = "0x1035760")]
		public SetAnimatorBody()
		{
		}
	}
}

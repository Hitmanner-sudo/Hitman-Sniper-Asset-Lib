using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011AE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9298", Offset = "0x5A9298")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9298", Offset = "0x5A9298")]
	public class SetPosition : ComponentAction<Transform>
	{
		[Token(Token = "0x4005445")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCD3C", Offset = "0x5FCD3C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005446")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCD88", Offset = "0x5FCD88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FCD88", Offset = "0x5FCD88")]
		public FsmVector3 vector;

		[Token(Token = "0x4005447")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCDD8", Offset = "0x5FCDD8")]
		public FsmFloat x;

		[Token(Token = "0x4005448")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCE10", Offset = "0x5FCE10")]
		public FsmFloat y;

		[Token(Token = "0x4005449")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCE48", Offset = "0x5FCE48")]
		public FsmFloat z;

		[Token(Token = "0x400544A")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCE80", Offset = "0x5FCE80")]
		public Space space;

		[Token(Token = "0x400544B")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCEB8", Offset = "0x5FCEB8")]
		public bool everyFrame;

		[Token(Token = "0x400544C")]
		[FieldOffset(Offset = "0x95")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCEF0", Offset = "0x5FCEF0")]
		public bool lateUpdate;

		[Token(Token = "0x6006819")]
		[Address(RVA = "0x104156C", Offset = "0x104156C", VA = "0x104156C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600681A")]
		[Address(RVA = "0x1041630", Offset = "0x1041630", VA = "0x1041630", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x600681B")]
		[Address(RVA = "0x104165C", Offset = "0x104165C", VA = "0x104165C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600681C")]
		[Address(RVA = "0x1041858", Offset = "0x1041858", VA = "0x1041858", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600681D")]
		[Address(RVA = "0x1041868", Offset = "0x1041868", VA = "0x1041868", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x600681E")]
		[Address(RVA = "0x10416A4", Offset = "0x10416A4", VA = "0x10416A4")]
		private void DoSetPosition()
		{
		}

		[Token(Token = "0x600681F")]
		[Address(RVA = "0x10418B0", Offset = "0x10418B0", VA = "0x10418B0")]
		public SetPosition()
		{
		}
	}
}

using HutongGames.PlayMaker.TweenEnums;
using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011D7")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9CB4", Offset = "0x5A9CB4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9CB4", Offset = "0x5A9CB4")]
	public class TweenQuaternion : TweenVariableBase<FsmQuaternion>
	{
		[Token(Token = "0x4005555")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF9E4", Offset = "0x5FF9E4")]
		[Attribute(Name = "DisplayOrderAttribute", RVA = "0x5FF9E4", Offset = "0x5FF9E4")]
		public RotationInterpolation interpolation;

		[Token(Token = "0x60068E9")]
		[Address(RVA = "0x157277C", Offset = "0x157277C", VA = "0x157277C", Slot = "65")]
		protected override object GetOffsetValue(object value, object offset)
		{
			return null;
		}

		[Token(Token = "0x60068EA")]
		[Address(RVA = "0x1572878", Offset = "0x1572878", VA = "0x1572878", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x60068EB")]
		[Address(RVA = "0x1572924", Offset = "0x1572924", VA = "0x1572924")]
		public TweenQuaternion()
		{
		}
	}
}

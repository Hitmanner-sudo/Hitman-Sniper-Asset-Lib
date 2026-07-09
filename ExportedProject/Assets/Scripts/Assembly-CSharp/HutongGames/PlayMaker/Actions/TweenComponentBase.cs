using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011C5")]
	public abstract class TweenComponentBase<T> : TweenActionBase where T : Component
	{
		[Token(Token = "0x40054E5")]
		[FieldOffset(Offset = "0x0")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FF160", Offset = "0x5FF160")]
		[Attribute(Name = "DisplayOrderAttribute", RVA = "0x5FF160", Offset = "0x5FF160")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF160", Offset = "0x5FF160")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40054E6")]
		[FieldOffset(Offset = "0x0")]
		protected GameObject cachedGameObject;

		[Token(Token = "0x40054E7")]
		[FieldOffset(Offset = "0x0")]
		protected T cachedComponent;

		[Token(Token = "0x6006897")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006898")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006899")]
		protected bool UpdateCache(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x600689A")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x600689B")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x600689C")]
		protected TweenComponentBase()
		{
		}
	}
}

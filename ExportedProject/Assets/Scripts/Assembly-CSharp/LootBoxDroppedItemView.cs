using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200068F")]
public abstract class LootBoxDroppedItemView : View
{
	[Serializable]
	[Token(Token = "0x2000690")]
	private struct FocusedData
	{
		[Token(Token = "0x40024C4")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float _alpha;

		[Token(Token = "0x40024C5")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private Vector3 _scale;

		[Token(Token = "0x6002B07")]
		[Address(RVA = "0x8C482C", Offset = "0x8C482C", VA = "0x8C482C")]
		public void Apply(LootBoxDroppedItemView view)
		{
		}
	}

	[Token(Token = "0x2000691")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595998", Offset = "0x595998")]
	private sealed class _003CDoAppearAnimation_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40024C6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40024C7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40024C8")]
		[FieldOffset(Offset = "0x20")]
		public LootBoxDroppedItemView _003C_003E4__this;

		[Token(Token = "0x1700058A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B0B")]
			[Address(RVA = "0x8C3DA0", Offset = "0x8C3DA0", VA = "0x8C3DA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700058B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B0D")]
			[Address(RVA = "0x8C3DE8", Offset = "0x8C3DE8", VA = "0x8C3DE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B08")]
		[Address(RVA = "0x8C3CF0", Offset = "0x8C3CF0", VA = "0x8C3CF0")]
		[DebuggerHidden]
		public _003CDoAppearAnimation_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B09")]
		[Address(RVA = "0x8C3D1C", Offset = "0x8C3D1C", VA = "0x8C3D1C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B0A")]
		[Address(RVA = "0x8C3D20", Offset = "0x8C3D20", VA = "0x8C3D20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B0C")]
		[Address(RVA = "0x8C3DA8", Offset = "0x8C3DA8", VA = "0x8C3DA8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000692")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5959A8", Offset = "0x5959A8")]
	private sealed class _003CDoAppearAnimationInternal_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40024C9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40024CA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40024CB")]
		[FieldOffset(Offset = "0x20")]
		public LootBoxDroppedItemView _003C_003E4__this;

		[Token(Token = "0x1700058C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B11")]
			[Address(RVA = "0x8C3F0C", Offset = "0x8C3F0C", VA = "0x8C3F0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700058D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B13")]
			[Address(RVA = "0x8C3F54", Offset = "0x8C3F54", VA = "0x8C3F54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B0E")]
		[Address(RVA = "0x8C3DF0", Offset = "0x8C3DF0", VA = "0x8C3DF0")]
		[DebuggerHidden]
		public _003CDoAppearAnimationInternal_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B0F")]
		[Address(RVA = "0x8C3E1C", Offset = "0x8C3E1C", VA = "0x8C3E1C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B10")]
		[Address(RVA = "0x8C3E20", Offset = "0x8C3E20", VA = "0x8C3E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B12")]
		[Address(RVA = "0x8C3F14", Offset = "0x8C3F14", VA = "0x8C3F14", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000693")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5959B8", Offset = "0x5959B8")]
	private sealed class _003CFadeInImage_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40024CC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40024CD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40024CE")]
		[FieldOffset(Offset = "0x20")]
		public LootBoxDroppedItemView _003C_003E4__this;

		[Token(Token = "0x40024CF")]
		[FieldOffset(Offset = "0x28")]
		private TweenAlpha _003Calpha_003E5__2;

		[Token(Token = "0x1700058E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B17")]
			[Address(RVA = "0x8C45EC", Offset = "0x8C45EC", VA = "0x8C45EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700058F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B19")]
			[Address(RVA = "0x8C4634", Offset = "0x8C4634", VA = "0x8C4634", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B14")]
		[Address(RVA = "0x8C43C8", Offset = "0x8C43C8", VA = "0x8C43C8")]
		[DebuggerHidden]
		public _003CFadeInImage_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B15")]
		[Address(RVA = "0x8C43F4", Offset = "0x8C43F4", VA = "0x8C43F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B16")]
		[Address(RVA = "0x8C43F8", Offset = "0x8C43F8", VA = "0x8C43F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B18")]
		[Address(RVA = "0x8C45F4", Offset = "0x8C45F4", VA = "0x8C45F4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000694")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5959C8", Offset = "0x5959C8")]
	private sealed class _003CFadeInLabel_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40024D0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40024D1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40024D2")]
		[FieldOffset(Offset = "0x20")]
		public LootBoxDroppedItemView _003C_003E4__this;

		[Token(Token = "0x40024D3")]
		[FieldOffset(Offset = "0x28")]
		private TweenAlpha _003Calpha_003E5__2;

		[Token(Token = "0x17000590")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B1D")]
			[Address(RVA = "0x8C47DC", Offset = "0x8C47DC", VA = "0x8C47DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000591")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B1F")]
			[Address(RVA = "0x8C4824", Offset = "0x8C4824", VA = "0x8C4824", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B1A")]
		[Address(RVA = "0x8C463C", Offset = "0x8C463C", VA = "0x8C463C")]
		[DebuggerHidden]
		public _003CFadeInLabel_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B1B")]
		[Address(RVA = "0x8C4668", Offset = "0x8C4668", VA = "0x8C4668", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B1C")]
		[Address(RVA = "0x8C466C", Offset = "0x8C466C", VA = "0x8C466C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B1E")]
		[Address(RVA = "0x8C47E4", Offset = "0x8C47E4", VA = "0x8C47E4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000695")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5959D8", Offset = "0x5959D8")]
	private sealed class _003CDoCollectAnimation_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40024D4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40024D5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40024D6")]
		[FieldOffset(Offset = "0x20")]
		public LootBoxDroppedItemView _003C_003E4__this;

		[Token(Token = "0x17000592")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B23")]
			[Address(RVA = "0x8C400C", Offset = "0x8C400C", VA = "0x8C400C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000593")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B25")]
			[Address(RVA = "0x8C4054", Offset = "0x8C4054", VA = "0x8C4054", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B20")]
		[Address(RVA = "0x8C3F5C", Offset = "0x8C3F5C", VA = "0x8C3F5C")]
		[DebuggerHidden]
		public _003CDoCollectAnimation_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B21")]
		[Address(RVA = "0x8C3F88", Offset = "0x8C3F88", VA = "0x8C3F88", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B22")]
		[Address(RVA = "0x8C3F8C", Offset = "0x8C3F8C", VA = "0x8C3F8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B24")]
		[Address(RVA = "0x8C4014", Offset = "0x8C4014", VA = "0x8C4014", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000696")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5959E8", Offset = "0x5959E8")]
	private sealed class _003CDoCollectAnimationInternal_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40024D7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40024D8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40024D9")]
		[FieldOffset(Offset = "0x20")]
		public LootBoxDroppedItemView _003C_003E4__this;

		[Token(Token = "0x40024DA")]
		[FieldOffset(Offset = "0x28")]
		private TweenScale _003Cscale_003E5__2;

		[Token(Token = "0x40024DB")]
		[FieldOffset(Offset = "0x30")]
		private TweenAlpha _003Calpha_003E5__3;

		[Token(Token = "0x17000594")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B29")]
			[Address(RVA = "0x8C4378", Offset = "0x8C4378", VA = "0x8C4378", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000595")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B2B")]
			[Address(RVA = "0x8C43C0", Offset = "0x8C43C0", VA = "0x8C43C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B26")]
		[Address(RVA = "0x8C405C", Offset = "0x8C405C", VA = "0x8C405C")]
		[DebuggerHidden]
		public _003CDoCollectAnimationInternal_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B27")]
		[Address(RVA = "0x8C4088", Offset = "0x8C4088", VA = "0x8C4088", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B28")]
		[Address(RVA = "0x8C408C", Offset = "0x8C408C", VA = "0x8C408C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B2A")]
		[Address(RVA = "0x8C4380", Offset = "0x8C4380", VA = "0x8C4380", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40024BE")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private FocusedData _focusedData;

	[Token(Token = "0x40024BF")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private FocusedData _unfocusedData;

	[Token(Token = "0x40024C0")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private int _centerPreference;

	[Token(Token = "0x40024C1")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UILabel _label;

	[Token(Token = "0x40024C2")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UISprite _shadow;

	[Token(Token = "0x40024C3")]
	[FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B91BC", Offset = "0x5B91BC")]
	private bool _003CFocused_003Ek__BackingField;

	[Token(Token = "0x17000584")]
	public bool Focused
	{
		[Token(Token = "0x6002AF5")]
		[Address(RVA = "0x9E2D84", Offset = "0x9E2D84", VA = "0x9E2D84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61E768", Offset = "0x61E768")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002AF6")]
		[Address(RVA = "0x9E2D8C", Offset = "0x9E2D8C", VA = "0x9E2D8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61E778", Offset = "0x61E778")]
		set
		{
		}
	}

	[Token(Token = "0x17000585")]
	public abstract LootBoxDroppedItem Item
	{
		[Token(Token = "0x6002AF7")]
		get;
		[Token(Token = "0x6002AF8")]
		protected set;
	}

	[Token(Token = "0x17000586")]
	public int CenterPreference
	{
		[Token(Token = "0x6002AFA")]
		[Address(RVA = "0x9E2D98", Offset = "0x9E2D98", VA = "0x9E2D98")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000587")]
	protected UILabel Label
	{
		[Token(Token = "0x6002AFB")]
		[Address(RVA = "0x9E2DA0", Offset = "0x9E2DA0", VA = "0x9E2DA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000588")]
	private PopupClaimLootBoxModel.AnimConfig Config
	{
		[Token(Token = "0x6002AFC")]
		[Address(RVA = "0x9E2DA8", Offset = "0x9E2DA8", VA = "0x9E2DA8")]
		get
		{
			return default(PopupClaimLootBoxModel.AnimConfig);
		}
	}

	[Token(Token = "0x17000589")]
	private float AnimationSpeedFactor
	{
		[Token(Token = "0x6002AFD")]
		[Address(RVA = "0x9E2E64", Offset = "0x9E2E64", VA = "0x9E2E64")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6002AF9")]
	public abstract bool CanHandle(LootBoxDroppedItem item);

	[Token(Token = "0x6002AFE")]
	[Address(RVA = "0x9E2EE8", Offset = "0x9E2EE8", VA = "0x9E2EE8", Slot = "18")]
	public virtual LootBoxDroppedItemView Create(LootBoxDroppedItem item, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6002AFF")]
	[Address(RVA = "0x9E2FD4", Offset = "0x9E2FD4", VA = "0x9E2FD4", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002B00")]
	[Address(RVA = "0x9E3014", Offset = "0x9E3014", VA = "0x9E3014")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E788", Offset = "0x61E788")]
	public IEnumerator DoAppearAnimation()
	{
		return null;
	}

	[Token(Token = "0x6002B01")]
	[Address(RVA = "0x9E3080", Offset = "0x9E3080", VA = "0x9E3080", Slot = "19")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E7E8", Offset = "0x61E7E8")]
	protected virtual IEnumerator DoAppearAnimationInternal()
	{
		return null;
	}

	[Token(Token = "0x6002B02")]
	[Address(RVA = "0x9E30EC", Offset = "0x9E30EC", VA = "0x9E30EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E848", Offset = "0x61E848")]
	private IEnumerator FadeInImage()
	{
		return null;
	}

	[Token(Token = "0x6002B03")]
	[Address(RVA = "0x9E3158", Offset = "0x9E3158", VA = "0x9E3158")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E8A8", Offset = "0x61E8A8")]
	private IEnumerator FadeInLabel()
	{
		return null;
	}

	[Token(Token = "0x6002B04")]
	[Address(RVA = "0x9E31C4", Offset = "0x9E31C4", VA = "0x9E31C4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E908", Offset = "0x61E908")]
	public IEnumerator DoCollectAnimation()
	{
		return null;
	}

	[Token(Token = "0x6002B05")]
	[Address(RVA = "0x9E3230", Offset = "0x9E3230", VA = "0x9E3230", Slot = "20")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E968", Offset = "0x61E968")]
	protected virtual IEnumerator DoCollectAnimationInternal()
	{
		return null;
	}

	[Token(Token = "0x6002B06")]
	[Address(RVA = "0x9E2AE8", Offset = "0x9E2AE8", VA = "0x9E2AE8")]
	protected LootBoxDroppedItemView()
	{
	}
}

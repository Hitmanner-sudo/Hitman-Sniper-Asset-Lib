using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005C0")]
public class PopupClaimLootBoxModel : DataModel
{
	[Serializable]
	[Token(Token = "0x20005C1")]
	public struct AnimConfig
	{
		[Token(Token = "0x4001EEA")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float _openingFadeToBlackDuration;

		[Token(Token = "0x4001EEB")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private float _openingFadeFromBlackDuration;

		[Token(Token = "0x4001EEC")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private float _itemsFadeToBlackDuration;

		[Token(Token = "0x4001EED")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private float _itemsFadeFromBlackDuration;

		[Token(Token = "0x4001EEE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _collectButtonAppearDuration;

		[Token(Token = "0x4001EEF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _popupCloseDuration;

		[Token(Token = "0x4001EF0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _preClosePopupDuration;

		[Token(Token = "0x4001EF1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _itemFadeInDuration;

		[Token(Token = "0x4001EF2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _itemLabelFadeInDuration;

		[Token(Token = "0x4001EF3")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _itemCollectFadeOutDuration;

		[Token(Token = "0x4001EF4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _itemLabelScaleOut;

		[Token(Token = "0x17000517")]
		public float OpeningFadeToBlackDuration
		{
			[Token(Token = "0x600248E")]
			[Address(RVA = "0x8AC8C4", Offset = "0x8AC8C4", VA = "0x8AC8C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000518")]
		public float OpeningFadeFromBlackDuration
		{
			[Token(Token = "0x600248F")]
			[Address(RVA = "0x8AC8CC", Offset = "0x8AC8CC", VA = "0x8AC8CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000519")]
		public float ItemsFadeToBlackDuration
		{
			[Token(Token = "0x6002490")]
			[Address(RVA = "0x8AC8D4", Offset = "0x8AC8D4", VA = "0x8AC8D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700051A")]
		public float ItemsFadeFromBlackDuration
		{
			[Token(Token = "0x6002491")]
			[Address(RVA = "0x8AC8DC", Offset = "0x8AC8DC", VA = "0x8AC8DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700051B")]
		public float CollectButtonAppearDuration
		{
			[Token(Token = "0x6002492")]
			[Address(RVA = "0x8AC8E4", Offset = "0x8AC8E4", VA = "0x8AC8E4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700051C")]
		public float PopupCloseDuration
		{
			[Token(Token = "0x6002493")]
			[Address(RVA = "0x8AC8EC", Offset = "0x8AC8EC", VA = "0x8AC8EC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700051D")]
		public float PreClosePopupDuration
		{
			[Token(Token = "0x6002494")]
			[Address(RVA = "0x8AC8F4", Offset = "0x8AC8F4", VA = "0x8AC8F4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700051E")]
		public float ItemFadeInDuration
		{
			[Token(Token = "0x6002495")]
			[Address(RVA = "0x8AC8FC", Offset = "0x8AC8FC", VA = "0x8AC8FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700051F")]
		public float ItemLabelFadeInDuration
		{
			[Token(Token = "0x6002496")]
			[Address(RVA = "0x8AC904", Offset = "0x8AC904", VA = "0x8AC904")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000520")]
		public float ItemCollectFadeOutDuration
		{
			[Token(Token = "0x6002497")]
			[Address(RVA = "0x8AC90C", Offset = "0x8AC90C", VA = "0x8AC90C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000521")]
		public Vector3 ItemLabelScaleOut
		{
			[Token(Token = "0x6002498")]
			[Address(RVA = "0x8AC914", Offset = "0x8AC914", VA = "0x8AC914")]
			get
			{
				return default(Vector3);
			}
		}
	}

	[Token(Token = "0x20005C2")]
	public enum State
	{
		[Token(Token = "0x4001EF6")]
		INTRO_WAIT = 0,
		[Token(Token = "0x4001EF7")]
		INTRO_CANCELLED = 1,
		[Token(Token = "0x4001EF8")]
		POPUP_OPENING = 2,
		[Token(Token = "0x4001EF9")]
		LOOTBOX_OPENING = 3,
		[Token(Token = "0x4001EFA")]
		SHOW_ITEM = 4,
		[Token(Token = "0x4001EFB")]
		POPUP_CLOSING = 5
	}

	[Token(Token = "0x4001EDC")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string LOOT_BOX;

	[Token(Token = "0x4001EDD")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string ON_CLAIMED_CALLBACK;

	[Token(Token = "0x4001EDE")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string STATE;

	[Token(Token = "0x4001EDF")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string SKIP_OPENING_ANIMATION;

	[Token(Token = "0x4001EE0")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string AUTO_CONTINUE_INTRO;

	[Token(Token = "0x4001EE1")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string ANIM_CONFIG;

	[Token(Token = "0x4001EE2")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string ACCELERATE_ANIMATION;

	[NonSerialized]
	[Token(Token = "0x4001EE3")]
	[FieldOffset(Offset = "0x48")]
	private LootBox _lootBox;

	[NonSerialized]
	[Token(Token = "0x4001EE4")]
	[FieldOffset(Offset = "0x50")]
	private Action _onClaimed;

	[NonSerialized]
	[Token(Token = "0x4001EE5")]
	[FieldOffset(Offset = "0x58")]
	private State _currentState;

	[NonSerialized]
	[Token(Token = "0x4001EE6")]
	[FieldOffset(Offset = "0x5C")]
	private bool _skipOpeningAnim;

	[NonSerialized]
	[Token(Token = "0x4001EE7")]
	[FieldOffset(Offset = "0x5D")]
	private bool _autoContinueIntro;

	[NonSerialized]
	[Token(Token = "0x4001EE8")]
	[FieldOffset(Offset = "0x5E")]
	private bool _accelerateAnimation;

	[Token(Token = "0x4001EE9")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AnimConfig _animConfig;

	[Token(Token = "0x600247E")]
	[Address(RVA = "0x92DD7C", Offset = "0x92DD7C", VA = "0x92DD7C", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600247F")]
	[Address(RVA = "0x92E208", Offset = "0x92E208", VA = "0x92E208")]
	public PopupClaimLootBoxModel()
	{
	}

	[Token(Token = "0x6002481")]
	[Address(RVA = "0x92E348", Offset = "0x92E348", VA = "0x92E348")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B450", Offset = "0x61B450")]
	private object _003CBindAllVariables_003Eb__16_0()
	{
		return null;
	}

	[Token(Token = "0x6002482")]
	[Address(RVA = "0x92E350", Offset = "0x92E350", VA = "0x92E350")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B460", Offset = "0x61B460")]
	private void _003CBindAllVariables_003Eb__16_1(object lb)
	{
	}

	[Token(Token = "0x6002483")]
	[Address(RVA = "0x92E3DC", Offset = "0x92E3DC", VA = "0x92E3DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B470", Offset = "0x61B470")]
	private object _003CBindAllVariables_003Eb__16_2()
	{
		return null;
	}

	[Token(Token = "0x6002484")]
	[Address(RVA = "0x92E3E4", Offset = "0x92E3E4", VA = "0x92E3E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B480", Offset = "0x61B480")]
	private void _003CBindAllVariables_003Eb__16_3(object a)
	{
	}

	[Token(Token = "0x6002485")]
	[Address(RVA = "0x92E454", Offset = "0x92E454", VA = "0x92E454")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B490", Offset = "0x61B490")]
	private object _003CBindAllVariables_003Eb__16_4()
	{
		return null;
	}

	[Token(Token = "0x6002486")]
	[Address(RVA = "0x92E4B4", Offset = "0x92E4B4", VA = "0x92E4B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B4A0", Offset = "0x61B4A0")]
	private void _003CBindAllVariables_003Eb__16_5(object s)
	{
	}

	[Token(Token = "0x6002487")]
	[Address(RVA = "0x92E538", Offset = "0x92E538", VA = "0x92E538")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B4B0", Offset = "0x61B4B0")]
	private bool _003CBindAllVariables_003Eb__16_6()
	{
		return default(bool);
	}

	[Token(Token = "0x6002488")]
	[Address(RVA = "0x92E540", Offset = "0x92E540", VA = "0x92E540")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B4C0", Offset = "0x61B4C0")]
	private void _003CBindAllVariables_003Eb__16_7(bool b)
	{
	}

	[Token(Token = "0x6002489")]
	[Address(RVA = "0x92E54C", Offset = "0x92E54C", VA = "0x92E54C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B4D0", Offset = "0x61B4D0")]
	private bool _003CBindAllVariables_003Eb__16_8()
	{
		return default(bool);
	}

	[Token(Token = "0x600248A")]
	[Address(RVA = "0x92E554", Offset = "0x92E554", VA = "0x92E554")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B4E0", Offset = "0x61B4E0")]
	private void _003CBindAllVariables_003Eb__16_9(bool b)
	{
	}

	[Token(Token = "0x600248B")]
	[Address(RVA = "0x92E560", Offset = "0x92E560", VA = "0x92E560")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B4F0", Offset = "0x61B4F0")]
	private object _003CBindAllVariables_003Eb__16_10()
	{
		return null;
	}

	[Token(Token = "0x600248C")]
	[Address(RVA = "0x92E5D0", Offset = "0x92E5D0", VA = "0x92E5D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B500", Offset = "0x61B500")]
	private bool _003CBindAllVariables_003Eb__16_11()
	{
		return default(bool);
	}

	[Token(Token = "0x600248D")]
	[Address(RVA = "0x92E5D8", Offset = "0x92E5D8", VA = "0x92E5D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B510", Offset = "0x61B510")]
	private void _003CBindAllVariables_003Eb__16_12(bool b)
	{
	}
}

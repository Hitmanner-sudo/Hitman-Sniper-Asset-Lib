using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20003D9")]
public class AssignmentData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20003DA")]
	public class FSMGameObject
	{
		[Token(Token = "0x4001595")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4001596")]
		[FieldOffset(Offset = "0x18")]
		public GameObject Value;

		[Token(Token = "0x60017E4")]
		[Address(RVA = "0x923C30", Offset = "0x923C30", VA = "0x923C30")]
		public FSMGameObject()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20003DB")]
	public class FSMProperties
	{
		[Token(Token = "0x20003DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59370C", Offset = "0x59370C")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x400159F")]
			[FieldOffset(Offset = "0x10")]
			public List<FSMProperties> fsmDatas;

			[Token(Token = "0x40015A0")]
			[FieldOffset(Offset = "0x18")]
			public Func<int, FSMProperties> _003C_003E9__1;

			[Token(Token = "0x60017E9")]
			[Address(RVA = "0xA450F0", Offset = "0xA450F0", VA = "0xA450F0")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60017EA")]
			[Address(RVA = "0xA450F8", Offset = "0xA450F8", VA = "0xA450F8")]
			internal FSMProperties _003CInstantiate_003Eb__1(int idx)
			{
				return null;
			}
		}

		[Token(Token = "0x20003DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59371C", Offset = "0x59371C")]
		private sealed class _003C_003Ec__DisplayClass10_1
		{
			[Token(Token = "0x40015A1")]
			[FieldOffset(Offset = "0x10")]
			public FSMGameObject v;

			[Token(Token = "0x60017EB")]
			[Address(RVA = "0xA4516C", Offset = "0xA4516C", VA = "0xA4516C")]
			public _003C_003Ec__DisplayClass10_1()
			{
			}

			[Token(Token = "0x60017EC")]
			[Address(RVA = "0xA45174", Offset = "0xA45174", VA = "0xA45174")]
			internal bool _003CInstantiate_003Eb__0(FsmGameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20003DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59372C", Offset = "0x59372C")]
		private sealed class _003C_003Ec__DisplayClass10_2
		{
			[Token(Token = "0x40015A2")]
			[FieldOffset(Offset = "0x10")]
			public PlayMakerFSM subFsm;

			[Token(Token = "0x60017ED")]
			[Address(RVA = "0xA451A0", Offset = "0xA451A0", VA = "0xA451A0")]
			public _003C_003Ec__DisplayClass10_2()
			{
			}

			[Token(Token = "0x60017EE")]
			[Address(RVA = "0xA451A8", Offset = "0xA451A8", VA = "0xA451A8")]
			internal bool _003CInstantiate_003Eb__2(FSMProperties f)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20003DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59373C", Offset = "0x59373C")]
		private sealed class _003C_003Ec__DisplayClass10_3
		{
			[Token(Token = "0x40015A3")]
			[FieldOffset(Offset = "0x10")]
			public FsmInt v;

			[Token(Token = "0x60017EF")]
			[Address(RVA = "0xA4522C", Offset = "0xA4522C", VA = "0xA4522C")]
			public _003C_003Ec__DisplayClass10_3()
			{
			}

			[Token(Token = "0x60017F0")]
			[Address(RVA = "0xA45234", Offset = "0xA45234", VA = "0xA45234")]
			internal bool _003CInstantiate_003Eb__3(FsmInt x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20003E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59374C", Offset = "0x59374C")]
		private sealed class _003C_003Ec__DisplayClass10_4
		{
			[Token(Token = "0x40015A4")]
			[FieldOffset(Offset = "0x10")]
			public FsmFloat v;

			[Token(Token = "0x60017F1")]
			[Address(RVA = "0xA45260", Offset = "0xA45260", VA = "0xA45260")]
			public _003C_003Ec__DisplayClass10_4()
			{
			}

			[Token(Token = "0x60017F2")]
			[Address(RVA = "0xA45268", Offset = "0xA45268", VA = "0xA45268")]
			internal bool _003CInstantiate_003Eb__4(FsmFloat x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20003E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59375C", Offset = "0x59375C")]
		private sealed class _003C_003Ec__DisplayClass10_5
		{
			[Token(Token = "0x40015A5")]
			[FieldOffset(Offset = "0x10")]
			public FsmBool v;

			[Token(Token = "0x60017F3")]
			[Address(RVA = "0xA45294", Offset = "0xA45294", VA = "0xA45294")]
			public _003C_003Ec__DisplayClass10_5()
			{
			}

			[Token(Token = "0x60017F4")]
			[Address(RVA = "0xA4529C", Offset = "0xA4529C", VA = "0xA4529C")]
			internal bool _003CInstantiate_003Eb__5(FsmBool x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20003E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59376C", Offset = "0x59376C")]
		private sealed class _003C_003Ec__DisplayClass10_6
		{
			[Token(Token = "0x40015A6")]
			[FieldOffset(Offset = "0x10")]
			public FsmString v;

			[Token(Token = "0x60017F5")]
			[Address(RVA = "0xA452C8", Offset = "0xA452C8", VA = "0xA452C8")]
			public _003C_003Ec__DisplayClass10_6()
			{
			}

			[Token(Token = "0x60017F6")]
			[Address(RVA = "0xA452D0", Offset = "0xA452D0", VA = "0xA452D0")]
			internal bool _003CInstantiate_003Eb__6(FsmString x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20003E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59377C", Offset = "0x59377C")]
		private sealed class _003C_003Ec__DisplayClass10_7
		{
			[Token(Token = "0x40015A7")]
			[FieldOffset(Offset = "0x10")]
			public FsmArray v;

			[Token(Token = "0x60017F7")]
			[Address(RVA = "0xA452FC", Offset = "0xA452FC", VA = "0xA452FC")]
			public _003C_003Ec__DisplayClass10_7()
			{
			}

			[Token(Token = "0x60017F8")]
			[Address(RVA = "0xA45304", Offset = "0xA45304", VA = "0xA45304")]
			internal bool _003CInstantiate_003Eb__7(FsmArray x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4001597")]
		[FieldOffset(Offset = "0x10")]
		public PlayMakerFSM FSM;

		[Token(Token = "0x4001598")]
		[FieldOffset(Offset = "0x18")]
		public List<FSMGameObject> GameObjects;

		[Token(Token = "0x4001599")]
		[FieldOffset(Offset = "0x20")]
		public List<FsmInt> Ints;

		[Token(Token = "0x400159A")]
		[FieldOffset(Offset = "0x28")]
		public List<FsmBool> Bools;

		[Token(Token = "0x400159B")]
		[FieldOffset(Offset = "0x30")]
		public List<FsmArray> Arrays;

		[Token(Token = "0x400159C")]
		[FieldOffset(Offset = "0x38")]
		public List<FsmString> Strings;

		[Token(Token = "0x400159D")]
		[FieldOffset(Offset = "0x40")]
		public List<FsmFloat> Floats;

		[Token(Token = "0x400159E")]
		[FieldOffset(Offset = "0x48")]
		public List<int> SubFSMs;

		[Token(Token = "0x60017E5")]
		[Address(RVA = "0x923C38", Offset = "0x923C38", VA = "0x923C38")]
		public static PlayMakerFSM Instantiate(List<FSMProperties> fsmDatas, int startIdx)
		{
			return null;
		}

		[Token(Token = "0x60017E6")]
		[Address(RVA = "0x923CB4", Offset = "0x923CB4", VA = "0x923CB4")]
		public PlayMakerFSM InstantiateInternal(List<FSMProperties> fsmDatas, int startIdx)
		{
			return null;
		}

		[Token(Token = "0x60017E7")]
		[Address(RVA = "0x923D08", Offset = "0x923D08", VA = "0x923D08")]
		public static PlayMakerFSM Instantiate(PlayMakerFSM original, Transform parent, List<FSMProperties> fsmDatas, int startIdx)
		{
			return null;
		}

		[Token(Token = "0x60017E8")]
		[Address(RVA = "0x924F74", Offset = "0x924F74", VA = "0x924F74")]
		public FSMProperties()
		{
		}
	}

	[Token(Token = "0x400157F")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public List<FSMProperties> FSMDatas;

	[Token(Token = "0x4001580")]
	[FieldOffset(Offset = "0x20")]
	public int TargetValue;

	[Token(Token = "0x4001581")]
	[FieldOffset(Offset = "0x24")]
	public int TargetValue2;

	[Token(Token = "0x4001582")]
	[FieldOffset(Offset = "0x28")]
	public string Description;

	[Token(Token = "0x4001583")]
	[FieldOffset(Offset = "0x30")]
	public string SubDescription;

	[Token(Token = "0x4001584")]
	[FieldOffset(Offset = "0x38")]
	public string Restriction;

	[Token(Token = "0x4001585")]
	[FieldOffset(Offset = "0x40")]
	public string HUDDescription;

	[Token(Token = "0x4001586")]
	[FieldOffset(Offset = "0x48")]
	public int[] HUDDescriptionFormatNumber;

	[Token(Token = "0x4001587")]
	[FieldOffset(Offset = "0x50")]
	public string HUDSubDescription;

	[Token(Token = "0x4001588")]
	[FieldOffset(Offset = "0x58")]
	public int[] HUDSubDescriptionFormatNumber;

	[Token(Token = "0x4001589")]
	[FieldOffset(Offset = "0x60")]
	public bool FailOnSubObjective;

	[Token(Token = "0x400158A")]
	[FieldOffset(Offset = "0x68")]
	public string HUDRestriction;

	[Token(Token = "0x400158B")]
	[FieldOffset(Offset = "0x70")]
	public int[] HUDRestrictionFormatNumber;

	[Token(Token = "0x400158C")]
	[FieldOffset(Offset = "0x78")]
	public TutorialSubObjective[] TutorialObjectives;

	[Token(Token = "0x400158D")]
	[FieldOffset(Offset = "0x80")]
	public bool ShowInGameProgressCounter;

	[Token(Token = "0x400158E")]
	[FieldOffset(Offset = "0x81")]
	public bool ShowInGameProgressCounter2;

	[NonSerialized]
	[Token(Token = "0x400158F")]
	[FieldOffset(Offset = "0x88")]
	public AssignmentSaveData SaveData;

	[NonSerialized]
	[Token(Token = "0x4001590")]
	[FieldOffset(Offset = "0x90")]
	public bool Failed;

	[NonSerialized]
	[Token(Token = "0x4001591")]
	[FieldOffset(Offset = "0x94")]
	public int LastProgress;

	[NonSerialized]
	[Token(Token = "0x4001592")]
	[FieldOffset(Offset = "0x98")]
	public int LastProgress2;

	[NonSerialized]
	[Token(Token = "0x4001593")]
	[FieldOffset(Offset = "0x9C")]
	public bool SucceededOnLoad;

	[Token(Token = "0x4001594")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B5130", Offset = "0x5B5130")]
	private int _003CNumStarsRewarded_003Ek__BackingField;

	[Token(Token = "0x170003D1")]
	public int NumStarsRewarded
	{
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0xC01590", Offset = "0xC01590", VA = "0xC01590")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617504", Offset = "0x617504")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60017D0")]
		[Address(RVA = "0xC01598", Offset = "0xC01598", VA = "0xC01598")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617514", Offset = "0x617514")]
		private set
		{
		}
	}

	[Token(Token = "0x170003D2")]
	public bool JustSucceeded
	{
		[Token(Token = "0x60017D1")]
		[Address(RVA = "0xC015A0", Offset = "0xC015A0", VA = "0xC015A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003D3")]
	public bool Succeeded
	{
		[Token(Token = "0x60017D2")]
		[Address(RVA = "0xC015F0", Offset = "0xC015F0", VA = "0xC015F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003D4")]
	public bool WasEverSucceeded
	{
		[Token(Token = "0x60017D3")]
		[Address(RVA = "0xC0160C", Offset = "0xC0160C", VA = "0xC0160C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003D5")]
	public bool Skipped
	{
		[Token(Token = "0x60017D4")]
		[Address(RVA = "0xC01654", Offset = "0xC01654", VA = "0xC01654")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0xC01670", Offset = "0xC01670", VA = "0xC01670")]
		set
		{
		}
	}

	[Token(Token = "0x170003D6")]
	public int Progress
	{
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0xC013C8", Offset = "0xC013C8", VA = "0xC013C8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60017D7")]
		[Address(RVA = "0xC01690", Offset = "0xC01690", VA = "0xC01690")]
		set
		{
		}
	}

	[Token(Token = "0x170003D7")]
	public int Progress2
	{
		[Token(Token = "0x60017D8")]
		[Address(RVA = "0xC013E4", Offset = "0xC013E4", VA = "0xC013E4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60017D9")]
		[Address(RVA = "0xC017D0", Offset = "0xC017D0", VA = "0xC017D0")]
		set
		{
		}
	}

	[Token(Token = "0x60017CE")]
	[Address(RVA = "0xC01580", Offset = "0xC01580", VA = "0xC01580")]
	public PlayMakerFSM Instantiate()
	{
		return null;
	}

	[Token(Token = "0x60017DA")]
	[Address(RVA = "0xC016B0", Offset = "0xC016B0", VA = "0xC016B0")]
	private void SetProgressData(ref int progress, int value)
	{
	}

	[Token(Token = "0x60017DB")]
	[Address(RVA = "0xC0185C", Offset = "0xC0185C", VA = "0xC0185C")]
	public void Complete(bool fromSkip)
	{
	}

	[Token(Token = "0x60017DC")]
	[Address(RVA = "0xC018E4", Offset = "0xC018E4", VA = "0xC018E4")]
	public void Reset()
	{
	}

	[Token(Token = "0x60017DD")]
	[Address(RVA = "0xC01954", Offset = "0xC01954", VA = "0xC01954")]
	public void ResetProgression()
	{
	}

	[Token(Token = "0x60017DE")]
	[Address(RVA = "0xC019AC", Offset = "0xC019AC", VA = "0xC019AC")]
	public void ResetOnLoad()
	{
	}

	[Token(Token = "0x60017DF")]
	[Address(RVA = "0xC017F0", Offset = "0xC017F0", VA = "0xC017F0")]
	public bool IsProgressCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x60017E0")]
	[Address(RVA = "0xC01A10", Offset = "0xC01A10", VA = "0xC01A10")]
	public bool IsProgressCompleted(int progress, int progress2)
	{
		return default(bool);
	}

	[Token(Token = "0x60017E1")]
	[Address(RVA = "0xC01A3C", Offset = "0xC01A3C", VA = "0xC01A3C")]
	public void ResetToLastProgress()
	{
	}

	[Token(Token = "0x60017E2")]
	[Address(RVA = "0xC01AA4", Offset = "0xC01AA4", VA = "0xC01AA4")]
	public int RewardStars()
	{
		return default(int);
	}

	[Token(Token = "0x60017E3")]
	[Address(RVA = "0xC01AC8", Offset = "0xC01AC8", VA = "0xC01AC8")]
	public AssignmentData()
	{
	}
}

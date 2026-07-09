using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200059D")]
[ExecuteInEditMode]
public abstract class DataModel : ScriptableObject
{
	[Token(Token = "0x200059E")]
	public class VariableChangedEventArgs : EventArgs
	{
		[Token(Token = "0x4001D99")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B803C", Offset = "0x5B803C")]
		private string _003CName_003Ek__BackingField;

		[Token(Token = "0x4001D9A")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B804C", Offset = "0x5B804C")]
		private object _003CPreviousValue_003Ek__BackingField;

		[Token(Token = "0x4001D9B")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B805C", Offset = "0x5B805C")]
		private object _003CNewValue_003Ek__BackingField;

		[Token(Token = "0x170004F8")]
		public string Name
		{
			[Token(Token = "0x600232B")]
			[Address(RVA = "0x86AD2C", Offset = "0x86AD2C", VA = "0x86AD2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A2A0", Offset = "0x61A2A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600232C")]
			[Address(RVA = "0x86AD34", Offset = "0x86AD34", VA = "0x86AD34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A2B0", Offset = "0x61A2B0")]
			set
			{
			}
		}

		[Token(Token = "0x170004F9")]
		public virtual object PreviousValue
		{
			[Token(Token = "0x600232D")]
			[Address(RVA = "0x86AD3C", Offset = "0x86AD3C", VA = "0x86AD3C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A2C0", Offset = "0x61A2C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600232E")]
			[Address(RVA = "0x86AD44", Offset = "0x86AD44", VA = "0x86AD44", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A2D0", Offset = "0x61A2D0")]
			set
			{
			}
		}

		[Token(Token = "0x170004FA")]
		public virtual object NewValue
		{
			[Token(Token = "0x600232F")]
			[Address(RVA = "0x86AD4C", Offset = "0x86AD4C", VA = "0x86AD4C", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A2E0", Offset = "0x61A2E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002330")]
			[Address(RVA = "0x86AD54", Offset = "0x86AD54", VA = "0x86AD54", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A2F0", Offset = "0x61A2F0")]
			set
			{
			}
		}

		[Token(Token = "0x6002331")]
		[Address(RVA = "0x86A6FC", Offset = "0x86A6FC", VA = "0x86A6FC")]
		public VariableChangedEventArgs()
		{
		}
	}

	[Token(Token = "0x200059F")]
	public class IntVariableChangedEventArgs : VariableChangedEventArgs
	{
		[Token(Token = "0x4001D9C")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B806C", Offset = "0x5B806C")]
		private int _003CPreviousIntValue_003Ek__BackingField;

		[Token(Token = "0x4001D9D")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B807C", Offset = "0x5B807C")]
		private int _003CNewIntValue_003Ek__BackingField;

		[Token(Token = "0x170004FB")]
		public override object PreviousValue
		{
			[Token(Token = "0x6002332")]
			[Address(RVA = "0x86AB40", Offset = "0x86AB40", VA = "0x86AB40", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002333")]
			[Address(RVA = "0x86ABA0", Offset = "0x86ABA0", VA = "0x86ABA0", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x170004FC")]
		public override object NewValue
		{
			[Token(Token = "0x6002334")]
			[Address(RVA = "0x86AC24", Offset = "0x86AC24", VA = "0x86AC24", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002335")]
			[Address(RVA = "0x86AC84", Offset = "0x86AC84", VA = "0x86AC84", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170004FD")]
		public int PreviousIntValue
		{
			[Token(Token = "0x6002336")]
			[Address(RVA = "0x86AD08", Offset = "0x86AD08", VA = "0x86AD08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A300", Offset = "0x61A300")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002337")]
			[Address(RVA = "0x86AD10", Offset = "0x86AD10", VA = "0x86AD10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A310", Offset = "0x61A310")]
			set
			{
			}
		}

		[Token(Token = "0x170004FE")]
		public int NewIntValue
		{
			[Token(Token = "0x6002338")]
			[Address(RVA = "0x86AD18", Offset = "0x86AD18", VA = "0x86AD18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A320", Offset = "0x61A320")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002339")]
			[Address(RVA = "0x86AD20", Offset = "0x86AD20", VA = "0x86AD20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A330", Offset = "0x61A330")]
			set
			{
			}
		}

		[Token(Token = "0x600233A")]
		[Address(RVA = "0x86AD28", Offset = "0x86AD28", VA = "0x86AD28")]
		public IntVariableChangedEventArgs()
		{
		}
	}

	[Token(Token = "0x20005A0")]
	public class BoolVariableChangedEventArgs : VariableChangedEventArgs
	{
		[Token(Token = "0x4001D9E")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B808C", Offset = "0x5B808C")]
		private bool _003CPreviousBoolValue_003Ek__BackingField;

		[Token(Token = "0x4001D9F")]
		[FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B809C", Offset = "0x5B809C")]
		private bool _003CNewBoolValue_003Ek__BackingField;

		[Token(Token = "0x170004FF")]
		public override object PreviousValue
		{
			[Token(Token = "0x600233B")]
			[Address(RVA = "0x86A760", Offset = "0x86A760", VA = "0x86A760", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600233C")]
			[Address(RVA = "0x86A7C0", Offset = "0x86A7C0", VA = "0x86A7C0", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000500")]
		public override object NewValue
		{
			[Token(Token = "0x600233D")]
			[Address(RVA = "0x86A844", Offset = "0x86A844", VA = "0x86A844", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600233E")]
			[Address(RVA = "0x86A8A4", Offset = "0x86A8A4", VA = "0x86A8A4", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000501")]
		public bool PreviousBoolValue
		{
			[Token(Token = "0x600233F")]
			[Address(RVA = "0x86A928", Offset = "0x86A928", VA = "0x86A928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A340", Offset = "0x61A340")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002340")]
			[Address(RVA = "0x86A930", Offset = "0x86A930", VA = "0x86A930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A350", Offset = "0x61A350")]
			set
			{
			}
		}

		[Token(Token = "0x17000502")]
		public bool NewBoolValue
		{
			[Token(Token = "0x6002341")]
			[Address(RVA = "0x86A93C", Offset = "0x86A93C", VA = "0x86A93C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A360", Offset = "0x61A360")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002342")]
			[Address(RVA = "0x86A944", Offset = "0x86A944", VA = "0x86A944")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A370", Offset = "0x61A370")]
			set
			{
			}
		}

		[Token(Token = "0x6002343")]
		[Address(RVA = "0x86A950", Offset = "0x86A950", VA = "0x86A950")]
		public BoolVariableChangedEventArgs()
		{
		}
	}

	[Token(Token = "0x20005A1")]
	public class FloatVariableChangedEventArgs : VariableChangedEventArgs
	{
		[Token(Token = "0x4001DA0")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B80AC", Offset = "0x5B80AC")]
		private float _003CPreviousFloatValue_003Ek__BackingField;

		[Token(Token = "0x4001DA1")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B80BC", Offset = "0x5B80BC")]
		private float _003CNewFloatValue_003Ek__BackingField;

		[Token(Token = "0x17000503")]
		public override object PreviousValue
		{
			[Token(Token = "0x6002344")]
			[Address(RVA = "0x86A954", Offset = "0x86A954", VA = "0x86A954", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002345")]
			[Address(RVA = "0x86A9B4", Offset = "0x86A9B4", VA = "0x86A9B4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000504")]
		public override object NewValue
		{
			[Token(Token = "0x6002346")]
			[Address(RVA = "0x86AA38", Offset = "0x86AA38", VA = "0x86AA38", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002347")]
			[Address(RVA = "0x86AA98", Offset = "0x86AA98", VA = "0x86AA98", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000505")]
		public float PreviousFloatValue
		{
			[Token(Token = "0x6002348")]
			[Address(RVA = "0x86AB1C", Offset = "0x86AB1C", VA = "0x86AB1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A380", Offset = "0x61A380")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002349")]
			[Address(RVA = "0x86AB24", Offset = "0x86AB24", VA = "0x86AB24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A390", Offset = "0x61A390")]
			set
			{
			}
		}

		[Token(Token = "0x17000506")]
		public float NewFloatValue
		{
			[Token(Token = "0x600234A")]
			[Address(RVA = "0x86AB2C", Offset = "0x86AB2C", VA = "0x86AB2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A3A0", Offset = "0x61A3A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600234B")]
			[Address(RVA = "0x86AB34", Offset = "0x86AB34", VA = "0x86AB34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A3B0", Offset = "0x61A3B0")]
			set
			{
			}
		}

		[Token(Token = "0x600234C")]
		[Address(RVA = "0x86AB3C", Offset = "0x86AB3C", VA = "0x86AB3C")]
		public FloatVariableChangedEventArgs()
		{
		}
	}

	[Token(Token = "0x20005A2")]
	public delegate T GetVariableDelegate<out T>();

	[Token(Token = "0x20005A3")]
	public delegate void SetVariableDelegate<in T>(T value);

	[Token(Token = "0x20005A4")]
	protected class VariableContainer<T>
	{
		[Token(Token = "0x4001DA2")]
		[FieldOffset(Offset = "0x0")]
		public GetVariableDelegate<T> Get;

		[Token(Token = "0x4001DA3")]
		[FieldOffset(Offset = "0x0")]
		public SetVariableDelegate<T> Set;

		[Token(Token = "0x6002355")]
		public VariableContainer()
		{
		}
	}

	[Token(Token = "0x20005A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59537C", Offset = "0x59537C")]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		[Token(Token = "0x4001DA4")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4001DA5")]
		[FieldOffset(Offset = "0x18")]
		public int previousValue;

		[Token(Token = "0x4001DA6")]
		[FieldOffset(Offset = "0x1C")]
		public int value;

		[Token(Token = "0x6002356")]
		[Address(RVA = "0x86A620", Offset = "0x86A620", VA = "0x86A620")]
		public _003C_003Ec__DisplayClass34_0()
		{
		}

		[Token(Token = "0x6002357")]
		[Address(RVA = "0x86A628", Offset = "0x86A628", VA = "0x86A628")]
		internal VariableChangedEventArgs _003CIncrementVariable_003Eb__0()
		{
			return null;
		}
	}

	[Token(Token = "0x4001D93")]
	[FieldOffset(Offset = "0x18")]
	public bool IsAsset;

	[Token(Token = "0x4001D95")]
	[FieldOffset(Offset = "0x28")]
	private readonly Dictionary<string, VariableContainer<object>> _variables;

	[Token(Token = "0x4001D96")]
	[FieldOffset(Offset = "0x30")]
	private readonly Dictionary<string, VariableContainer<bool>> _boolVariables;

	[Token(Token = "0x4001D97")]
	[FieldOffset(Offset = "0x38")]
	private readonly Dictionary<string, VariableContainer<int>> _intVariables;

	[Token(Token = "0x4001D98")]
	[FieldOffset(Offset = "0x40")]
	private readonly Dictionary<string, VariableContainer<float>> _floatVariables;

	[Token(Token = "0x1400008D")]
	public event EventHandler<VariableChangedEventArgs> OnVariableChanged
	{
		[Token(Token = "0x6002309")]
		[Address(RVA = "0xAE2F08", Offset = "0xAE2F08", VA = "0xAE2F08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A280", Offset = "0x61A280")]
		add
		{
		}
		[Token(Token = "0x600230A")]
		[Address(RVA = "0xAE2FA8", Offset = "0xAE2FA8", VA = "0xAE2FA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A290", Offset = "0x61A290")]
		remove
		{
		}
	}

	[Token(Token = "0x600230B")]
	[Address(RVA = "0xAE3048", Offset = "0xAE3048", VA = "0xAE3048")]
	public void FireVariableChanged(object sender, VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x600230C")]
	[Address(RVA = "0xAE30AC", Offset = "0xAE30AC", VA = "0xAE30AC", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600230D")]
	[Address(RVA = "0xAE30B8", Offset = "0xAE30B8", VA = "0xAE30B8")]
	public bool HasVariable(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x600230E")]
	[Address(RVA = "0xAE31B4", Offset = "0xAE31B4", VA = "0xAE31B4")]
	public bool TryGetVariable(string name, out int value)
	{
		return default(bool);
	}

	[Token(Token = "0x600230F")]
	[Address(RVA = "0xAE3278", Offset = "0xAE3278", VA = "0xAE3278")]
	public bool TryGetVariable(string name, out bool value)
	{
		return default(bool);
	}

	[Token(Token = "0x6002310")]
	[Address(RVA = "0xAE333C", Offset = "0xAE333C", VA = "0xAE333C")]
	public bool TryGetVariable(string name, out float value)
	{
		return default(bool);
	}

	[Token(Token = "0x6002311")]
	public bool TryGetVariable<T>(string name, out T value)
	{
		return default(bool);
	}

	[Token(Token = "0x6002312")]
	public T GetVariable<T>(string name)
	{
		return (T)null;
	}

	[Token(Token = "0x6002313")]
	[Address(RVA = "0xAE33FC", Offset = "0xAE33FC", VA = "0xAE33FC")]
	public int GetIntVariable(string name)
	{
		return default(int);
	}

	[Token(Token = "0x6002314")]
	[Address(RVA = "0xAE3488", Offset = "0xAE3488", VA = "0xAE3488")]
	public bool GetBoolVariable(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6002315")]
	[Address(RVA = "0xAE3514", Offset = "0xAE3514", VA = "0xAE3514")]
	public float GetFloatVariable(string name)
	{
		return default(float);
	}

	[Token(Token = "0x6002316")]
	[Address(RVA = "0xAE35A0", Offset = "0xAE35A0", VA = "0xAE35A0")]
	public void SetVariable(string name, int value)
	{
	}

	[Token(Token = "0x6002317")]
	[Address(RVA = "0xAE3704", Offset = "0xAE3704", VA = "0xAE3704")]
	public void SetVariable(string name, bool value)
	{
	}

	[Token(Token = "0x6002318")]
	[Address(RVA = "0xAE3878", Offset = "0xAE3878", VA = "0xAE3878")]
	public void SetVariable(string name, float value)
	{
	}

	[Token(Token = "0x6002319")]
	[Address(RVA = "0xAE3A1C", Offset = "0xAE3A1C", VA = "0xAE3A1C")]
	public void SetVariable(string name, object value)
	{
	}

	[Token(Token = "0x600231A")]
	[Address(RVA = "0xAE35A8", Offset = "0xAE35A8", VA = "0xAE35A8")]
	public void SetVariable(string name, int value, bool forceSet)
	{
	}

	[Token(Token = "0x600231B")]
	[Address(RVA = "0xAE3710", Offset = "0xAE3710", VA = "0xAE3710")]
	public void SetVariable(string name, bool value, bool forceSet)
	{
	}

	[Token(Token = "0x600231C")]
	[Address(RVA = "0xAE3880", Offset = "0xAE3880", VA = "0xAE3880")]
	public void SetVariable(string name, float value, bool forceSet)
	{
	}

	[Token(Token = "0x600231D")]
	[Address(RVA = "0xAE3A24", Offset = "0xAE3A24", VA = "0xAE3A24")]
	public void SetVariable(string name, object value, bool forceSet)
	{
	}

	[Token(Token = "0x600231E")]
	[Address(RVA = "0xAE3BD4", Offset = "0xAE3BD4", VA = "0xAE3BD4")]
	public void IncrementVariable(string name, int step)
	{
	}

	[Token(Token = "0x600231F")]
	[Address(RVA = "0xAE3D68", Offset = "0xAE3D68", VA = "0xAE3D68")]
	public void AddVariable(string name, GetVariableDelegate<int> get, SetVariableDelegate<int> set)
	{
	}

	[Token(Token = "0x6002320")]
	[Address(RVA = "0xADE228", Offset = "0xADE228", VA = "0xADE228")]
	public void AddVariable(string name, GetVariableDelegate<bool> get, SetVariableDelegate<bool> set)
	{
	}

	[Token(Token = "0x6002321")]
	[Address(RVA = "0xAE3E28", Offset = "0xAE3E28", VA = "0xAE3E28")]
	public void AddVariable(string name, GetVariableDelegate<float> get, SetVariableDelegate<float> set)
	{
	}

	[Token(Token = "0x6002322")]
	[Address(RVA = "0xAE3EE8", Offset = "0xAE3EE8", VA = "0xAE3EE8")]
	public void AddVariable(string name, GetVariableDelegate<object> get, SetVariableDelegate<object> set)
	{
	}

	[Token(Token = "0x6002323")]
	private static void ReadonlySet<T>(T o)
	{
	}

	[Token(Token = "0x6002324")]
	[Address(RVA = "0xAE3FA8", Offset = "0xAE3FA8", VA = "0xAE3FA8")]
	public void AddVariable(string name, GetVariableDelegate<int> get)
	{
	}

	[Token(Token = "0x6002325")]
	[Address(RVA = "0xAE4050", Offset = "0xAE4050", VA = "0xAE4050")]
	public void AddVariable(string name, GetVariableDelegate<bool> get)
	{
	}

	[Token(Token = "0x6002326")]
	[Address(RVA = "0xAE40F8", Offset = "0xAE40F8", VA = "0xAE40F8")]
	public void AddVariable(string name, GetVariableDelegate<float> get)
	{
	}

	[Token(Token = "0x6002327")]
	[Address(RVA = "0xADE2E8", Offset = "0xADE2E8", VA = "0xADE2E8")]
	public void AddVariable(string name, GetVariableDelegate<object> get)
	{
	}

	[Token(Token = "0x6002328")]
	[Address(RVA = "0xAE41A0", Offset = "0xAE41A0", VA = "0xAE41A0")]
	public void RemoveVariable(string name)
	{
	}

	[Token(Token = "0x6002329")]
	protected abstract void BindAllVariables();

	[Token(Token = "0x600232A")]
	[Address(RVA = "0xADE394", Offset = "0xADE394", VA = "0xADE394")]
	protected DataModel()
	{
	}
}

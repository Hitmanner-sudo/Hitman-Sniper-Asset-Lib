using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20000C0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x592350", Offset = "0x592350")]
public class AIController : Controller
{
	[Token(Token = "0x20000C1")]
	public class BehaviourEventArgs : EventArgs
	{
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B03CC", Offset = "0x5B03CC")]
		private AIController _003CController_003Ek__BackingField;

		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B03DC", Offset = "0x5B03DC")]
		private AIBehaviour _003CNewBehaviour_003Ek__BackingField;

		[Token(Token = "0x17000126")]
		public AIController Controller
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x910490", Offset = "0x910490", VA = "0x910490")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611FD0", Offset = "0x611FD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x910498", Offset = "0x910498", VA = "0x910498")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611FE0", Offset = "0x611FE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000127")]
		public AIBehaviour NewBehaviour
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x9104A0", Offset = "0x9104A0", VA = "0x9104A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611FF0", Offset = "0x611FF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x9104A8", Offset = "0x9104A8", VA = "0x9104A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612000", Offset = "0x612000")]
			set
			{
			}
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x9104B0", Offset = "0x9104B0", VA = "0x9104B0")]
		public BehaviourEventArgs()
		{
		}
	}

	[Token(Token = "0x20000C2")]
	public enum AttitudeType
	{
		[Token(Token = "0x4000497")]
		Average = 0,
		[Token(Token = "0x4000498")]
		Brave = 1,
		[Token(Token = "0x4000499")]
		Coward = 2
	}

	[Token(Token = "0x4000484")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B033C", Offset = "0x5B033C")]
	private ThirdPersonCharacter _003CCharacter_003Ek__BackingField;

	[Token(Token = "0x4000485")]
	[FieldOffset(Offset = "0x58")]
	public bool visibleWithInstinct;

	[Token(Token = "0x4000486")]
	[FieldOffset(Offset = "0x59")]
	public bool IsHeadGuard;

	[Token(Token = "0x4000487")]
	[FieldOffset(Offset = "0x60")]
	private AIBehaviour _behaviour;

	[Token(Token = "0x4000489")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B035C", Offset = "0x5B035C")]
	private Type _003CLastBehaviour_003Ek__BackingField;

	[Token(Token = "0x400048A")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B036C", Offset = "0x5B036C")]
	private Type _003CPreDotedBehaviour_003Ek__BackingField;

	[Token(Token = "0x400048B")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B037C", Offset = "0x5B037C")]
	private List<Type> _003CLastTaskTypes_003Ek__BackingField;

	[Token(Token = "0x400048C")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B038C", Offset = "0x5B038C")]
	private Trackable _003CTrackable_003Ek__BackingField;

	[Token(Token = "0x400048D")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B039C", Offset = "0x5B039C")]
	private AITaskList _003CTasks_003Ek__BackingField;

	[Token(Token = "0x400048E")]
	[FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B03AC", Offset = "0x5B03AC")]
	private Memory _003CMemory_003Ek__BackingField;

	[Token(Token = "0x400048F")]
	[FieldOffset(Offset = "0x98")]
	public AlertLevel AutoEquipPistolWhen;

	[Token(Token = "0x4000490")]
	[FieldOffset(Offset = "0x9C")]
	public AttitudeType Attitude;

	[Token(Token = "0x4000491")]
	[FieldOffset(Offset = "0xA0")]
	private EvaluationComponent _evaluator;

	[Token(Token = "0x4000492")]
	[FieldOffset(Offset = "0xA8")]
	[NavMeshLayer]
	public int NavigationMask;

	[NonSerialized]
	[Token(Token = "0x4000493")]
	[FieldOffset(Offset = "0xAC")]
	public bool SkipReactBehaviour;

	[Token(Token = "0x1700011C")]
	public new ThirdPersonCharacter Character
	{
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xA93328", Offset = "0xA93328", VA = "0xA93328")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611ED0", Offset = "0x611ED0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xA93330", Offset = "0xA93330", VA = "0xA93330")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611EE0", Offset = "0x611EE0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700011D")]
	public AIBehaviour Behaviour
	{
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xA93338", Offset = "0xA93338", VA = "0xA93338")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xA93340", Offset = "0xA93340", VA = "0xA93340")]
		set
		{
		}
	}

	[Token(Token = "0x1700011E")]
	public Vector3 DisplayPosition
	{
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xA935A4", Offset = "0xA935A4", VA = "0xA935A4")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700011F")]
	public Transform Head
	{
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xA935CC", Offset = "0xA935CC", VA = "0xA935CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000120")]
	public Type LastBehaviour
	{
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xA935E8", Offset = "0xA935E8", VA = "0xA935E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611F10", Offset = "0x611F10")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xA935F0", Offset = "0xA935F0", VA = "0xA935F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611F20", Offset = "0x611F20")]
		private set
		{
		}
	}

	[Token(Token = "0x17000121")]
	public Type PreDotedBehaviour
	{
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xA935F8", Offset = "0xA935F8", VA = "0xA935F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611F30", Offset = "0x611F30")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xA93600", Offset = "0xA93600", VA = "0xA93600")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611F40", Offset = "0x611F40")]
		set
		{
		}
	}

	[Token(Token = "0x17000122")]
	public List<Type> LastTaskTypes
	{
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xA93608", Offset = "0xA93608", VA = "0xA93608")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611F50", Offset = "0x611F50")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xA93610", Offset = "0xA93610", VA = "0xA93610")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611F60", Offset = "0x611F60")]
		private set
		{
		}
	}

	[Token(Token = "0x17000123")]
	public Trackable Trackable
	{
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xA939DC", Offset = "0xA939DC", VA = "0xA939DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611F70", Offset = "0x611F70")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xA939E4", Offset = "0xA939E4", VA = "0xA939E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611F80", Offset = "0x611F80")]
		set
		{
		}
	}

	[Token(Token = "0x17000124")]
	public AITaskList Tasks
	{
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xA939EC", Offset = "0xA939EC", VA = "0xA939EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611F90", Offset = "0x611F90")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xA939F4", Offset = "0xA939F4", VA = "0xA939F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611FA0", Offset = "0x611FA0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000125")]
	public Memory Memory
	{
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xA939FC", Offset = "0xA939FC", VA = "0xA939FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611FB0", Offset = "0x611FB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xA93A04", Offset = "0xA93A04", VA = "0xA93A04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611FC0", Offset = "0x611FC0")]
		private set
		{
		}
	}

	[Token(Token = "0x14000007")]
	public static event EventHandler<BehaviourEventArgs> BehaviourCallback
	{
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xA9342C", Offset = "0xA9342C", VA = "0xA9342C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611EF0", Offset = "0x611EF0")]
		add
		{
		}
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xA934E8", Offset = "0xA934E8", VA = "0xA934E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611F00", Offset = "0x611F00")]
		remove
		{
		}
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0xA93618", Offset = "0xA93618", VA = "0xA93618", Slot = "14")]
	public override void SetCharacter(Character character)
	{
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0xA93A0C", Offset = "0xA93A0C", VA = "0xA93A0C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0xA93CA0", Offset = "0xA93CA0", VA = "0xA93CA0")]
	private void OnAlertChanged(object sender, AISensorManager.AlertLevelChangedArgs alertLevelChangedArgs)
	{
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0xA93E18", Offset = "0xA93E18", VA = "0xA93E18")]
	private void OnIsScaredChanged(object sender, AISensorManager.IsScaredChangedArgs isScaredChangedArgs)
	{
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0xA93F48", Offset = "0xA93F48", VA = "0xA93F48", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0xA941F4", Offset = "0xA941F4", VA = "0xA941F4", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60005E5")]
	[Address(RVA = "0xA93F70", Offset = "0xA93F70", VA = "0xA93F70")]
	public void AssignTrackable()
	{
	}

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0xA94698", Offset = "0xA94698", VA = "0xA94698")]
	private void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0xA94994", Offset = "0xA94994", VA = "0xA94994", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0xA94AF0", Offset = "0xA94AF0", VA = "0xA94AF0")]
	private void Inventory_OnItemBroken(object sender, Inventory.ItemBrokenArgs args)
	{
	}

	[Token(Token = "0x60005E9")]
	[Address(RVA = "0xA94B78", Offset = "0xA94B78", VA = "0xA94B78")]
	private void OnInflictDamage(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60005EA")]
	[Address(RVA = "0xA94C80", Offset = "0xA94C80", VA = "0xA94C80", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x60005EB")]
	[Address(RVA = "0xA94F38", Offset = "0xA94F38", VA = "0xA94F38")]
	public TaskMoveTo MoveToPoint(Vector3 destination, string id)
	{
		return null;
	}

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0xA94FC8", Offset = "0xA94FC8", VA = "0xA94FC8")]
	public void SetupTagIndicator(object sender, IndicatorView.SetupIndicatorEventArgs args)
	{
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0xA9531C", Offset = "0xA9531C", VA = "0xA9531C")]
	public void StopEvalutation()
	{
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0xA95338", Offset = "0xA95338", VA = "0xA95338")]
	public AIController()
	{
	}
}

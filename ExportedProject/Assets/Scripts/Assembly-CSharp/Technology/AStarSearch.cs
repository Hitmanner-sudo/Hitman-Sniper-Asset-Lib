using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A63")]
	public class AStarSearch<TNode, TContext> where TNode : AStarSearch<TNode, TContext>.ISearchNode
	{
		[Token(Token = "0x2000A64")]
		public enum Status
		{
			[Token(Token = "0x4003648")]
			Pending = 0,
			[Token(Token = "0x4003649")]
			Succeeded = 1,
			[Token(Token = "0x400364A")]
			NoPath = 2
		}

		[Token(Token = "0x2000A65")]
		public interface ISearchNode
		{
			[Token(Token = "0x60041B6")]
			IEnumerable<Connection> GetConnections(TContext context);

			[Token(Token = "0x60041B7")]
			float EstimateCostToDestination(TNode destination, TContext context);
		}

		[Token(Token = "0x2000A66")]
		public struct Connection
		{
			[Token(Token = "0x400364B")]
			[FieldOffset(Offset = "0x0")]
			public TNode ToNode;

			[Token(Token = "0x400364C")]
			[FieldOffset(Offset = "0x0")]
			public float Cost;

			[Token(Token = "0x60041B8")]
			public Connection(TNode node, float cost)
			{
			}
		}

		[Token(Token = "0x2000A67")]
		public class Result
		{
			[Token(Token = "0x400364D")]
			[FieldOffset(Offset = "0x0")]
			public Status Status;

			[Token(Token = "0x400364E")]
			[FieldOffset(Offset = "0x0")]
			public TNode[] Path;

			[Token(Token = "0x400364F")]
			[FieldOffset(Offset = "0x0")]
			public float Cost;

			[Token(Token = "0x60041B9")]
			public Result(Status status)
			{
			}
		}

		[Token(Token = "0x2000A68")]
		private class ExpandedNode : IComparable<ExpandedNode>
		{
			[Token(Token = "0x4003650")]
			[FieldOffset(Offset = "0x0")]
			public TNode Node;

			[Token(Token = "0x4003651")]
			[FieldOffset(Offset = "0x0")]
			public float CostFromStart;

			[Token(Token = "0x4003652")]
			[FieldOffset(Offset = "0x0")]
			public float CostToDestination;

			[Token(Token = "0x4003653")]
			[FieldOffset(Offset = "0x0")]
			private ExpandedNode m_Parent;

			[Token(Token = "0x4003654")]
			[FieldOffset(Offset = "0x0")]
			public int NbExpansions;

			[Token(Token = "0x1700086E")]
			public float TotalCost
			{
				[Token(Token = "0x60041BD")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700086F")]
			public ExpandedNode Parent
			{
				[Token(Token = "0x60041BE")]
				get
				{
					return null;
				}
				[Token(Token = "0x60041BF")]
				set
				{
				}
			}

			[Token(Token = "0x60041BA")]
			public ExpandedNode(TNode n)
			{
			}

			[Token(Token = "0x60041BB")]
			public ExpandedNode(TNode n, float costFromStart, float costToDestination, ExpandedNode parent)
			{
			}

			[Token(Token = "0x60041BC")]
			public int CompareTo(ExpandedNode other)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000A69")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597A24", Offset = "0x597A24")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4003655")]
			[FieldOffset(Offset = "0x0")]
			public Connection connection;

			[Token(Token = "0x60041C0")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60041C1")]
			internal bool _003CStep_003Eb__0(TNode x)
			{
				return default(bool);
			}

			[Token(Token = "0x60041C2")]
			internal bool _003CStep_003Eb__1(ExpandedNode x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4003642")]
		[FieldOffset(Offset = "0x0")]
		public float MaxCost;

		[Token(Token = "0x4003643")]
		[FieldOffset(Offset = "0x0")]
		private TNode _destination;

		[Token(Token = "0x4003644")]
		[FieldOffset(Offset = "0x0")]
		private TContext _context;

		[Token(Token = "0x4003645")]
		[FieldOffset(Offset = "0x0")]
		private List<ExpandedNode> _openList;

		[Token(Token = "0x4003646")]
		[FieldOffset(Offset = "0x0")]
		private List<TNode> _closedList;

		[Token(Token = "0x60041B0")]
		public AStarSearch(TNode start, TNode destination, TContext context)
		{
		}

		[Token(Token = "0x60041B1")]
		public AStarSearch(TNode[] starts, TNode destination, TContext context)
		{
		}

		[Token(Token = "0x60041B2")]
		public Result Step()
		{
			return null;
		}

		[Token(Token = "0x60041B3")]
		public Result Resolve()
		{
			return null;
		}

		[Token(Token = "0x60041B4")]
		private void InsertOpenNode(ExpandedNode newNode)
		{
		}

		[Token(Token = "0x60041B5")]
		private Result BuildPath(ExpandedNode node)
		{
			return null;
		}
	}
}

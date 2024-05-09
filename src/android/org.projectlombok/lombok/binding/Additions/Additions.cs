
#nullable restore
using System;
using System.Collections;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Lombok.Core.Debug
{
    partial class DebugSnapshot
    {
        int global::Java.Lang.IComparable.CompareTo(global::Java.Lang.Object o)
        {
            return o is DebugSnapshot s ? CompareTo(s) : -1;
        }
    }
}
namespace Org.Objectweb.Asm.Tree.Analysis
{
    partial class BasicInterpreter
    {
        public override Java.Lang.Object? BinaryOperation(AbstractInsnNode? p0, Java.Lang.Object? p1, Java.Lang.Object? p2)
            => BinaryOperation(p0, p1 as BasicValue, p2 as BasicValue);
        public override Java.Lang.Object? CopyOperation(AbstractInsnNode? p0, Java.Lang.Object? p1)
            => CopyOperation(p0, p1 as BasicValue);
        public override Java.Lang.Object? Merge(Java.Lang.Object? p0, Java.Lang.Object? p1)
            => Merge(p0 as BasicValue, p1 as BasicValue);
        public override Java.Lang.Object? NaryOperation(AbstractInsnNode? p0, IList? p1)
            => NaryOperation(p0, p1?.Cast<BasicValue>().ToList());
        public override Java.Lang.Object? NewValue(global::Org.Objectweb.Asm.Type? type)
            => CreateNewValue(type);
        public override Java.Lang.Object? TernaryOperation(AbstractInsnNode? p0, Java.Lang.Object? p1, Java.Lang.Object? p2, Java.Lang.Object? p3)
            => TernaryOperation(p0, p1 as BasicValue, p2 as BasicValue, p3 as BasicValue);
        public override Java.Lang.Object? UnaryOperation(AbstractInsnNode? p0, Java.Lang.Object? p1)
            => UnaryOperation(p0, p1 as BasicValue);
        public override void ReturnOperation(AbstractInsnNode? p0, Java.Lang.Object? p1, Java.Lang.Object? p2)
            => ReturnOperation(p0, p1 as BasicValue, p2 as BasicValue);
        public override unsafe global::Java.Lang.Object? NewOperation(global::Org.Objectweb.Asm.Tree.AbstractInsnNode? insn)
            => CreateNewOperation(insn);
    }
    partial class SourceInterpreter
    {
        public override Java.Lang.Object? BinaryOperation(AbstractInsnNode? p0, Java.Lang.Object? p1, Java.Lang.Object? p2)
            => BinaryOperation(p0, p1 as SourceValue, p2 as SourceValue);
        public override Java.Lang.Object? CopyOperation(AbstractInsnNode? p0, Java.Lang.Object? p1)
            => CopyOperation(p0, p1 as SourceValue);
        public override Java.Lang.Object? Merge(Java.Lang.Object? p0, Java.Lang.Object? p1)
            => Merge(p0 as SourceValue, p1 as SourceValue);
        public override Java.Lang.Object? NaryOperation(AbstractInsnNode? p0, IList? p1)
            => NaryOperation(p0, p1?.Cast<SourceValue>().ToList());
        public override Java.Lang.Object? NewValue(global::Org.Objectweb.Asm.Type? type)
            => CreateNewValue(type);
        public override Java.Lang.Object? TernaryOperation(AbstractInsnNode? p0, Java.Lang.Object? p1, Java.Lang.Object? p2, Java.Lang.Object? p3)
            => TernaryOperation(p0, p1 as SourceValue, p2 as SourceValue, p3 as SourceValue);
        public override Java.Lang.Object? UnaryOperation(AbstractInsnNode? p0, Java.Lang.Object? p1)
            => UnaryOperation(p0, p1 as SourceValue);
        public override void ReturnOperation(AbstractInsnNode? p0, Java.Lang.Object? p1, Java.Lang.Object? p2)
            => ReturnOperation(p0, p1 as BasicValue, p2 as SourceValue);
        public override unsafe global::Java.Lang.Object? NewOperation(global::Org.Objectweb.Asm.Tree.AbstractInsnNode? insn)
            => CreateNewOperation(insn);
    }
}
namespace Org.Objectweb.Asm.Tree
{
    partial class InsnList : global::Java.Lang.IIterable
    {
        Java.Util.IIterator IIterable.Iterator() => Iterator();
    }
}
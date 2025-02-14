﻿//HintName: Generator.Equals.Tests.Records.NullableEquality.Sample.Generator.Equals.g.cs

#nullable enable
#pragma warning disable CS0612,CS0618

namespace Generator.Equals.Tests.Records
{
    partial class NullableEquality
    {
        partial record Sample
        {
            /// <inheritdoc/>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public virtual bool Equals(global::Generator.Equals.Tests.Records.NullableEquality.Sample? other)
            {
                return
                    !ReferenceEquals(other, null) && EqualityContract == other.EqualityContract
                    && global::Generator.Equals.OrderedEqualityComparer<string>.Default.Equals(this.Addresses!, other.Addresses!)
                    ;
            }
            
            /// <inheritdoc/>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public override int GetHashCode()
            {
                var hashCode = new global::System.HashCode();
                
                hashCode.Add(this.EqualityContract);
                hashCode.Add(
                    this.Addresses!,
                    global::Generator.Equals.OrderedEqualityComparer<string>.Default);
                
                return hashCode.ToHashCode();
            }
        }
    }
}

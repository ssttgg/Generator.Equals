﻿//HintName: Generator.Equals.Tests.Records.PrimitiveEquality.Sample.Generator.Equals.g.cs

#nullable enable
#pragma warning disable CS0612,CS0618

namespace Generator.Equals.Tests.Records
{
    partial class PrimitiveEquality
    {
        partial record Sample
        {
            /// <inheritdoc/>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public virtual bool Equals(global::Generator.Equals.Tests.Records.PrimitiveEquality.Sample? other)
            {
                return
                    !ReferenceEquals(other, null) && EqualityContract == other.EqualityContract
                    && global::System.Collections.Generic.EqualityComparer<global::System.String>.Default.Equals(this.Name!, other.Name!)
                    && global::System.Collections.Generic.EqualityComparer<global::System.Int32>.Default.Equals(this.Age!, other.Age!)
                    ;
            }
            
            /// <inheritdoc/>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public override int GetHashCode()
            {
                var hashCode = new global::System.HashCode();
                
                hashCode.Add(this.EqualityContract);
                hashCode.Add(
                    this.Name!,
                    global::System.Collections.Generic.EqualityComparer<global::System.String>.Default);
                hashCode.Add(
                    this.Age!,
                    global::System.Collections.Generic.EqualityComparer<global::System.Int32>.Default);
                
                return hashCode.ToHashCode();
            }
        }
    }
}

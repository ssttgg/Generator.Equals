﻿//HintName: Generator.Equals.Tests.RecordStructs.ExplicitMode.Sample.Generator.Equals.g.cs

#nullable enable
#pragma warning disable CS0612,CS0618

namespace Generator.Equals.Tests.RecordStructs
{
    partial class ExplicitMode
    {
        partial record struct Sample
        {
            /// <inheritdoc/>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public bool Equals(global::Generator.Equals.Tests.RecordStructs.ExplicitMode.Sample other)
            {
                return true
                    && global::System.Collections.Generic.EqualityComparer<global::System.Int32>.Default.Equals(this.Age!, other.Age!)
                    ;
            }
            
            /// <inheritdoc/>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public override int GetHashCode()
            {
                var hashCode = new global::System.HashCode();
                
                hashCode.Add(
                    this.Age!,
                    global::System.Collections.Generic.EqualityComparer<global::System.Int32>.Default);
                
                return hashCode.ToHashCode();
            }
        }
    }
}

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using NUnit.Framework;
using X10D.Performant.MemberInfoExtensions;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="Performant.MemberInfoExtensions.MemberInfoExtensions"/>.
    /// </summary>
    public class MemberInfoTests
    {
        /// <summary>
        ///     Test for <see cref="Performant.MemberInfoExtensions.MemberInfoExtensions.GetDefaultValue{T}"/>.
        /// </summary>
        [Test]
        public void GetDefaultValue()
        {
            foreach (FieldInfo field in typeof(TestClass).GetFields())
            {
                Assert.AreEqual("Foo", field.GetDefaultValue<string>());
            }
        }

        /// <summary>
        ///     Test for <see cref="Performant.MemberInfoExtensions.MemberInfoExtensions.GetDefaultValue"/>.
        /// </summary>
        [Test]
        public void GetDefaultValueObj()
        {
            foreach (FieldInfo field in typeof(TestClass).GetFields())
            {
                Assert.AreEqual("Foo", field.GetDefaultValue());
            }
        }

        /// <summary>
        ///     Test for <see cref="Performant.MemberInfoExtensions.MemberInfoExtensions.GetDescription"/>.
        /// </summary>
        [Test]
        public void GetDescription()
        {
            foreach (FieldInfo field in typeof(TestClass).GetFields())
            {
                Assert.AreEqual("Test description", field.GetDescription());
            }
        }

        /// <summary>
        ///     Test for <see cref="Performant.MemberInfoExtensions.MemberInfoExtensions.GetDescription"/>.
        /// </summary>
        [Test]
        public void SelectFromCustomAttribute()
        {
            foreach (FieldInfo field in typeof(TestClass).GetFields())
            {
                string value = field.SelectFromCustomAttribute<SampleAttribute, string>(a => a?.TestValue);
                Assert.AreEqual("Bar", value);
            }
        }

        [AttributeUsage(AttributeTargets.Field)]
        private sealed class SampleAttribute : Attribute
        {
            public string TestValue { get; set; }
        }

        private sealed class TestClass
        {
            #pragma warning disable 649
            [SuppressMessage("ReSharper", "UnusedMember.Local", Justification = "Used in Reflection")]
            [System.ComponentModel.Description("Test description")]
            [DefaultValue("Foo")]
            [Sample(TestValue = "Bar")]
            public string TestField;
            #pragma warning restore 649
        }
    }
}
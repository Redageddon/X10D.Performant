using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="MemberInfoExtensions"/>.
    /// </summary>
    public class MemberInfoTests
    {
        /// <summary>
        ///     Test for <see cref="MemberInfoExtensions.GetDefaultValue{T}"/>.
        /// </summary>
        [Test]
        public void GetDefaultValue()
        {
            TestClass klass = new();

            foreach (PropertyInfo property in klass.GetType().GetProperties())
            {
                Assert.AreEqual("Foo", property.GetDefaultValue<string>());
            }
        }

        /// <summary>
        ///     Test for <see cref="MemberInfoExtensions.GetDefaultValue"/>.
        /// </summary>
        [Test]
        public void GetDefaultValueObj()
        {
            TestClass klass = new();

            foreach (PropertyInfo property in klass.GetType().GetProperties())
            {
                Assert.AreEqual("Foo", property.GetDefaultValue());
            }
        }

        /// <summary>
        ///     Test for <see cref="MemberInfoExtensions.GetDescription"/>.
        /// </summary>
        [Test]
        public void GetDescription()
        {
            TestClass klass = new();

            foreach (PropertyInfo property in klass.GetType().GetProperties())
            {
                Assert.AreEqual("Test description", property.GetDescription());
            }
        }

        /// <summary>
        ///     Test for <see cref="MemberInfoExtensions.GetDescription"/>.
        /// </summary>
        [Test]
        public void SelectFromCustomAttribute()
        {
            TestClass klass = new();

            foreach (PropertyInfo property in klass.GetType().GetProperties())
            {
                string value = property.SelectFromCustomAttribute<SampleAttribute, string>(a => a?.TestValue);
                Assert.AreEqual("Bar", value);
            }
        }

        [AttributeUsage(AttributeTargets.Property)]
        private sealed class SampleAttribute : Attribute
        {
            public string TestValue { get; set; }
        }

        private sealed class TestClass
        {
            [SuppressMessage("ReSharper", "UnusedMember.Local", Justification = "Used in Reflection")]
            [System.ComponentModel.Description("Test description")]
            [DefaultValue("Foo")]
            [Sample(TestValue = "Bar")]
            public string TestProperty { get; set; }
        }
    }
}
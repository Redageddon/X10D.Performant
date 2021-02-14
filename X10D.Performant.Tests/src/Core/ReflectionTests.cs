using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="MemberInfoExtensions"/>.
    /// </summary>
    [TestClass]
    public class ReflectionTests
    {
        /// <summary>
        ///     Test for <see cref="MemberInfoExtensions.GetDefaultValue{T}"/>.
        /// </summary>
        [TestMethod]
        public void GetDefaultValue()
        {
            TestClass klass = new();

            foreach (PropertyInfo property in klass.GetType().GetProperties())
            {
                Assert.AreEqual("Foo", property.GetDefaultValue<string>());
            }
        }

        /// <summary>
        ///     Test for <see cref="MemberInfoExtensions.GetDescription"/>.
        /// </summary>
        [TestMethod]
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
        [TestMethod]
        public void SelectFromCustomAttribute()
        {
            TestClass klass = new();

            foreach (PropertyInfo property in klass.GetType().GetProperties())
            {
                string value = property.SelectFromCustomAttribute<TestAttribute, string>(a => a?.TestValue);
                Assert.AreEqual("Bar", value);
            }
        }

        [AttributeUsage(AttributeTargets.Property)]
        private sealed class TestAttribute : Attribute
        {
            public string TestValue { get; set; }
        }

        private sealed class TestClass
        {
            [SuppressMessage("ReSharper", "UnusedMember.Local", Justification = "Used in Reflection")]
            [System.ComponentModel.Description("Test description")]
            [DefaultValue("Foo")]
            [Test(TestValue = "Bar")]
            public string TestProperty { get; set; }
        }
    }
}
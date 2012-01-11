﻿/*
Copyright (c) 2012 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoonUnit.Attributes;
using MoonUnit;
using Utilities.Validation.Rules;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Linq.Expressions;
using Utilities.Validation.Exceptions;

namespace UnitTests.Validation.Rules
{
    public class Custom
    {
        [Test]
        public void Test()
        {
            Utilities.Validation.Rules.Custom<ClassA, int> TestObject = new Custom<ClassA, int>(x => x.ItemA, x => MyAction(x));
            ClassA Temp = new ClassA();
            Temp.ItemA = 1;
            Assert.DoesNotThrow<Exception>(() => TestObject.Validate(Temp));
            Temp = null;
            Assert.Throws<NotValid>(() => TestObject.Validate(Temp));
        }

        public void MyAction(ClassA Param)
        {
            if (Param == null)
                throw new NotValid("Error");
        }
    }

}

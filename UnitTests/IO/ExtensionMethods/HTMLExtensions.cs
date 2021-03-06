﻿/*
Copyright (c) 2014 <a href="http://www.gutgames.com">James Craig</a>

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

using Utilities.IO;
using Xunit;

namespace UnitTests.IO.ExtensionMethods
{
    public class MinificationExtensions
    {
        [Fact]
        public void CSSMinify()
        {
            string FileContent = new Utilities.IO.FileInfo(@"..\..\Data\Web\RandomCSS.css").Read();
            string MinifiedFileContent = new Utilities.IO.FileInfo(@"..\..\Data\Web\RandomCSS.css").Minify(MinificationType.CSS);
            Assert.NotEqual(FileContent.Length, MinifiedFileContent.Length);
            Assert.True(FileContent.Length > MinifiedFileContent.Length);
        }

        [Fact]
        public void HTMLMinify()
        {
            string FileContent = new Utilities.IO.FileInfo(@"..\..\Data\Web\HanselmanSite.html").Read();
            string MinifiedFileContent = new Utilities.IO.FileInfo(@"..\..\Data\Web\HanselmanSite.html").Minify(MinificationType.HTML);
            Assert.NotEqual(FileContent.Length, MinifiedFileContent.Length);
            Assert.True(FileContent.Length > MinifiedFileContent.Length);
        }

        [Fact]
        public void JavaScriptMinify()
        {
            string FileContent = new Utilities.IO.FileInfo(@"..\..\Data\Web\RandomJS.js").Read();
            string MinifiedFileContent = new Utilities.IO.FileInfo(@"..\..\Data\Web\RandomJS.js").Minify(MinificationType.JavaScript);
            Assert.NotEqual(FileContent.Length, MinifiedFileContent.Length);
            Assert.True(FileContent.Length > MinifiedFileContent.Length);
        }
    }
}
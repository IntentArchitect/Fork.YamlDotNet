﻿// This file is part of YamlDotNet - A .NET library for YAML.
// Copyright (c) Antoine Aubry and contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
// of the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Collections.Generic;
using YamlDotNet.Core.Events;
using YamlDotNet.RepresentationModel;

namespace YamlDotNet.Core
{
    /// <summary>
    /// Represents a YAML stream parser.
    /// </summary>
    public interface IParser
    {
        /// <summary>
        /// Gets the current event. Returns null before the first call to <see cref="MoveNext" />,
        /// and also after <see cref="MoveNext" /> returns false.
        /// </summary>
        ParsingEvent? Current { get; }

        public List<YamlComment> CurrentComments();

        /// <summary>
        /// Moves to the next event.
        /// </summary>
        /// <returns>Returns true if there are more events available, otherwise returns false.</returns>
        bool MoveNext();
    }
}

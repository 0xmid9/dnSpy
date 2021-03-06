﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Tagging;

namespace dnSpy.Contracts.Text.Tagging {
	/// <summary>
	/// Synchronous <see cref="IBufferTagAggregatorFactoryService"/>
	/// </summary>
	interface ISynchronousBufferTagAggregatorFactoryService : IBufferTagAggregatorFactoryService {
		/// <summary>
		/// Creates a <see cref="ISynchronousTagAggregator{T}"/>
		/// </summary>
		/// <typeparam name="T">Tag type</typeparam>
		/// <param name="textBuffer">Text buffer</param>
		/// <returns></returns>
		ISynchronousTagAggregator<T> CreateSynchronousTagAggregator<T>(ITextBuffer textBuffer) where T : ITag;

		/// <summary>
		/// Creates a <see cref="ISynchronousTagAggregator{T}"/>
		/// </summary>
		/// <typeparam name="T">Tag type</typeparam>
		/// <param name="textBuffer">Text buffer</param>
		/// <param name="options">Options</param>
		/// <returns></returns>
		ISynchronousTagAggregator<T> CreateSynchronousTagAggregator<T>(ITextBuffer textBuffer, TagAggregatorOptions options) where T : ITag;
	}
}

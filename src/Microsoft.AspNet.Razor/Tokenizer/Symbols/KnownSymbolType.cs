// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNet.Razor.Tokenizer.Symbols
{
    public enum KnownSymbolType
    {
        WhiteSpace,
        NewLine,
        Identifier,
        Keyword,
        Transition,
        Unknown,
        CommentStart,
        CommentStar,
        CommentBody
    }
}

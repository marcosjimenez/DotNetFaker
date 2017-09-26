// Copyright (c) Marcos Jiménez, All rights reserved.
// Licensed under the MIT License
// Author:                  Marcos Jiménez
// Created:                 2017-03-13
// Last Modified:           2017-09-25

namespace DotNetFaker.Core.Common
{
    /// <summary>
    /// Available generators (CORE)
    /// </summary>
    public enum GeneratorType
    {
        Custom,
        String,
        PersonName,
        Address,
        CompanyName,
        IntAutoIncrement,
        DateTime,
        Guid
    }

    /// <summary>
    /// Available string lists
    /// </summary>
    public enum StringLists
    {
        PersonName,
        Address,
        CompanyName
    }

}

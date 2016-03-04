﻿//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

namespace MediaAppSample.Core.Data
{
    public sealed class DataSource
    {
        /// <summary>
        /// Gets access to the singleton data source provider instance. 
        /// </summary>
        public static IDataSource Current { get; set; }

        static DataSource()
        {
            Current = new SampleLocalData.SampleLocalDataSource();
            //Current = new Channel9Data.Channel9DataSource();
        }
    }
}
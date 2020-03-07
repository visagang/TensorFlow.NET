﻿/*****************************************************************************
   Copyright 2018 The TensorFlow.NET Authors. All Rights Reserved.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
******************************************************************************/

using System;
using System.Runtime.InteropServices;

namespace Tensorflow
{
    public partial class c_api
    {
        /// <summary>
        /// Specify the device for `desc`.  Defaults to empty, meaning unconstrained.
        /// </summary>
        /// <param name="desc"></param>
        /// <param name="device"></param>
        [DllImport(TensorFlowLibName)]
        public static extern void TF_SetDevice(IntPtr desc, string device);

        /// <summary>
        /// Counts the number of elements in the device list.
        /// </summary>
        /// <param name="list">TF_DeviceList*</param>
        /// <returns></returns>
        [DllImport(TensorFlowLibName)]
        public static extern int TF_DeviceListCount(IntPtr list);

        /// <summary>
        /// Deallocates the device list.
        /// </summary>
        /// <param name="list">TF_DeviceList*</param>
        [DllImport(TensorFlowLibName)]
        public static extern void TF_DeleteDeviceList(IntPtr list);

        /// <summary>
        /// Retrieves the full name of the device (e.g. /job:worker/replica:0/...)
        /// The return value will be a pointer to a null terminated string. The caller
        /// must not modify or delete the string. It will be deallocated upon a call to
        /// TF_DeleteDeviceList.
        /// </summary>
        /// <param name="list">TF_DeviceList*</param>
        /// <param name="index"></param>
        /// <param name="status">TF_Status*</param>
        [DllImport(TensorFlowLibName)]
        public static extern string TF_DeviceListName(IntPtr list, int index, IntPtr status);
    }
}
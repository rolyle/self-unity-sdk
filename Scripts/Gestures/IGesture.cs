﻿/**
* Copyright 2016 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System.Collections;

namespace Assets.SelfUnitySDK.Scripts.Gestures
{
    //! This is the base class for a self gesture. 
    public abstract class IGesture
    {
        #region Interface
        public abstract bool OnStart();     // this is invoked to start this gesture, if false is returned then the gesture will not be registered.
        public abstract bool OnStop();      // invoked to shutdown this gesture
        public abstract bool CanExecute( IDictionary a_Params );        // invoked to check if this gesture can be executed with the given parameters
        #endregion
    }
}

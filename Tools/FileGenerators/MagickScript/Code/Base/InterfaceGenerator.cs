﻿// Copyright 2013-2017 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

namespace FileGenerator.MagickScript
{
    internal sealed class InterfaceGenerator : CreateObjectCodeGenerator
    {
        private string _ClassName;
        private string _ReturnType;

        protected override string ReturnType
        {
            get
            {
                return _ReturnType;
            }
        }

        public InterfaceGenerator(CodeGenerator parent, string interfaceName, string className)
          : base(parent)
        {
            _ClassName = className;
            _ReturnType = interfaceName;
        }

        public override string ClassName
        {
            get
            {
                return _ClassName;
            }
        }
    }
}

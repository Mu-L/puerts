/*
* Tencent is pleased to support the open source community by making Puerts available.
* Copyright (C) 2020 Tencent.  All rights reserved.
* Puerts is licensed under the BSD 3-Clause License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms.
* This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
*/

using UnrealBuildTool;


namespace UnrealBuildTool.Rules
{
    public class ParamDefaultValueMetas : ModuleRules
    {
        public ParamDefaultValueMetas(ReadOnlyTargetRules Target) : base(Target)
        {
            bEnforceIWYU = false;

            PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

            PublicIncludePaths.AddRange(
                new string[] {
                    "Programs/UnrealHeaderTool/Public",
                }
                );


            PrivateIncludePaths.AddRange(
                new string[] {
                    "JsEnv/Public",
                }
                );


            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                    "Core",
                    "CoreUObject",
                }
                );
        }
    }
}

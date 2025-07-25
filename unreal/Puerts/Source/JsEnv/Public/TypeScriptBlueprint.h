/*
 * Tencent is pleased to support the open source community by making Puerts available.
 * Copyright (C) 2020 Tencent.  All rights reserved.
 * Puerts is licensed under the BSD 3-Clause License, except for the third-party components listed in the file 'LICENSE' which may
 * be subject to their corresponding license terms. This file is subject to the terms and conditions defined in file 'LICENSE',
 * which is part of this source code package.
 */

#pragma once

#include "CoreMinimal.h"
#include "Engine/Blueprint.h"
#include "TypeScriptBlueprint.generated.h"

/**
 *
 */
UCLASS()
class JSENV_API UTypeScriptBlueprint : public UBlueprint
{
    GENERATED_BODY()

public:
#if WITH_EDITOR
    virtual UClass* GetBlueprintClass() const override;
#endif
};

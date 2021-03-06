// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using System.Collections.Generic;
using UnityEditor.ShortcutManagement;

interface IConflictResolver
{
    void ResolveConflict(List<KeyCombination> keyCombinationSequence, List<ShortcutEntry> entries);
}
